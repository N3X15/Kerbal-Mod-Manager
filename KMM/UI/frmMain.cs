using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KMM.Repositories;
using System.Xml;
using System.IO;

namespace KMM.UI
{
    public partial class frmMain : Form
    {
        private LocalRepository myRepo;
        private Dictionary<String, RemoteRepository> repositories = new Dictionary<string, RemoteRepository>();
        private Dictionary<string, int> modMap = new Dictionary<string, int>();
        private Dictionary<string, Mod> oldMods = new Dictionary<string, Mod>();
        public frmMain()
        {
            InitializeComponent();
            // Load repo list
            myRepo = new LocalRepository();
            loadRepos();
            
            // Load installed mods
            refreshAll();

            // Check for updates
        }

        private void refreshAll()
        {
            dgvModList.Rows.Clear();
            modMap.Clear();
            oldMods.Clear();
            myRepo.refresh();
            foreach (Mod mod in myRepo.getMods())
            {
                if (!modMap.ContainsKey(mod.Name))
                {
                    int rowID = dgvModList.Rows.Add(mod);
                    modMap.Add(mod.Name, rowID);
                }
            }
            foreach (RemoteRepository repo in repositories.Values)
            {
                repo.refresh();
                foreach (Mod mod in repo.getMods())
                {
                    if (modMap.ContainsKey(mod.Name))
                    {
                        int rowID = modMap[mod.Name];
                        Mod oldmod = (Mod)dgvModList.Rows[rowID];
                        dgvModList.Rows.RemoveAt(rowID);
                        rowID = dgvModList.Rows.Add(mod);
                        oldMods.Add(mod.Name, oldmod);
                        modMap.Add(mod.Name, rowID);
                    } else {
                        int rowID = dgvModList.Rows.Add(mod);
                        modMap.Add(mod.Name, rowID);
                    }
                }
            }
        }

        private void loadRepos()
        {
            if (File.Exists(".repos"))
            {
                repositories.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load(".repos");
                foreach(XmlNode node in doc.ChildNodes) {
                    if (node.NodeType == XmlNodeType.Element)
                    {
                        switch (node.Name)
                        {
                            case "repo":
                                RemoteRepository repo = null;
                                if (RemoteRepository.canHandle(node))
                                {
                                    repo = new RemoteRepository(node);
                                }
                                if (repo != null && !repositories.ContainsKey(repo.URL))
                                {
                                    repositories.Add(repo.URL, repo);
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doNewMod();
        }

        private void doNewMod()
        {
            // New mod dialogue
            dlgEditMod editMod = new dlgEditMod(null);
            if (editMod.ShowDialog() == DialogResult.OK)
            {
                myRepo.AddMod(editMod.Mod);
                myRepo.Save();
                this.refreshAll();
            }
            // Create new mod
            // Add to cache
        }

        /// <summary>
        /// Export Repository clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExport_Click(object sender, EventArgs e)
        {
            // Requires: Selected mods
            // Ask user where to save repo folder
            // Export mods as repo
            // Copy files
        }

        private void mnuNewMod_Click(object sender, EventArgs e)
        {
            doNewMod();
        }
    }
}
