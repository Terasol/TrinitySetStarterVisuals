﻿using System.Text;
using Titan.FileSystem;

namespace TrinitySetStarterVisuals
{
    public class Filesystem : IDisposable
    {
        private readonly string _romFS_path;

        private bool _data_file_present = false;

        private FileStream? fs;

        private TRPFDT TRPFDT;

        private TRPFST TRPFST;

        public Filesystem(string RomFS_Path)
        {
            _romFS_path = RomFS_Path;
            string TRPFDT_path = Path.Combine(_romFS_path, "arc\\data.trpfd");
            string TRPFDS_path = Path.Combine(_romFS_path, "arc\\data.trpfs");
            if (Path.Exists(TRPFDS_path) && Path.Exists(TRPFDT_path))
            {
                fs = File.Open(TRPFDS_path, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] buffer = new byte[8];
                fs.ReadExactly(buffer, 0, 8);
                string magic = Encoding.Default.GetString(buffer);
                if (magic == "ONEPACK\0")
                {
                    fs.ReadExactly(buffer, 0, 8);
                    long beginn_offset = BitConverter.ToInt64(buffer, 0);
                    fs.Seek(0, SeekOrigin.End);
                    long eof_offset = fs.Position;
                    buffer = new byte[eof_offset - beginn_offset];
                    fs.Seek(beginn_offset, SeekOrigin.Begin);
                    fs.ReadExactly(buffer, 0, buffer.Length);
                    TRPFST = TRPFST.DeserializeFromBinary(buffer);
                    TRPFST.FileOffsets.Add((ulong)eof_offset);
                    TRPFDT = TRPFDT.DeserializeFromBinary(File.ReadAllBytes(TRPFDT_path));
                    _data_file_present = true;
                }
                else
                {
                    fs.Close();
                    fs.Dispose();
                    _data_file_present = false;
                }
            }
            else
            {
                _data_file_present = false;
            }
        }

        public void Dispose()
        {
            if (fs != null) ((IDisposable)fs).Dispose();
        }

        public ulong FNV1a64(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            const ulong fnv64Offset = 0xCBF29CE484222645;
            const ulong fnv64Prime = 0x00000100000001b3;
            ulong hash = fnv64Offset;

            for (var i = 0; i < bytes.Length; i++)
            {
                hash = hash ^ bytes[i];
                hash *= fnv64Prime;
            }

            return hash;
        }

        public byte[] GetFile(string FilePath)
        {
            if (_data_file_present)
                return GetFile(FNV1a64(FilePath), FilePath);
            else
            {
                if (Path.Exists(Path.Combine(_romFS_path, FilePath))) return File.ReadAllBytes(Path.Combine(_romFS_path, FilePath));
                else
                {
                    MessageBox.Show($"data.trpfd or data.trpfs not found and {Path.Combine(_romFS_path, FilePath)} is not present");
                }
            }
            return Array.Empty<byte>();
        }

        private byte[] GetFile(ulong FileHash, string FilePath)
        {
            int index = TRPFDT.FileHashes.IndexOf(FileHash);
            if (index != -1)
            {
                int packindex = (int)TRPFDT.Files[index].PackIndex;

                ulong packhash = FNV1a64(TRPFDT.PackStrings[packindex]);
                int ind = TRPFST.FileHashes.IndexOf(packhash);

                ulong offset = TRPFST.FileOffsets[ind];
                ulong end_offset = TRPFST.FileOffsets[ind + 1];

                byte[] data = new byte[end_offset - offset];

                fs.Seek((long)offset, SeekOrigin.Begin);
                fs.Read(data, 0, data.Length);
                File.WriteAllBytes("dumb.trpak", data);
                TRPAKT tr = TRPAKT.DeserializeFromBinary(data);

                int tr_file_index = tr.FileHashes.IndexOf(FileHash);

                data = tr.FileEntry[tr_file_index].FileByteBuffer.ToArray();

                if (tr.FileEntry[tr_file_index].EncryptType == EncryptType.Oodle)
                {
                    byte[] FileDatadecompressed = Oodle.Decompress(data, (long)tr.FileEntry[tr_file_index].FileSize);
                    data = FileDatadecompressed;
                }

                return data;
            }
            else
            {
                MessageBox.Show($"could not find {FilePath} in data.trpfs/data.trpfd");
            }
            return Array.Empty<byte>();
        }
    }
}