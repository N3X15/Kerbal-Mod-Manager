namespace KMM
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
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewModComponentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCraft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnectRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdNewMod = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvModList = new System.Windows.Forms.DataGridView();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRating = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmBlurb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previewPanel = new System.Windows.Forms.WebBrowser();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(182, 22);
            this.mnuExit.Text = "E&xit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuNewMod
            // 
            this.mnuNewMod.Name = "mnuNewMod";
            this.mnuNewMod.Size = new System.Drawing.Size(182, 22);
            this.mnuNewMod.Text = "New Mod...";
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
            this.mnuNewPart.Size = new System.Drawing.Size(152, 22);
            this.mnuNewPart.Text = "Part...";
            // 
            // mnuNewCraft
            // 
            this.mnuNewCraft.Name = "mnuNewCraft";
            this.mnuNewCraft.Size = new System.Drawing.Size(152, 22);
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
            this.mnuConnectRepo,
            this.mnuDisconnect});
            this.mnuRepos.Name = "mnuRepos";
            this.mnuRepos.Size = new System.Drawing.Size(75, 20);
            this.mnuRepos.Text = "&Repository";
            // 
            // mnuConnectRepo
            // 
            this.mnuConnectRepo.Name = "mnuConnectRepo";
            this.mnuConnectRepo.Size = new System.Drawing.Size(171, 22);
            this.mnuConnectRepo.Text = "Connect...";
            // 
            // mnuDisconnect
            // 
            this.mnuDisconnect.Name = "mnuDisconnect";
            this.mnuDisconnect.Size = new System.Drawing.Size(171, 22);
            this.mnuDisconnect.Text = "Disconnect from...";
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
            this.mnuAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuAbout.Text = "About KMM...";
            // 
            // mnuGithub
            // 
            this.mnuGithub.Name = "mnuGithub";
            this.mnuGithub.Size = new System.Drawing.Size(152, 22);
            this.mnuGithub.Text = "Github...";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewMod});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdNewMod
            // 
            this.cmdNewMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNewMod.Image = ((System.Drawing.Image)(resources.GetObject("cmdNewMod.Image")));
            this.cmdNewMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNewMod.Name = "cmdNewMod";
            this.cmdNewMod.Size = new System.Drawing.Size(23, 22);
            this.cmdNewMod.Text = "New Mod";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.previewPanel);
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
            this.clmSelect,
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
            // clmSelect
            // 
            this.clmSelect.HeaderText = "Install";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.ReadOnly = true;
            this.clmSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.clmBlurb.HeaderText = "Description";
            this.clmBlurb.Name = "clmBlurb";
            this.clmBlurb.ReadOnly = true;
            // 
            // previewPanel
            // 
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(0, 0);
            this.previewPanel.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(193, 296);
            this.previewPanel.TabIndex = 0;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuCheckForUpdates
            // 
            this.mnuCheckForUpdates.Name = "mnuCheckForUpdates";
            this.mnuCheckForUpdates.Size = new System.Drawing.Size(182, 22);
            this.mnuCheckForUpdates.Text = "Check For Updates...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 367);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "KMM ALPHABUGS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem mnuConnectRepo;
        private System.Windows.Forms.ToolStripMenuItem mnuDisconnect;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuGithub;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdNewMod;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser previewPanel;
        private System.Windows.Forms.DataGridView dgvModList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
        private System.Windows.Forms.DataGridViewLinkColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAuthor;
        private System.Windows.Forms.DataGridViewImageColumn clmRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBlurb;
    }
}

