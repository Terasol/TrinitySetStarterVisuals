namespace TrinitySetStarterVisuals;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.textBox_RomFS_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_906 = new TrinitySetStarterVisuals.UInt16TextBox();
            this.textBox_909 = new TrinitySetStarterVisuals.UInt16TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_912 = new TrinitySetStarterVisuals.UInt16TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_open_FileBrowser = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_common_0060_main = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_common_0060_always = new System.Windows.Forms.CheckBox();
            this.checkBox_d030_d030 = new System.Windows.Forms.CheckBox();
            this.checkBox_common_0070_always = new System.Windows.Forms.CheckBox();
            this.checkBox_common_0088_always = new System.Windows.Forms.CheckBox();
            this.checkBox_common_0090_main = new System.Windows.Forms.CheckBox();
            this.button_Create_Mod = new System.Windows.Forms.Button();
            this.button_Export_Settings = new System.Windows.Forms.Button();
            this.button_open_FileBrowser_2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Output_Path = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_RomFS_Path
            // 
            this.textBox_RomFS_Path.Location = new System.Drawing.Point(15, 27);
            this.textBox_RomFS_Path.Name = "textBox_RomFS_Path";
            this.textBox_RomFS_Path.Size = new System.Drawing.Size(273, 23);
            this.textBox_RomFS_Path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "RomFS Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "National Dex IDs to Replace the default starters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sprigatito";
            // 
            // textBox_906
            // 
            this.textBox_906.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_906.Location = new System.Drawing.Point(3, 18);
            this.textBox_906.Name = "textBox_906";
            this.textBox_906.Size = new System.Drawing.Size(91, 23);
            this.textBox_906.TabIndex = 4;
            this.textBox_906.Text = "906";
            // 
            // textBox_909
            // 
            this.textBox_909.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_909.Location = new System.Drawing.Point(100, 18);
            this.textBox_909.Name = "textBox_909";
            this.textBox_909.Size = new System.Drawing.Size(91, 23);
            this.textBox_909.TabIndex = 6;
            this.textBox_909.Text = "909";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fuecoco";
            // 
            // textBox_912
            // 
            this.textBox_912.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_912.Location = new System.Drawing.Point(197, 18);
            this.textBox_912.Name = "textBox_912";
            this.textBox_912.Size = new System.Drawing.Size(93, 23);
            this.textBox_912.TabIndex = 8;
            this.textBox_912.Text = "912";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(197, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quaxly";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_912, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_906, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_909, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 143);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 45);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.UseDescriptionForTitle = true;
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.Recent;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // button_open_FileBrowser
            // 
            this.button_open_FileBrowser.Location = new System.Drawing.Point(283, 27);
            this.button_open_FileBrowser.Name = "button_open_FileBrowser";
            this.button_open_FileBrowser.Size = new System.Drawing.Size(22, 23);
            this.button_open_FileBrowser.TabIndex = 10;
            this.button_open_FileBrowser.Text = "📂";
            this.button_open_FileBrowser.UseVisualStyleBackColor = true;
            this.button_open_FileBrowser.Click += new System.EventHandler(this.button_open_FileBrowser_Click);
            // 
            // checkBox_common_0060_main
            // 
            this.checkBox_common_0060_main.AutoSize = true;
            this.checkBox_common_0060_main.Location = new System.Drawing.Point(12, 241);
            this.checkBox_common_0060_main.Name = "checkBox_common_0060_main";
            this.checkBox_common_0060_main.Size = new System.Drawing.Size(136, 19);
            this.checkBox_common_0060_main.TabIndex = 11;
            this.checkBox_common_0060_main.Text = "common_0060_main";
            this.checkBox_common_0060_main.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select in whitch Scenes the visuals should be Replaced";
            // 
            // checkBox_common_0060_always
            // 
            this.checkBox_common_0060_always.AutoSize = true;
            this.checkBox_common_0060_always.Location = new System.Drawing.Point(12, 266);
            this.checkBox_common_0060_always.Name = "checkBox_common_0060_always";
            this.checkBox_common_0060_always.Size = new System.Drawing.Size(144, 19);
            this.checkBox_common_0060_always.TabIndex = 13;
            this.checkBox_common_0060_always.Text = "common_0060_always";
            this.checkBox_common_0060_always.UseVisualStyleBackColor = true;
            // 
            // checkBox_d030_d030
            // 
            this.checkBox_d030_d030.AutoSize = true;
            this.checkBox_d030_d030.Location = new System.Drawing.Point(12, 291);
            this.checkBox_d030_d030.Name = "checkBox_d030_d030";
            this.checkBox_d030_d030.Size = new System.Drawing.Size(81, 19);
            this.checkBox_d030_d030.TabIndex = 14;
            this.checkBox_d030_d030.Text = "d030_d030";
            this.checkBox_d030_d030.UseVisualStyleBackColor = true;
            // 
            // checkBox_common_0070_always
            // 
            this.checkBox_common_0070_always.AutoSize = true;
            this.checkBox_common_0070_always.Location = new System.Drawing.Point(12, 316);
            this.checkBox_common_0070_always.Name = "checkBox_common_0070_always";
            this.checkBox_common_0070_always.Size = new System.Drawing.Size(144, 19);
            this.checkBox_common_0070_always.TabIndex = 15;
            this.checkBox_common_0070_always.Text = "common_0070_always";
            this.checkBox_common_0070_always.UseVisualStyleBackColor = true;
            // 
            // checkBox_common_0088_always
            // 
            this.checkBox_common_0088_always.AutoSize = true;
            this.checkBox_common_0088_always.Location = new System.Drawing.Point(12, 341);
            this.checkBox_common_0088_always.Name = "checkBox_common_0088_always";
            this.checkBox_common_0088_always.Size = new System.Drawing.Size(144, 19);
            this.checkBox_common_0088_always.TabIndex = 16;
            this.checkBox_common_0088_always.Text = "common_0088_always";
            this.checkBox_common_0088_always.UseVisualStyleBackColor = true;
            // 
            // checkBox_common_0090_always
            // 
            this.checkBox_common_0090_main.AutoSize = true;
            this.checkBox_common_0090_main.Location = new System.Drawing.Point(12, 366);
            this.checkBox_common_0090_main.Name = "checkBox_common_0090_main";
            this.checkBox_common_0090_main.Size = new System.Drawing.Size(144, 19);
            this.checkBox_common_0090_main.TabIndex = 17;
            this.checkBox_common_0090_main.Text = "common_0090_main";
            this.checkBox_common_0090_main.UseVisualStyleBackColor = true;
            // 
            // button_Create_Mod
            // 
            this.button_Create_Mod.Location = new System.Drawing.Point(12, 400);
            this.button_Create_Mod.Name = "button_Create_Mod";
            this.button_Create_Mod.Size = new System.Drawing.Size(91, 23);
            this.button_Create_Mod.TabIndex = 18;
            this.button_Create_Mod.Text = "Create Mod";
            this.button_Create_Mod.UseVisualStyleBackColor = true;
            this.button_Create_Mod.Click += new System.EventHandler(this.button_Create_Mod_Click);
            // 
            // button_Export_Settings
            // 
            this.button_Export_Settings.Location = new System.Drawing.Point(202, 400);
            this.button_Export_Settings.Name = "button_Export_Settings";
            this.button_Export_Settings.Size = new System.Drawing.Size(103, 23);
            this.button_Export_Settings.TabIndex = 19;
            this.button_Export_Settings.Text = "Export Settings";
            this.button_Export_Settings.UseVisualStyleBackColor = true;
            this.button_Export_Settings.Click += new System.EventHandler(this.button_Export_Settings_Click);
            // 
            // button_open_FileBrowser_2
            // 
            this.button_open_FileBrowser_2.Location = new System.Drawing.Point(283, 74);
            this.button_open_FileBrowser_2.Name = "button_open_FileBrowser_2";
            this.button_open_FileBrowser_2.Size = new System.Drawing.Size(22, 23);
            this.button_open_FileBrowser_2.TabIndex = 22;
            this.button_open_FileBrowser_2.Text = "📂";
            this.button_open_FileBrowser_2.UseVisualStyleBackColor = true;
            this.button_open_FileBrowser_2.Click += new System.EventHandler(this.button_open_FileBrowser_2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Output Folder";
            // 
            // textBox_Output_Path
            // 
            this.textBox_Output_Path.Location = new System.Drawing.Point(15, 74);
            this.textBox_Output_Path.Name = "textBox_Output_Path";
            this.textBox_Output_Path.Size = new System.Drawing.Size(273, 23);
            this.textBox_Output_Path.TabIndex = 20;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Json files|*.json";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 435);
            this.Controls.Add(this.button_open_FileBrowser_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Output_Path);
            this.Controls.Add(this.button_Export_Settings);
            this.Controls.Add(this.button_Create_Mod);
            this.Controls.Add(this.checkBox_common_0090_main);
            this.Controls.Add(this.checkBox_common_0088_always);
            this.Controls.Add(this.checkBox_common_0070_always);
            this.Controls.Add(this.checkBox_d030_d030);
            this.Controls.Add(this.checkBox_common_0060_always);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_common_0060_main);
            this.Controls.Add(this.button_open_FileBrowser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RomFS_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Set Trinity Starter Visuals";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    internal TextBox textBox_RomFS_Path;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    internal UInt16TextBox textBox_906;
    internal UInt16TextBox textBox_909;
    internal UInt16TextBox textBox_912;
    private TableLayoutPanel tableLayoutPanel1;
    private FolderBrowserDialog folderBrowserDialog1;
    private Button button_open_FileBrowser;
    private ToolTip toolTip1;
    internal CheckBox checkBox_common_0060_main;
    private Label label6;
    internal CheckBox checkBox_common_0060_always;
    internal CheckBox checkBox_d030_d030;
    internal CheckBox checkBox_common_0070_always;
    internal CheckBox checkBox_common_0088_always;
    internal CheckBox checkBox_common_0090_main;
    private Button button_Create_Mod;
    private Button button_Export_Settings;
    private Button button_open_FileBrowser_2;
    private Label label7;
    internal TextBox textBox_Output_Path;
    private SaveFileDialog saveFileDialog1;
}
