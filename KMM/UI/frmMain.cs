using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KMM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            // New mod dialogue
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
    }
}
