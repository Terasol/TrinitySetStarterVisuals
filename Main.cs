using System.Text.Json;

namespace TrinitySetStarterVisuals;

public partial class Main : Form
{
    public Main(Settings? settings)
    {
        InitializeComponent();
        SetupTooltips();
        if (settings != null)
        {
            textBox_RomFS_Path.Text = settings.RomFS_Path;
            textBox_Output_Path.Text = settings.Output_Folder;
            textBox_906.Text = settings.Replace_906.ToString();
            textBox_909.Text = settings.Replace_909.ToString();
            textBox_912.Text = settings.Replace_912.ToString();
            checkBox_common_0060_always.Checked = settings.common_0060_always;
            checkBox_common_0060_main.Checked = settings.common_0060_main;
            checkBox_common_0070_always.Checked = settings.common_0070_always;
            checkBox_common_0088_always.Checked = settings.common_0088_always;
            checkBox_common_0090_main.Checked = settings.common_0090_main;
            checkBox_d030_d030.Checked = settings.d030_d030;
        }
    }

    private void button_Create_Mod_Click(object sender, EventArgs e) => StarterChanger.ChangeStarters(GetSettings());

    private void button_Export_Settings_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string json = JsonSerializer.Serialize<Settings>(GetSettings(), options);
            File.WriteAllText(saveFileDialog1.FileName, json);
        }
    }

    private void button_open_FileBrowser_2_Click(object sender, EventArgs e)
    {
        folderBrowserDialog1.Description = "Please select the Folder to save the finished mod to";
        folderBrowserDialog1.ShowNewFolderButton = true;
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox_Output_Path.Text = folderBrowserDialog1.SelectedPath;
        }
    }

    private void button_open_FileBrowser_Click(object sender, EventArgs e)
    {
        folderBrowserDialog1.Description = "Please select the Root of the RomFS Dump";
        folderBrowserDialog1.ShowNewFolderButton = false;
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox_RomFS_Path.Text = folderBrowserDialog1.SelectedPath;
        }
    }

    private Settings GetSettings()
    {
        return new(this);
    }

    private void SetupTooltips()
    {
        toolTip1.SetToolTip(textBox_906, "National Dex ID to Replace Sprigatito with in the cutscenes");
        toolTip1.SetToolTip(textBox_909, "National Dex ID to Replace Fuecoco with in the cutscenes");
        toolTip1.SetToolTip(textBox_912, "National Dex ID to Replace Quaxly with in the cutscenes");
        toolTip1.SetToolTip(checkBox_common_0060_always, "Models shown while walking from the players house to Nemonas house");
        toolTip1.SetToolTip(checkBox_common_0060_main, "Models shown while in the cutscene in front of the players house");
        toolTip1.SetToolTip(checkBox_d030_d030, "Models shown while in the cinematic cuscene in front of Nemonas house (this can be fairly broken because of the complex animations)");
        toolTip1.SetToolTip(checkBox_common_0070_always, "Models shown while in the cuscene after the cinematic cuscene in front of Nemonas house and while picking your starter");
        toolTip1.SetToolTip(checkBox_common_0088_always, "Models shown while in the cuscene after picking your starter");
        toolTip1.SetToolTip(checkBox_common_0090_main, "Models shown while in the cutscene on the beach before and after the battle against Nemona");
    }
}