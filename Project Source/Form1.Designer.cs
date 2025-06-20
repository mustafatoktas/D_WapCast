namespace WapCast
{
    partial class FormWapCast
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWapCast));
            menuStrip = new MenuStrip();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            karanlıkTemaToolStripMenuItem = new ToolStripMenuItem();
            orjinalFormBoyutuToolStripMenuItem = new ToolStripMenuItem();
            kullanımToolStripMenuItem = new ToolStripMenuItem();
            geliştiriciToolStripMenuItem = new ToolStripMenuItem();
            mustafaTOKTAŞToolStripMenuItem = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            linkedInToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            gitHubRepositoryToolStripMenuItem = new ToolStripMenuItem();
            licenseToolStripMenuItem = new ToolStripMenuItem();
            v100ToolStripMenuItem = new ToolStripMenuItem();
            btnStart = new Button();
            btnOpenWhatsappWEB = new Button();
            tbLog = new TextBox();
            tabControl1 = new TabControl();
            tabPageImageMessage = new TabPage();
            pictureBox3 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            lblImagePath = new Label();
            btnSelectImage = new Button();
            btnOpenImageFile = new Button();
            btnExportExample = new Button();
            groupBox3 = new GroupBox();
            tbImageMessageText = new TextBox();
            checkBoxAddMessage = new CheckBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            tbYKoordinat = new TextBox();
            tbXKoordinat = new TextBox();
            label4 = new Label();
            tbFontSize = new TextBox();
            label3 = new Label();
            tbImageText = new TextBox();
            checkBoxAddImageText = new CheckBox();
            groupBoxFont = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSelectFont = new Button();
            lblFontPath = new Label();
            checkBoxAddFont = new CheckBox();
            tabPageTextMessage = new TabPage();
            tbTextMessageText = new TextBox();
            label2 = new Label();
            lblExcelPath = new Label();
            btnSelectExcel = new Button();
            label6 = new Label();
            comboBoxWaitingTimeSelector = new ComboBox();
            label8 = new Label();
            btnClearLog = new Button();
            progressBar = new ProgressBar();
            lblRecommendedSecond = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnOpenExcelFile = new Button();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel4 = new TableLayoutPanel();
            menuStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageImageMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxFont.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPageTextMessage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(menuStrip, "menuStrip");
            menuStrip.Items.AddRange(new ToolStripItem[] { ayarlarToolStripMenuItem, kullanımToolStripMenuItem, geliştiriciToolStripMenuItem, hakkındaToolStripMenuItem });
            menuStrip.Name = "menuStrip";
            toolTip1.SetToolTip(menuStrip, resources.GetString("menuStrip.ToolTip"));
            // 
            // ayarlarToolStripMenuItem
            // 
            resources.ApplyResources(ayarlarToolStripMenuItem, "ayarlarToolStripMenuItem");
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { karanlıkTemaToolStripMenuItem, orjinalFormBoyutuToolStripMenuItem });
            ayarlarToolStripMenuItem.Image = Properties.Resources.Settings;
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            // 
            // karanlıkTemaToolStripMenuItem
            // 
            resources.ApplyResources(karanlıkTemaToolStripMenuItem, "karanlıkTemaToolStripMenuItem");
            karanlıkTemaToolStripMenuItem.Image = Properties.Resources.Moon_Symbol;
            karanlıkTemaToolStripMenuItem.Name = "karanlıkTemaToolStripMenuItem";
            karanlıkTemaToolStripMenuItem.Click += karanlıkTemaToolStripMenuItem_Click;
            // 
            // orjinalFormBoyutuToolStripMenuItem
            // 
            resources.ApplyResources(orjinalFormBoyutuToolStripMenuItem, "orjinalFormBoyutuToolStripMenuItem");
            orjinalFormBoyutuToolStripMenuItem.Image = Properties.Resources.Resolution;
            orjinalFormBoyutuToolStripMenuItem.Name = "orjinalFormBoyutuToolStripMenuItem";
            orjinalFormBoyutuToolStripMenuItem.Click += orjinalFormBoyutuToolStripMenuItem_Click;
            // 
            // kullanımToolStripMenuItem
            // 
            resources.ApplyResources(kullanımToolStripMenuItem, "kullanımToolStripMenuItem");
            kullanımToolStripMenuItem.Image = Properties.Resources.User_Manual;
            kullanımToolStripMenuItem.Name = "kullanımToolStripMenuItem";
            kullanımToolStripMenuItem.Click += kullanımToolStripMenuItem_Click;
            // 
            // geliştiriciToolStripMenuItem
            // 
            resources.ApplyResources(geliştiriciToolStripMenuItem, "geliştiriciToolStripMenuItem");
            geliştiriciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mustafaTOKTAŞToolStripMenuItem, gitHubToolStripMenuItem, linkedInToolStripMenuItem });
            geliştiriciToolStripMenuItem.Image = Properties.Resources.Businessman;
            geliştiriciToolStripMenuItem.Name = "geliştiriciToolStripMenuItem";
            // 
            // mustafaTOKTAŞToolStripMenuItem
            // 
            resources.ApplyResources(mustafaTOKTAŞToolStripMenuItem, "mustafaTOKTAŞToolStripMenuItem");
            mustafaTOKTAŞToolStripMenuItem.Image = Properties.Resources._1;
            mustafaTOKTAŞToolStripMenuItem.Name = "mustafaTOKTAŞToolStripMenuItem";
            // 
            // gitHubToolStripMenuItem
            // 
            resources.ApplyResources(gitHubToolStripMenuItem, "gitHubToolStripMenuItem");
            gitHubToolStripMenuItem.Image = Properties.Resources.GitHub;
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Click += gitHubToolStripMenuItem_Click;
            // 
            // linkedInToolStripMenuItem
            // 
            resources.ApplyResources(linkedInToolStripMenuItem, "linkedInToolStripMenuItem");
            linkedInToolStripMenuItem.Image = Properties.Resources.LinkedIn;
            linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            linkedInToolStripMenuItem.Click += linkedInToolStripMenuItem_Click;
            // 
            // hakkındaToolStripMenuItem
            // 
            resources.ApplyResources(hakkındaToolStripMenuItem, "hakkındaToolStripMenuItem");
            hakkındaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gitHubRepositoryToolStripMenuItem, licenseToolStripMenuItem, v100ToolStripMenuItem });
            hakkındaToolStripMenuItem.Image = Properties.Resources.Info;
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            // 
            // gitHubRepositoryToolStripMenuItem
            // 
            resources.ApplyResources(gitHubRepositoryToolStripMenuItem, "gitHubRepositoryToolStripMenuItem");
            gitHubRepositoryToolStripMenuItem.Image = Properties.Resources.GitHub1;
            gitHubRepositoryToolStripMenuItem.Name = "gitHubRepositoryToolStripMenuItem";
            gitHubRepositoryToolStripMenuItem.Click += gitHubRepositoryToolStripMenuItem_Click;
            // 
            // licenseToolStripMenuItem
            // 
            resources.ApplyResources(licenseToolStripMenuItem, "licenseToolStripMenuItem");
            licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            licenseToolStripMenuItem.Click += licenseToolStripMenuItem_Click;
            // 
            // v100ToolStripMenuItem
            // 
            resources.ApplyResources(v100ToolStripMenuItem, "v100ToolStripMenuItem");
            v100ToolStripMenuItem.Name = "v100ToolStripMenuItem";
            // 
            // btnStart
            // 
            resources.ApplyResources(btnStart, "btnStart");
            btnStart.ForeColor = Color.DodgerBlue;
            btnStart.Name = "btnStart";
            toolTip1.SetToolTip(btnStart, resources.GetString("btnStart.ToolTip"));
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnOpenWhatsappWEB
            // 
            resources.ApplyResources(btnOpenWhatsappWEB, "btnOpenWhatsappWEB");
            btnOpenWhatsappWEB.Name = "btnOpenWhatsappWEB";
            toolTip1.SetToolTip(btnOpenWhatsappWEB, resources.GetString("btnOpenWhatsappWEB.ToolTip"));
            btnOpenWhatsappWEB.UseVisualStyleBackColor = true;
            btnOpenWhatsappWEB.Click += btnOpenWhatsappWEB_Click;
            // 
            // tbLog
            // 
            resources.ApplyResources(tbLog, "tbLog");
            tbLog.Name = "tbLog";
            tbLog.ReadOnly = true;
            toolTip1.SetToolTip(tbLog, resources.GetString("tbLog.ToolTip"));
            tbLog.TextChanged += tbLog_TextChanged;
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPageImageMessage);
            tabControl1.Controls.Add(tabPageTextMessage);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            toolTip1.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPageImageMessage
            // 
            resources.ApplyResources(tabPageImageMessage, "tabPageImageMessage");
            tabPageImageMessage.Controls.Add(pictureBox3);
            tabPageImageMessage.Controls.Add(tableLayoutPanel2);
            tabPageImageMessage.Controls.Add(btnExportExample);
            tabPageImageMessage.Controls.Add(groupBox3);
            tabPageImageMessage.Controls.Add(groupBox2);
            tabPageImageMessage.Controls.Add(groupBoxFont);
            tabPageImageMessage.Name = "tabPageImageMessage";
            toolTip1.SetToolTip(tabPageImageMessage, resources.GetString("tabPageImageMessage.ToolTip"));
            tabPageImageMessage.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Image = Properties.Resources.Image_File;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            toolTip1.SetToolTip(pictureBox3, resources.GetString("pictureBox3.ToolTip"));
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.AllowDrop = true;
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(lblImagePath, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSelectImage, 3, 0);
            tableLayoutPanel2.Controls.Add(btnOpenImageFile, 2, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            toolTip1.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            tableLayoutPanel2.DragDrop += lblImagePath_DragDrop;
            tableLayoutPanel2.DragEnter += lblImagePath_DragEnter;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.AllowDrop = true;
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            label5.DragDrop += lblImagePath_DragDrop;
            label5.DragEnter += lblImagePath_DragEnter;
            // 
            // lblImagePath
            // 
            resources.ApplyResources(lblImagePath, "lblImagePath");
            lblImagePath.AllowDrop = true;
            lblImagePath.ForeColor = Color.Green;
            lblImagePath.Name = "lblImagePath";
            toolTip1.SetToolTip(lblImagePath, resources.GetString("lblImagePath.ToolTip"));
            lblImagePath.DragDrop += lblImagePath_DragDrop;
            lblImagePath.DragEnter += lblImagePath_DragEnter;
            // 
            // btnSelectImage
            // 
            resources.ApplyResources(btnSelectImage, "btnSelectImage");
            btnSelectImage.AllowDrop = true;
            btnSelectImage.Name = "btnSelectImage";
            toolTip1.SetToolTip(btnSelectImage, resources.GetString("btnSelectImage.ToolTip"));
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            btnSelectImage.DragDrop += lblImagePath_DragDrop;
            btnSelectImage.DragEnter += lblImagePath_DragEnter;
            // 
            // btnOpenImageFile
            // 
            resources.ApplyResources(btnOpenImageFile, "btnOpenImageFile");
            btnOpenImageFile.Name = "btnOpenImageFile";
            toolTip1.SetToolTip(btnOpenImageFile, resources.GetString("btnOpenImageFile.ToolTip"));
            btnOpenImageFile.UseVisualStyleBackColor = true;
            btnOpenImageFile.Click += btnOpenImageFile_Click;
            // 
            // btnExportExample
            // 
            resources.ApplyResources(btnExportExample, "btnExportExample");
            btnExportExample.BackColor = Color.FromArgb(80, 191, 250);
            btnExportExample.Cursor = Cursors.Hand;
            btnExportExample.Name = "btnExportExample";
            toolTip1.SetToolTip(btnExportExample, resources.GetString("btnExportExample.ToolTip"));
            btnExportExample.UseVisualStyleBackColor = false;
            btnExportExample.Click += btnExportExample_Click;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(tbImageMessageText);
            groupBox3.Controls.Add(checkBoxAddMessage);
            groupBox3.ForeColor = Color.DodgerBlue;
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            toolTip1.SetToolTip(groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // tbImageMessageText
            // 
            resources.ApplyResources(tbImageMessageText, "tbImageMessageText");
            tbImageMessageText.Name = "tbImageMessageText";
            toolTip1.SetToolTip(tbImageMessageText, resources.GetString("tbImageMessageText.ToolTip"));
            // 
            // checkBoxAddMessage
            // 
            resources.ApplyResources(checkBoxAddMessage, "checkBoxAddMessage");
            checkBoxAddMessage.ForeColor = SystemColors.ControlText;
            checkBoxAddMessage.Name = "checkBoxAddMessage";
            toolTip1.SetToolTip(checkBoxAddMessage, resources.GetString("checkBoxAddMessage.ToolTip"));
            checkBoxAddMessage.UseVisualStyleBackColor = true;
            checkBoxAddMessage.CheckedChanged += checkBoxAddMessage_CheckedChanged;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(tbYKoordinat);
            groupBox2.Controls.Add(tbXKoordinat);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbFontSize);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbImageText);
            groupBox2.Controls.Add(checkBoxAddImageText);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            toolTip1.SetToolTip(groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.Frame_110;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // tbYKoordinat
            // 
            resources.ApplyResources(tbYKoordinat, "tbYKoordinat");
            tbYKoordinat.Name = "tbYKoordinat";
            toolTip1.SetToolTip(tbYKoordinat, resources.GetString("tbYKoordinat.ToolTip"));
            tbYKoordinat.KeyPress += onlyDigitEntry;
            // 
            // tbXKoordinat
            // 
            resources.ApplyResources(tbXKoordinat, "tbXKoordinat");
            tbXKoordinat.Name = "tbXKoordinat";
            toolTip1.SetToolTip(tbXKoordinat, resources.GetString("tbXKoordinat.ToolTip"));
            tbXKoordinat.KeyPress += onlyDigitEntry;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.ControlText;
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // tbFontSize
            // 
            resources.ApplyResources(tbFontSize, "tbFontSize");
            tbFontSize.Name = "tbFontSize";
            toolTip1.SetToolTip(tbFontSize, resources.GetString("tbFontSize.ToolTip"));
            tbFontSize.KeyPress += onlyDigitEntry;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ControlText;
            label3.Name = "label3";
            toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // tbImageText
            // 
            resources.ApplyResources(tbImageText, "tbImageText");
            tbImageText.Name = "tbImageText";
            toolTip1.SetToolTip(tbImageText, resources.GetString("tbImageText.ToolTip"));
            // 
            // checkBoxAddImageText
            // 
            resources.ApplyResources(checkBoxAddImageText, "checkBoxAddImageText");
            checkBoxAddImageText.ForeColor = Color.Black;
            checkBoxAddImageText.Name = "checkBoxAddImageText";
            toolTip1.SetToolTip(checkBoxAddImageText, resources.GetString("checkBoxAddImageText.ToolTip"));
            checkBoxAddImageText.UseVisualStyleBackColor = true;
            checkBoxAddImageText.CheckedChanged += checkBoxAddImageText_CheckedChanged;
            // 
            // groupBoxFont
            // 
            resources.ApplyResources(groupBoxFont, "groupBoxFont");
            groupBoxFont.Controls.Add(tableLayoutPanel3);
            groupBoxFont.Controls.Add(checkBoxAddFont);
            groupBoxFont.ForeColor = Color.DodgerBlue;
            groupBoxFont.Name = "groupBoxFont";
            groupBoxFont.TabStop = false;
            toolTip1.SetToolTip(groupBoxFont, resources.GetString("groupBoxFont.ToolTip"));
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.AllowDrop = true;
            tableLayoutPanel3.Controls.Add(btnSelectFont, 0, 0);
            tableLayoutPanel3.Controls.Add(lblFontPath, 1, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            toolTip1.SetToolTip(tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            tableLayoutPanel3.DragDrop += lblFontPath_DragDrop;
            tableLayoutPanel3.DragEnter += lblFontPath_DragEnter;
            // 
            // btnSelectFont
            // 
            resources.ApplyResources(btnSelectFont, "btnSelectFont");
            btnSelectFont.ForeColor = SystemColors.ControlText;
            btnSelectFont.Name = "btnSelectFont";
            toolTip1.SetToolTip(btnSelectFont, resources.GetString("btnSelectFont.ToolTip"));
            btnSelectFont.UseVisualStyleBackColor = true;
            btnSelectFont.Click += btnSelectFont_Click;
            // 
            // lblFontPath
            // 
            resources.ApplyResources(lblFontPath, "lblFontPath");
            lblFontPath.AllowDrop = true;
            lblFontPath.ForeColor = Color.Green;
            lblFontPath.Name = "lblFontPath";
            toolTip1.SetToolTip(lblFontPath, resources.GetString("lblFontPath.ToolTip"));
            lblFontPath.DragDrop += lblFontPath_DragDrop;
            lblFontPath.DragEnter += lblFontPath_DragEnter;
            // 
            // checkBoxAddFont
            // 
            resources.ApplyResources(checkBoxAddFont, "checkBoxAddFont");
            checkBoxAddFont.ForeColor = SystemColors.ControlText;
            checkBoxAddFont.Name = "checkBoxAddFont";
            toolTip1.SetToolTip(checkBoxAddFont, resources.GetString("checkBoxAddFont.ToolTip"));
            checkBoxAddFont.UseVisualStyleBackColor = true;
            checkBoxAddFont.CheckedChanged += checkBoxAddFont_CheckedChanged;
            // 
            // tabPageTextMessage
            // 
            resources.ApplyResources(tabPageTextMessage, "tabPageTextMessage");
            tabPageTextMessage.Controls.Add(tbTextMessageText);
            tabPageTextMessage.Name = "tabPageTextMessage";
            toolTip1.SetToolTip(tabPageTextMessage, resources.GetString("tabPageTextMessage.ToolTip"));
            tabPageTextMessage.UseVisualStyleBackColor = true;
            // 
            // tbTextMessageText
            // 
            resources.ApplyResources(tbTextMessageText, "tbTextMessageText");
            tbTextMessageText.Name = "tbTextMessageText";
            toolTip1.SetToolTip(tbTextMessageText, resources.GetString("tbTextMessageText.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.AllowDrop = true;
            label2.Name = "label2";
            toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            label2.DragDrop += lblExcelPath_DragDrop;
            label2.DragEnter += lblExcelPath_DragEnter;
            // 
            // lblExcelPath
            // 
            resources.ApplyResources(lblExcelPath, "lblExcelPath");
            lblExcelPath.AllowDrop = true;
            lblExcelPath.ForeColor = Color.Green;
            lblExcelPath.Name = "lblExcelPath";
            toolTip1.SetToolTip(lblExcelPath, resources.GetString("lblExcelPath.ToolTip"));
            lblExcelPath.DragDrop += lblExcelPath_DragDrop;
            lblExcelPath.DragEnter += lblExcelPath_DragEnter;
            // 
            // btnSelectExcel
            // 
            resources.ApplyResources(btnSelectExcel, "btnSelectExcel");
            btnSelectExcel.AllowDrop = true;
            btnSelectExcel.Name = "btnSelectExcel";
            toolTip1.SetToolTip(btnSelectExcel, resources.GetString("btnSelectExcel.ToolTip"));
            btnSelectExcel.UseVisualStyleBackColor = true;
            btnSelectExcel.Click += btnSelectExcel_Click;
            btnSelectExcel.DragDrop += lblExcelPath_DragDrop;
            btnSelectExcel.DragEnter += lblExcelPath_DragEnter;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            toolTip1.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // comboBoxWaitingTimeSelector
            // 
            resources.ApplyResources(comboBoxWaitingTimeSelector, "comboBoxWaitingTimeSelector");
            comboBoxWaitingTimeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWaitingTimeSelector.FormattingEnabled = true;
            comboBoxWaitingTimeSelector.Items.AddRange(new object[] { resources.GetString("comboBoxWaitingTimeSelector.Items"), resources.GetString("comboBoxWaitingTimeSelector.Items1"), resources.GetString("comboBoxWaitingTimeSelector.Items2"), resources.GetString("comboBoxWaitingTimeSelector.Items3"), resources.GetString("comboBoxWaitingTimeSelector.Items4"), resources.GetString("comboBoxWaitingTimeSelector.Items5") });
            comboBoxWaitingTimeSelector.Name = "comboBoxWaitingTimeSelector";
            toolTip1.SetToolTip(comboBoxWaitingTimeSelector, resources.GetString("comboBoxWaitingTimeSelector.ToolTip"));
            comboBoxWaitingTimeSelector.SelectedIndexChanged += comboBoxWaitingTimeSelector_SelectedIndexChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            toolTip1.SetToolTip(label8, resources.GetString("label8.ToolTip"));
            // 
            // btnClearLog
            // 
            resources.ApplyResources(btnClearLog, "btnClearLog");
            btnClearLog.ForeColor = SystemColors.ControlText;
            btnClearLog.Name = "btnClearLog";
            toolTip1.SetToolTip(btnClearLog, resources.GetString("btnClearLog.ToolTip"));
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // progressBar
            // 
            resources.ApplyResources(progressBar, "progressBar");
            progressBar.Name = "progressBar";
            progressBar.Style = ProgressBarStyle.Continuous;
            toolTip1.SetToolTip(progressBar, resources.GetString("progressBar.ToolTip"));
            // 
            // lblRecommendedSecond
            // 
            resources.ApplyResources(lblRecommendedSecond, "lblRecommendedSecond");
            lblRecommendedSecond.Cursor = Cursors.Hand;
            lblRecommendedSecond.ForeColor = Color.Firebrick;
            lblRecommendedSecond.Name = "lblRecommendedSecond";
            toolTip1.SetToolTip(lblRecommendedSecond, resources.GetString("lblRecommendedSecond.ToolTip"));
            lblRecommendedSecond.Click += lblRecommendedSecond_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.Controls.Add(lblExcelPath, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSelectExcel, 3, 0);
            tableLayoutPanel1.Controls.Add(btnOpenExcelFile, 2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            toolTip1.SetToolTip(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            tableLayoutPanel1.DragDrop += lblExcelPath_DragDrop;
            tableLayoutPanel1.DragEnter += lblExcelPath_DragEnter;
            // 
            // btnOpenExcelFile
            // 
            resources.ApplyResources(btnOpenExcelFile, "btnOpenExcelFile");
            btnOpenExcelFile.Name = "btnOpenExcelFile";
            toolTip1.SetToolTip(btnOpenExcelFile, resources.GetString("btnOpenExcelFile.ToolTip"));
            btnOpenExcelFile.UseVisualStyleBackColor = true;
            btnOpenExcelFile.Click += btnOpenExcelFile_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Microsoft_Excel_2019;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 100;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(btnOpenWhatsappWEB, 0, 0);
            tableLayoutPanel4.Controls.Add(progressBar, 1, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            toolTip1.SetToolTip(tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
            // 
            // FormWapCast
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Controls.Add(pictureBox2);
            Controls.Add(lblRecommendedSecond);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnClearLog);
            Controls.Add(label8);
            Controls.Add(comboBoxWaitingTimeSelector);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Controls.Add(tbLog);
            Controls.Add(btnStart);
            Controls.Add(menuStrip);
            Name = "FormWapCast";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += FormWapCast_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageImageMessage.ResumeLayout(false);
            tabPageImageMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxFont.ResumeLayout(false);
            groupBoxFont.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabPageTextMessage.ResumeLayout(false);
            tabPageTextMessage.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem geliştiriciToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private Button btnStart;
        private Button btnOpenWhatsappWEB;
        private TextBox tbLog;
        private TabControl tabControl1;
        private TabPage tabPageImageMessage;
        private TabPage tabPageTextMessage;
        private Label label2;
        private Label lblExcelPath;
        private Button btnSelectExcel;
        private Button btnSelectImage;
        private Label label5;
        private Label lblImagePath;
        private GroupBox groupBoxFont;
        private CheckBox checkBoxAddFont;
        private Label lblFontPath;
        private Button btnSelectFont;
        private GroupBox groupBox2;
        private TextBox tbImageText;
        private CheckBox checkBoxAddImageText;
        private GroupBox groupBox3;
        private Button btnExportExample;
        private TextBox tbImageMessageText;
        private CheckBox checkBoxAddMessage;
        private TextBox tbTextMessageText;
        private Label label6;
        private ComboBox comboBoxWaitingTimeSelector;
        private Label label8;
        private Button btnClearLog;
        private TextBox tbYKoordinat;
        private TextBox tbXKoordinat;
        private Label label4;
        private TextBox tbFontSize;
        private Label label3;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mustafaTOKTAŞToolStripMenuItem;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem linkedInToolStripMenuItem;
        private ToolStripMenuItem v100ToolStripMenuItem;
        private ProgressBar progressBar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblRecommendedSecond;
        private ToolStripMenuItem licenseToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem gitHubRepositoryToolStripMenuItem;
        private ToolStripMenuItem karanlıkTemaToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnOpenExcelFile;
        private Button btnOpenImageFile;
        private ToolStripMenuItem orjinalFormBoyutuToolStripMenuItem;
        private ToolStripMenuItem kullanımToolStripMenuItem;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
