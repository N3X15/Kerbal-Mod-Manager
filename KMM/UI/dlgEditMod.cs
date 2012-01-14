using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KMM.Repositories;

namespace KMM.UI
{
    public partial class dlgEditMod : Form
    {
        public Mod Mod
        {
            get { return mod; }
        }
        private Mod mod;
        public dlgEditMod(Mod mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            mod = new Mod();
            mod.Author = txtAuthor.Text.Trim();
            mod.Description = txtDescription.Text.Trim().Replace("\n", "");
            mod.Installed = true;
            mod.KSPVersion = new VersionMatcher(txtKSPVersion.Text.Trim());
            mod.Name = txtModName.Text.Trim();
            mod.Thread = txtThread.Text.Trim();
            mod.URL = "";
            mod.Version = txtVersion.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
