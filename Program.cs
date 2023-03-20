using System.Text.Json;

namespace TrinitySetStarterVisuals;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args)
    {
        Settings? s = null;
        bool silent = false;
        if (args.Length > 0)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--config":
                        if (args.Length <= args.Length + 1)
                        {
                            if (File.Exists(args[i + 1]))
                            {
                                string json = File.ReadAllText(args[i + 1]);
                                s = JsonSerializer.Deserialize<Settings>(json);
                                i++;
                            }
                            else
                            {
                                ShowError($"The Config File {args[i + 1]} does not exist", true);
                                Environment.Exit(2);
                            }
                        }
                        else
                        {
                            ShowError("Config File Missing", true);
                            Environment.Exit(1);
                        }
                        break;

                    case "--silent":
                        silent = true;
                        break;

                    default:
                        ShowError("", true);
                        Environment.Exit(0);
                        break;
                }
            }
        }
        if (!silent)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main(s));
        }
        else
        {
            if (s != null)
                StarterChanger.ChangeStarters(s);
            else
            {
                ShowError("missing Config File", true);
                Environment.Exit(3);
            }
        }
    }

    private static void ShowError(string Error_text, bool print_help)
    {
        if (Error_text != "")
            MessageBox.Show(Error_text);
        if (print_help)
        {
            List<string> lines = new() {
            $"usage: {Path.GetFileName(Application.ExecutablePath)} [options]",
            "  options:",
            "    --config /path/to/config.json -> loads the specified Config file",
            "    --silent -> Does not show the GUI and directly executes the Config"
            };
            MessageBox.Show(string.Join("\n", lines));
        }
    }
}