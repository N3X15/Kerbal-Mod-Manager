namespace KMM.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewMod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewModComponentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCraft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageRepos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvModList = new System.Windows.Forms.DataGridView();
            this.lblSearchOptions = new System.Windows.Forms.Label();
            this.cmbRepo = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRepo = new System.Windows.Forms.Label();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.clmName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRating = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmBlurb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbNewMod = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMods,
            this.mnuRepos,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCheckForUpdates,
            this.toolStripSeparator3,
            this.mnuNewMod,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuCheckForUpdates
            // 
            this.mnuCheckForUpdates.Name = "mnuCheckForUpdates";
            this.mnuCheckForUpdates.Size = new System.Drawing.Size(182, 22);
            this.mnuCheckForUpdates.Text = "Check For Updates...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuNewMod
            // 
            this.mnuNewMod.Name = "mnuNewMod";
            this.mnuNewMod.Size = new System.Drawing.Size(182, 22);
            this.mnuNewMod.Text = "New Mod...";
            this.mnuNewMod.Click += new System.EventHandler(this.mnuNewMod_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(182, 22);
            this.mnuExit.Text = "E&xit";
            // 
            // mnuMods
            // 
            this.mnuMods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModProperties,
            this.toolStripSeparator2,
            this.mnuNewModComponentMenu,
            this.mnuImportMod});
            this.mnuMods.Name = "mnuMods";
            this.mnuMods.Size = new System.Drawing.Size(49, 20);
            this.mnuMods.Text = "&Mods";
            // 
            // mnuModProperties
            // 
            this.mnuModProperties.Name = "mnuModProperties";
            this.mnuModProperties.Size = new System.Drawing.Size(183, 22);
            this.mnuModProperties.Text = "Properties...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuNewModComponentMenu
            // 
            this.mnuNewModComponentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPart,
            this.mnuNewCraft});
            this.mnuNewModComponentMenu.Name = "mnuNewModComponentMenu";
            this.mnuNewModComponentMenu.Size = new System.Drawing.Size(183, 22);
            this.mnuNewModComponentMenu.Text = "New...";
            // 
            // mnuNewPart
            // 
            this.mnuNewPart.Name = "mnuNewPart";
            this.mnuNewPart.Size = new System.Drawing.Size(109, 22);
            this.mnuNewPart.Text = "Part...";
            // 
            // mnuNewCraft
            // 
            this.mnuNewCraft.Name = "mnuNewCraft";
            this.mnuNewCraft.Size = new System.Drawing.Size(109, 22);
            this.mnuNewCraft.Text = "Craft...";
            // 
            // mnuImportMod
            // 
            this.mnuImportMod.Name = "mnuImportMod";
            this.mnuImportMod.Size = new System.Drawing.Size(183, 22);
            this.mnuImportMod.Text = "Import Mod Folder...";
            // 
            // mnuRepos
            // 
            this.mnuRepos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageRepos});
            this.mnuRepos.Name = "mnuRepos";
            this.mnuRepos.Size = new System.Drawing.Size(75, 20);
            this.mnuRepos.Text = "&Repository";
            // 
            // mnuManageRepos
            // 
            this.mnuManageRepos.Name = "mnuManageRepos";
            this.mnuManageRepos.Size = new System.Drawing.Size(126, 22);
            this.mnuManageRepos.Text = "Manage...";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuGithub});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(148, 22);
            this.mnuAbout.Text = "About KMM...";
            // 
            // mnuGithub
            // 
            this.mnuGithub.Name = "mnuGithub";
            this.mnuGithub.Size = new System.Drawing.Size(148, 22);
            this.mnuGithub.Text = "GitHub...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 17);
            this.status.Text = "toolStripStatusLabel1";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewMod,
            this.tsbExport,
            this.toolStripSeparator4,
            this.tsbHelp});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(694, 25);
            this.tsMain.TabIndex = 2;
            this.tsMain.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtModName);
            this.splitContainer1.Panel1.Controls.Add(this.lblModName);
            this.splitContainer1.Panel1.Controls.Add(this.lblAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.cmbAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepo);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel1.Controls.Add(this.cmbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.cmbRepo);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearchOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvModList);
            this.splitContainer1.Size = new System.Drawing.Size(694, 296);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvModList
            // 
            this.dgvModList.AllowUserToAddRows = false;
            this.dgvModList.AllowUserToDeleteRows = false;
            this.dgvModList.AllowUserToOrderColumns = true;
            this.dgvModList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmAuthor,
            this.clmRating,
            this.clmBlurb});
            this.dgvModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModList.Location = new System.Drawing.Point(0, 0);
            this.dgvModList.MultiSelect = false;
            this.dgvModList.Name = "dgvModList";
            this.dgvModList.ReadOnly = true;
            this.dgvModList.RowHeadersVisible = false;
            this.dgvModList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModList.ShowEditingIcon = false;
            this.dgvModList.Size = new System.Drawing.Size(497, 296);
            this.dgvModList.TabIndex = 0;
            // 
            // lblSearchOptions
            // 
            this.lblSearchOptions.AutoSize = true;
            this.lblSearchOptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOptions.Location = new System.Drawing.Point(4, 13);
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.Size = new System.Drawing.Size(116, 19);
            this.lblSearchOptions.TabIndex = 0;
            this.lblSearchOptions.Text = "Power Search";
            this.lblSearchOptions.UseMnemonic = false;
            // 
            // cmbRepo
            // 
            this.cmbRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepo.FormattingEnabled = true;
            this.cmbRepo.Location = new System.Drawing.Point(12, 104);
            this.cmbRepo.Name = "cmbRepo";
            this.cmbRepo.Size = new System.Drawing.Size(160, 21);
            this.cmbRepo.TabIndex = 1;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "-",
            "Installed",
            "Not Installed"});
            this.cmbStatus.Location = new System.Drawing.Point(12, 52);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 21);
            this.cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "State:";
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(12, 85);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(60, 13);
            this.lblRepo.TabIndex = 4;
            this.lblRepo.Text = "Repository:";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(12, 156);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(160, 21);
            this.cmbAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 137);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(12, 189);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(106, 13);
            this.lblModName.TabIndex = 7;
            this.lblModName.Text = "Mod Name Contains:";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(12, 205);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(160, 20);
            this.txtModName.TabIndex = 8;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmAuthor
            // 
            this.clmAuthor.HeaderText = "Author";
            this.clmAuthor.Name = "clmAuthor";
            this.clmAuthor.ReadOnly = true;
            // 
            // clmRating
            // 
            this.clmRating.HeaderText = "Rating";
            this.clmRating.Name = "clmRating";
            this.clmRating.ReadOnly = true;
            // 
            // clmBlurb
            // 
            this.clmBlurb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmBlurb.HeaderText = "Description";
            this.clmBlurb.Name = "clmBlurb";
            this.clmBlurb.ReadOnly = true;
            // 
            // tsbNewMod
            // 
            this.tsbNewMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewMod.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewMod.Image")));
            this.tsbNewMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewMod.Name = "tsbNewMod";
            this.tsbNewMod.Size = new System.Drawing.Size(23, 22);
            this.tsbNewMod.Text = "&New Mod";
            this.tsbNewMod.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "&Export Repository";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbHelp.Text = "He&lp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 367);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "KMM ALPHABUGS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewMod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMods;
        private System.Windows.Forms.ToolStripMenuItem mnuModProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuNewModComponentMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPart;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCraft;
        private System.Windows.Forms.ToolStripMenuItem mnuImportMod;
        private System.Windows.Forms.ToolStripMenuItem mnuRepos;
        private System.Windows.Forms.ToolStripMenuItem mnuManageRepos;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuGithub;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvModList;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label lblRepo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbRepo;
        private System.Windows.Forms.Label lblSearchOptions;
        private System.Windows.Forms.DataGridViewLinkColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAuthor;
        private System.Windows.Forms.DataGridViewImageColumn clmRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBlurb;
        private System.Windows.Forms.ToolStripButton tsbNewMod;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbHelp;
    }
}

