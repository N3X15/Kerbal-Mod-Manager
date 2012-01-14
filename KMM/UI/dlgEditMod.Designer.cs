namespace KMM.UI
{
    partial class dlgEditMod
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.lblModAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblKSPVersion = new System.Windows.Forms.Label();
            this.txtKSPVersion = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblThread = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mod Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Edit Mod";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(104, 39);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(174, 20);
            this.txtModName.TabIndex = 2;
            // 
            // lblModAuthor
            // 
            this.lblModAuthor.AutoSize = true;
            this.lblModAuthor.Location = new System.Drawing.Point(62, 94);
            this.lblModAuthor.Name = "lblModAuthor";
            this.lblModAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblModAuthor.TabIndex = 3;
            this.lblModAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(104, 91);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(174, 20);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblKSPVersion
            // 
            this.lblKSPVersion.AutoSize = true;
            this.lblKSPVersion.Location = new System.Drawing.Point(32, 121);
            this.lblKSPVersion.Name = "lblKSPVersion";
            this.lblKSPVersion.Size = new System.Drawing.Size(69, 13);
            this.lblKSPVersion.TabIndex = 5;
            this.lblKSPVersion.Text = "KSP Version:";
            // 
            // txtKSPVersion
            // 
            this.txtKSPVersion.Location = new System.Drawing.Point(104, 118);
            this.txtKSPVersion.Name = "txtKSPVersion";
            this.txtKSPVersion.Size = new System.Drawing.Size(174, 20);
            this.txtKSPVersion.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(38, 148);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 145);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 89);
            this.txtDescription.TabIndex = 8;
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(57, 243);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(44, 13);
            this.lblThread.TabIndex = 11;
            this.lblThread.Text = "Thread:";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(104, 240);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(174, 20);
            this.txtThread.TabIndex = 12;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(122, 266);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 13;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(203, 266);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 14;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(29, 68);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Mod Version:";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(104, 65);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(174, 20);
            this.txtVersion.TabIndex = 16;
            // 
            // dlgEditMod
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(292, 293);
            this.ControlBox = false;
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtThread);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtKSPVersion);
            this.Controls.Add(this.lblKSPVersion);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblModAuthor);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dlgEditMod";
            this.Text = "Edit Mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label lblModAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblKSPVersion;
        private System.Windows.Forms.TextBox txtKSPVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
    }
}