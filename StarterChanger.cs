using System.IO.Compression;
using Titan.TrinityScene;

namespace TrinitySetStarterVisuals
{
    internal static class StarterChanger
    {
        private static List<string> _files;
        private static Filesystem _fs;
        private static Settings _settings;

        internal static void ChangeStarters(Settings settings)
        {
            _settings = settings;
            _fs = new Filesystem(settings.RomFS_Path);
            Gather_files();
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            foreach (string file in _files)
            {
                HandleFile(file, tempDirectory);
            }
            List<string> toml = new()
            {
                "display_name = \"Changed Starter Visuals\"",
                "description = \"\"\"",
                "Created by TrinitySetStarterVisuals",
                "",
                "Changes the visuals for the 3 starters in the opening cutscenes.",
                "",
                "\"\"\"",
                "version = \"1.0.0\"",
            };
            File.WriteAllLines(Path.Combine(tempDirectory, "info.toml"), toml);

            string zipfile = Path.Combine(_settings.Output_Folder, $"TrinitySetStarterVisuals_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.zip");

            ZipFile.CreateFromDirectory(tempDirectory, zipfile);

            Directory.Delete(tempDirectory, true);
        }

        private static void Gather_files()
        {
            _files = new();
            if (_settings.common_0060_main)
            {
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0060_/common_0060_main_0.trsog");
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0060_/common_0060_main_1.trsog");
            }
            if (_settings.common_0060_always)
            {
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0060_/common_0060_always_0.trsog");
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0060_/common_0060_always_1.trsog");
            }
            if (_settings.common_0070_always)
            {
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0070_/common_0070_always_0.trsog");
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0070_/common_0070_always_1.trsog");
            }
            if (_settings.common_0088_always)
            {
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0088_/common_0088_always_0.trsog");
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0088_/common_0088_always_1.trsog");
            }
            if (_settings.common_0090_main)
            {
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0090_/common_0090_main_0.trsog");
                _files.Add(@"world/scene/parts/event/event_scenario/main_scenario/common_0090_/common_0090_main_1.trsog");
            }
            if (_settings.d030_d030)
            {
                _files.Add(@"world/scene/parts/demo/ev/d030_/d030_0.trscn");
                _files.Add(@"world/scene/parts/demo/ev/d030_/d030_1.trscn");
            }
        }

        private static void handle_SceneObjects(List<SceneEntryT> SceneObjects)
        {
            foreach (SceneEntryT sceneEntry in SceneObjects)
            {
                if (sceneEntry.TypeName == "ti_PokemonModelComponent")
                {
                    ti_PokemonModelComponentT pmc = ti_PokemonModelComponentT.DeserializeFromBinary(sceneEntry.NestedType.ToArray());
                    if (pmc.NationalDexId == 906) pmc.NationalDexId = _settings.Replace_906;
                    if (pmc.NationalDexId == 909) pmc.NationalDexId = _settings.Replace_909;
                    if (pmc.NationalDexId == 912) pmc.NationalDexId = _settings.Replace_912;
                    sceneEntry.NestedType = pmc.SerializeToBinary().ToList();
                }
                if (sceneEntry.TypeName == "ti_FieldPokemonComponent")
                {
                    ti_FieldPokemonComponentT fpc = ti_FieldPokemonComponentT.DeserializeFromBinary(sceneEntry.NestedType.ToArray());
                    if (fpc.NationalDexId == 906) fpc.NationalDexId = _settings.Replace_906;
                    if (fpc.NationalDexId == 909) fpc.NationalDexId = _settings.Replace_909;
                    if (fpc.NationalDexId == 912) fpc.NationalDexId = _settings.Replace_912;
                    sceneEntry.NestedType = fpc.SerializeToBinary().ToList();
                }
                if (sceneEntry.SubObjects.Count > 0)
                {
                    handle_SceneObjects(sceneEntry.SubObjects);
                }
            }
        }

        private static void HandleFile(string Filepath, string tmp_romfs_folder)
        {
            byte[] data = _fs.GetFile(Filepath);
            if (data.Length > 0)
            {
                trinity_SceneT scene = trinity_SceneT.DeserializeFromBinary(data);
                handle_SceneObjects(scene.SceneObjectList);
                string new_path = Path.Combine(tmp_romfs_folder, Filepath);
                Directory.CreateDirectory(Path.GetDirectoryName(new_path));
                File.WriteAllBytes(new_path, scene.SerializeToBinary());
            }
        }
    }
}