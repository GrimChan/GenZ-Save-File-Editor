namespace Generation_Zero_Save_File_Modder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weaponSwapQuality = new System.Windows.Forms.NumericUpDown();
            this.weaponQuality = new System.Windows.Forms.PictureBox();
            this.inventoryQuality = new System.Windows.Forms.PictureBox();
            this.inventoryWeaponImage = new System.Windows.Forms.PictureBox();
            this.weaponImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swapButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inventorySwapQuality = new System.Windows.Forms.NumericUpDown();
            this.inventorySwapBox = new System.Windows.Forms.ComboBox();
            this.weaponSwapBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.resetSkills = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSlotTicker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.skillPoints = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFile2 = new System.Windows.Forms.Button();
            this.savePathLabel2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.weaponTab = new System.Windows.Forms.TabPage();
            this.attachmentsTab = new System.Windows.Forms.TabPage();
            this.attachmentCombo = new System.Windows.Forms.ComboBox();
            this.inventoryAttachmentQuality = new System.Windows.Forms.NumericUpDown();
            this.attachmentSwapButton = new System.Windows.Forms.Button();
            this.attachmentQuality = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.inventoryAttachmentCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.skillTab = new System.Windows.Forms.TabPage();
            this.devTab = new System.Windows.Forms.TabPage();
            this.changeInfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.equipmentNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.equipmentAmountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.equipmentHashBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipmentIdBox = new System.Windows.Forms.TextBox();
            this.equipmentSelectorCombo = new System.Windows.Forms.ComboBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.weaponSwapQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWeaponImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySwapQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveSlotTicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPoints)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.weaponTab.SuspendLayout();
            this.attachmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAttachmentQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentQuality)).BeginInit();
            this.skillTab.SuspendLayout();
            this.devTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weaponSwapQuality
            // 
            this.weaponSwapQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponSwapQuality.Location = new System.Drawing.Point(317, 27);
            this.weaponSwapQuality.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.weaponSwapQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weaponSwapQuality.Name = "weaponSwapQuality";
            this.weaponSwapQuality.Size = new System.Drawing.Size(31, 21);
            this.weaponSwapQuality.TabIndex = 0;
            this.weaponSwapQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weaponSwapQuality.ValueChanged += new System.EventHandler(this.weaponSwapQuality_ValueChanged);
            // 
            // weaponQuality
            // 
            this.weaponQuality.Image = ((System.Drawing.Image)(resources.GetObject("weaponQuality.Image")));
            this.weaponQuality.Location = new System.Drawing.Point(136, 55);
            this.weaponQuality.Name = "weaponQuality";
            this.weaponQuality.Size = new System.Drawing.Size(99, 42);
            this.weaponQuality.TabIndex = 10;
            this.weaponQuality.TabStop = false;
            // 
            // inventoryQuality
            // 
            this.inventoryQuality.Image = ((System.Drawing.Image)(resources.GetObject("inventoryQuality.Image")));
            this.inventoryQuality.Location = new System.Drawing.Point(136, 156);
            this.inventoryQuality.Name = "inventoryQuality";
            this.inventoryQuality.Size = new System.Drawing.Size(99, 42);
            this.inventoryQuality.TabIndex = 9;
            this.inventoryQuality.TabStop = false;
            // 
            // inventoryWeaponImage
            // 
            this.inventoryWeaponImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inventoryWeaponImage.Location = new System.Drawing.Point(16, 156);
            this.inventoryWeaponImage.Name = "inventoryWeaponImage";
            this.inventoryWeaponImage.Size = new System.Drawing.Size(125, 42);
            this.inventoryWeaponImage.TabIndex = 7;
            this.inventoryWeaponImage.TabStop = false;
            // 
            // weaponImage
            // 
            this.weaponImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.weaponImage.Location = new System.Drawing.Point(16, 55);
            this.weaponImage.Name = "weaponImage";
            this.weaponImage.Size = new System.Drawing.Size(125, 42);
            this.weaponImage.TabIndex = 6;
            this.weaponImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weapon To Replace";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(241, 156);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(107, 42);
            this.swapButton.TabIndex = 3;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weapon To Get";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventorySwapQuality
            // 
            this.inventorySwapQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorySwapQuality.Location = new System.Drawing.Point(317, 128);
            this.inventorySwapQuality.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.inventorySwapQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventorySwapQuality.Name = "inventorySwapQuality";
            this.inventorySwapQuality.Size = new System.Drawing.Size(31, 21);
            this.inventorySwapQuality.TabIndex = 3;
            this.inventorySwapQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventorySwapQuality.ValueChanged += new System.EventHandler(this.inventorySwapQuality_ValueChanged);
            // 
            // inventorySwapBox
            // 
            this.inventorySwapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inventorySwapBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorySwapBox.FormattingEnabled = true;
            this.inventorySwapBox.Location = new System.Drawing.Point(16, 127);
            this.inventorySwapBox.Name = "inventorySwapBox";
            this.inventorySwapBox.Size = new System.Drawing.Size(295, 24);
            this.inventorySwapBox.TabIndex = 2;
            this.inventorySwapBox.SelectedIndexChanged += new System.EventHandler(this.inventorySwapBox_SelectedIndexChanged);
            // 
            // weaponSwapBox
            // 
            this.weaponSwapBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.weaponSwapBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.weaponSwapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponSwapBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponSwapBox.FormattingEnabled = true;
            this.weaponSwapBox.Location = new System.Drawing.Point(16, 26);
            this.weaponSwapBox.MaxDropDownItems = 18;
            this.weaponSwapBox.Name = "weaponSwapBox";
            this.weaponSwapBox.Size = new System.Drawing.Size(295, 24);
            this.weaponSwapBox.TabIndex = 1;
            this.weaponSwapBox.SelectedIndexChanged += new System.EventHandler(this.weaponSwapBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(6, 19);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(108, 29);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Open Save";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathLabel.Location = new System.Drawing.Point(120, 26);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(81, 14);
            this.savePathLabel.TabIndex = 5;
            this.savePathLabel.Text = "Save File Path: ";
            this.savePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resetSkills
            // 
            this.resetSkills.Location = new System.Drawing.Point(75, 159);
            this.resetSkills.Name = "resetSkills";
            this.resetSkills.Size = new System.Drawing.Size(206, 30);
            this.resetSkills.TabIndex = 11;
            this.resetSkills.Text = "Reset Skills";
            this.resetSkills.UseVisualStyleBackColor = true;
            this.resetSkills.Click += new System.EventHandler(this.resetSkills_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Save Slot: ";
            // 
            // saveSlotTicker
            // 
            this.saveSlotTicker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSlotTicker.Location = new System.Drawing.Point(239, 66);
            this.saveSlotTicker.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.saveSlotTicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.saveSlotTicker.Name = "saveSlotTicker";
            this.saveSlotTicker.Size = new System.Drawing.Size(42, 22);
            this.saveSlotTicker.TabIndex = 12;
            this.saveSlotTicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Skill Points:";
            // 
            // skillPoints
            // 
            this.skillPoints.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillPoints.Location = new System.Drawing.Point(222, 94);
            this.skillPoints.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.skillPoints.Name = "skillPoints";
            this.skillPoints.Size = new System.Drawing.Size(59, 22);
            this.skillPoints.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openFile2);
            this.groupBox3.Controls.Add(this.savePathLabel2);
            this.groupBox3.Controls.Add(this.openFile);
            this.groupBox3.Controls.Add(this.savePathLabel);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 92);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saves";
            // 
            // openFile2
            // 
            this.openFile2.Location = new System.Drawing.Point(6, 54);
            this.openFile2.Name = "openFile2";
            this.openFile2.Size = new System.Drawing.Size(108, 29);
            this.openFile2.TabIndex = 6;
            this.openFile2.Text = "Open Save Txt";
            this.openFile2.UseVisualStyleBackColor = true;
            this.openFile2.Click += new System.EventHandler(this.openFile2_Click);
            // 
            // savePathLabel2
            // 
            this.savePathLabel2.AutoSize = true;
            this.savePathLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathLabel2.Location = new System.Drawing.Point(120, 61);
            this.savePathLabel2.Name = "savePathLabel2";
            this.savePathLabel2.Size = new System.Drawing.Size(71, 14);
            this.savePathLabel2.TabIndex = 7;
            this.savePathLabel2.Text = "Txt File Path: ";
            this.savePathLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.weaponTab);
            this.tabControl1.Controls.Add(this.attachmentsTab);
            this.tabControl1.Controls.Add(this.skillTab);
            this.tabControl1.Controls.Add(this.devTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 246);
            this.tabControl1.TabIndex = 18;
            // 
            // weaponTab
            // 
            this.weaponTab.Controls.Add(this.weaponSwapBox);
            this.weaponTab.Controls.Add(this.inventoryWeaponImage);
            this.weaponTab.Controls.Add(this.inventorySwapQuality);
            this.weaponTab.Controls.Add(this.swapButton);
            this.weaponTab.Controls.Add(this.weaponSwapQuality);
            this.weaponTab.Controls.Add(this.weaponQuality);
            this.weaponTab.Controls.Add(this.inventoryQuality);
            this.weaponTab.Controls.Add(this.weaponImage);
            this.weaponTab.Controls.Add(this.label1);
            this.weaponTab.Controls.Add(this.inventorySwapBox);
            this.weaponTab.Controls.Add(this.label2);
            this.weaponTab.Location = new System.Drawing.Point(4, 23);
            this.weaponTab.Name = "weaponTab";
            this.weaponTab.Padding = new System.Windows.Forms.Padding(3);
            this.weaponTab.Size = new System.Drawing.Size(363, 219);
            this.weaponTab.TabIndex = 0;
            this.weaponTab.Text = "Weapon Swap";
            this.weaponTab.UseVisualStyleBackColor = true;
            // 
            // attachmentsTab
            // 
            this.attachmentsTab.Controls.Add(this.attachmentCombo);
            this.attachmentsTab.Controls.Add(this.inventoryAttachmentQuality);
            this.attachmentsTab.Controls.Add(this.attachmentSwapButton);
            this.attachmentsTab.Controls.Add(this.attachmentQuality);
            this.attachmentsTab.Controls.Add(this.label7);
            this.attachmentsTab.Controls.Add(this.inventoryAttachmentCombo);
            this.attachmentsTab.Controls.Add(this.label8);
            this.attachmentsTab.Location = new System.Drawing.Point(4, 23);
            this.attachmentsTab.Name = "attachmentsTab";
            this.attachmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.attachmentsTab.Size = new System.Drawing.Size(363, 219);
            this.attachmentsTab.TabIndex = 1;
            this.attachmentsTab.Text = "Attachment Swap";
            this.attachmentsTab.UseVisualStyleBackColor = true;
            // 
            // attachmentCombo
            // 
            this.attachmentCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.attachmentCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.attachmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attachmentCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentCombo.FormattingEnabled = true;
            this.attachmentCombo.Location = new System.Drawing.Point(3, 31);
            this.attachmentCombo.MaxDropDownItems = 100;
            this.attachmentCombo.Name = "attachmentCombo";
            this.attachmentCombo.Size = new System.Drawing.Size(317, 24);
            this.attachmentCombo.TabIndex = 12;
            this.attachmentCombo.SelectedIndexChanged += new System.EventHandler(this.attachmentCombo_SelectedIndexChanged);
            // 
            // inventoryAttachmentQuality
            // 
            this.inventoryAttachmentQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAttachmentQuality.Location = new System.Drawing.Point(326, 80);
            this.inventoryAttachmentQuality.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.inventoryAttachmentQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventoryAttachmentQuality.Name = "inventoryAttachmentQuality";
            this.inventoryAttachmentQuality.Size = new System.Drawing.Size(31, 21);
            this.inventoryAttachmentQuality.TabIndex = 14;
            this.inventoryAttachmentQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventoryAttachmentQuality.ValueChanged += new System.EventHandler(this.inventoryAttachmentQuality_ValueChanged);
            // 
            // attachmentSwapButton
            // 
            this.attachmentSwapButton.Location = new System.Drawing.Point(119, 122);
            this.attachmentSwapButton.Name = "attachmentSwapButton";
            this.attachmentSwapButton.Size = new System.Drawing.Size(107, 42);
            this.attachmentSwapButton.TabIndex = 15;
            this.attachmentSwapButton.Text = "Swap";
            this.attachmentSwapButton.UseVisualStyleBackColor = true;
            this.attachmentSwapButton.Click += new System.EventHandler(this.attachmentSwapButton_Click);
            // 
            // attachmentQuality
            // 
            this.attachmentQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentQuality.Location = new System.Drawing.Point(326, 32);
            this.attachmentQuality.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.attachmentQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attachmentQuality.Name = "attachmentQuality";
            this.attachmentQuality.Size = new System.Drawing.Size(31, 21);
            this.attachmentQuality.TabIndex = 11;
            this.attachmentQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attachmentQuality.ValueChanged += new System.EventHandler(this.attachmentQuality_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Attachment To Get";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventoryAttachmentCombo
            // 
            this.inventoryAttachmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inventoryAttachmentCombo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAttachmentCombo.FormattingEnabled = true;
            this.inventoryAttachmentCombo.Location = new System.Drawing.Point(3, 79);
            this.inventoryAttachmentCombo.MaxDropDownItems = 100;
            this.inventoryAttachmentCombo.Name = "inventoryAttachmentCombo";
            this.inventoryAttachmentCombo.Size = new System.Drawing.Size(317, 24);
            this.inventoryAttachmentCombo.TabIndex = 13;
            this.inventoryAttachmentCombo.SelectedIndexChanged += new System.EventHandler(this.inventoryAttachmentCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Attachment To Replace";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skillTab
            // 
            this.skillTab.Controls.Add(this.resetSkills);
            this.skillTab.Controls.Add(this.label4);
            this.skillTab.Controls.Add(this.skillPoints);
            this.skillTab.Controls.Add(this.label3);
            this.skillTab.Controls.Add(this.saveSlotTicker);
            this.skillTab.Location = new System.Drawing.Point(4, 23);
            this.skillTab.Name = "skillTab";
            this.skillTab.Size = new System.Drawing.Size(363, 219);
            this.skillTab.TabIndex = 2;
            this.skillTab.Text = "Skill Resetting";
            this.skillTab.UseVisualStyleBackColor = true;
            // 
            // devTab
            // 
            this.devTab.Controls.Add(this.changeInfo);
            this.devTab.Controls.Add(this.label11);
            this.devTab.Controls.Add(this.groupBox1);
            this.devTab.Controls.Add(this.equipmentSelectorCombo);
            this.devTab.Location = new System.Drawing.Point(4, 23);
            this.devTab.Name = "devTab";
            this.devTab.Size = new System.Drawing.Size(363, 219);
            this.devTab.TabIndex = 3;
            this.devTab.Text = "Dev";
            this.devTab.UseVisualStyleBackColor = true;
            // 
            // changeInfo
            // 
            this.changeInfo.Location = new System.Drawing.Point(3, 188);
            this.changeInfo.Name = "changeInfo";
            this.changeInfo.Size = new System.Drawing.Size(356, 24);
            this.changeInfo.TabIndex = 3;
            this.changeInfo.Text = "Change Info";
            this.changeInfo.UseVisualStyleBackColor = true;
            this.changeInfo.Click += new System.EventHandler(this.changeInfo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Item Selector:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.equipmentNameBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.equipmentAmountBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.equipmentHashBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.equipmentIdBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Item Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipmentNameBox
            // 
            this.equipmentNameBox.Enabled = false;
            this.equipmentNameBox.Location = new System.Drawing.Point(6, 112);
            this.equipmentNameBox.Name = "equipmentNameBox";
            this.equipmentNameBox.Size = new System.Drawing.Size(345, 20);
            this.equipmentNameBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Amount:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipmentAmountBox
            // 
            this.equipmentAmountBox.Location = new System.Drawing.Point(66, 72);
            this.equipmentAmountBox.Name = "equipmentAmountBox";
            this.equipmentAmountBox.Size = new System.Drawing.Size(285, 20);
            this.equipmentAmountBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Equipment Hash:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipmentHashBox
            // 
            this.equipmentHashBox.Enabled = false;
            this.equipmentHashBox.Location = new System.Drawing.Point(113, 46);
            this.equipmentHashBox.Name = "equipmentHashBox";
            this.equipmentHashBox.Size = new System.Drawing.Size(238, 20);
            this.equipmentHashBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipmentIdBox
            // 
            this.equipmentIdBox.Enabled = false;
            this.equipmentIdBox.Location = new System.Drawing.Point(33, 19);
            this.equipmentIdBox.Name = "equipmentIdBox";
            this.equipmentIdBox.Size = new System.Drawing.Size(318, 20);
            this.equipmentIdBox.TabIndex = 0;
            // 
            // equipmentSelectorCombo
            // 
            this.equipmentSelectorCombo.FormattingEnabled = true;
            this.equipmentSelectorCombo.Location = new System.Drawing.Point(2, 22);
            this.equipmentSelectorCombo.Name = "equipmentSelectorCombo";
            this.equipmentSelectorCombo.Size = new System.Drawing.Size(357, 22);
            this.equipmentSelectorCombo.TabIndex = 0;
            this.equipmentSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.equipmentSelectorCombo_SelectedIndexChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grim\'s Gen Z Modding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weaponSwapQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWeaponImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySwapQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveSlotTicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPoints)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.weaponTab.ResumeLayout(false);
            this.weaponTab.PerformLayout();
            this.attachmentsTab.ResumeLayout(false);
            this.attachmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAttachmentQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentQuality)).EndInit();
            this.skillTab.ResumeLayout(false);
            this.skillTab.PerformLayout();
            this.devTab.ResumeLayout(false);
            this.devTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown weaponSwapQuality;
        private System.Windows.Forms.ComboBox weaponSwapBox;
        private System.Windows.Forms.NumericUpDown inventorySwapQuality;
        private System.Windows.Forms.ComboBox inventorySwapBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.PictureBox inventoryWeaponImage;
        private System.Windows.Forms.PictureBox weaponImage;
        private System.Windows.Forms.PictureBox weaponQuality;
        private System.Windows.Forms.PictureBox inventoryQuality;
        private System.Windows.Forms.Button resetSkills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown saveSlotTicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown skillPoints;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage weaponTab;
        private System.Windows.Forms.TabPage attachmentsTab;
        private System.Windows.Forms.ComboBox attachmentCombo;
        private System.Windows.Forms.NumericUpDown inventoryAttachmentQuality;
        private System.Windows.Forms.Button attachmentSwapButton;
        private System.Windows.Forms.NumericUpDown attachmentQuality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox inventoryAttachmentCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openFile2;
        private System.Windows.Forms.Label savePathLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TabPage skillTab;
        private System.Windows.Forms.TabPage devTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox equipmentAmountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox equipmentHashBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox equipmentIdBox;
        private System.Windows.Forms.ComboBox equipmentSelectorCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox equipmentNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeInfo;
    }
}

