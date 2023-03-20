namespace TrinitySetStarterVisuals
{
    public class Settings
    {
        public Settings(Main main)
        {
            RomFS_Path = main.textBox_RomFS_Path.Text;
            Output_Folder = main.textBox_Output_Path.Text;
            Replace_906 = Convert.ToUInt16(main.textBox_906.Text);
            Replace_909 = Convert.ToUInt16(main.textBox_909.Text);
            Replace_912 = Convert.ToUInt16(main.textBox_912.Text);
            common_0060_always = main.checkBox_common_0060_always.Checked;
            common_0060_main = main.checkBox_common_0060_main.Checked;
            common_0070_always = main.checkBox_common_0070_always.Checked;
            common_0088_always = main.checkBox_common_0088_always.Checked;
            common_0090_main = main.checkBox_common_0090_main.Checked;
            d030_d030 = main.checkBox_d030_d030.Checked;
        }

        public Settings()
        {
            Output_Folder = "";
            RomFS_Path = "";
        }

        public bool common_0060_always { get; set; }

        public bool common_0060_main { get; set; }

        public bool common_0070_always { get; set; }

        public bool common_0088_always { get; set; }

        public bool common_0090_main { get; set; }

        public bool d030_d030 { get; set; }

        public string Output_Folder { get; set; }

        public ushort Replace_906 { get; set; }

        public ushort Replace_909 { get; set; }

        public ushort Replace_912 { get; set; }

        public string RomFS_Path { get; set; }
    }
}