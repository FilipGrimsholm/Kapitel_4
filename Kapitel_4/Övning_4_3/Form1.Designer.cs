namespace Övning_4_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxTelefonummer = new System.Windows.Forms.TextBox();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.lbxKontakter = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaTsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTsmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggtillTsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabortTsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefonnummer";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(128, 35);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFörnamn.TabIndex = 4;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(128, 58);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 20);
            this.tbxEfternamn.TabIndex = 5;
            // 
            // tbxTelefonummer
            // 
            this.tbxTelefonummer.Location = new System.Drawing.Point(128, 106);
            this.tbxTelefonummer.Name = "tbxTelefonummer";
            this.tbxTelefonummer.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefonummer.TabIndex = 6;
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(128, 81);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(100, 20);
            this.tbxEpost.TabIndex = 8;
            // 
            // lbxKontakter
            // 
            this.lbxKontakter.FormattingEnabled = true;
            this.lbxKontakter.Location = new System.Drawing.Point(234, 35);
            this.lbxKontakter.Name = "lbxKontakter";
            this.lbxKontakter.Size = new System.Drawing.Size(197, 95);
            this.lbxKontakter.TabIndex = 9;
            this.lbxKontakter.SelectedIndexChanged += new System.EventHandler(this.lbxKontakter_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaTsMnu,
            this.saveTsMnu,
            this.saveAsTsmnu});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // öppnaTsMnu
            // 
            this.öppnaTsMnu.Name = "öppnaTsMnu";
            this.öppnaTsMnu.Size = new System.Drawing.Size(112, 22);
            this.öppnaTsMnu.Text = "Öppna";
            this.öppnaTsMnu.Click += new System.EventHandler(this.ÖppnaTsMnu_Click);
            // 
            // saveTsMnu
            // 
            this.saveTsMnu.Name = "saveTsMnu";
            this.saveTsMnu.Size = new System.Drawing.Size(112, 22);
            this.saveTsMnu.Text = "Save";
            this.saveTsMnu.Click += new System.EventHandler(this.SaveTsMnu_Click);
            // 
            // saveAsTsmnu
            // 
            this.saveAsTsmnu.Name = "saveAsTsmnu";
            this.saveAsTsmnu.Size = new System.Drawing.Size(112, 22);
            this.saveAsTsmnu.Text = "Save as";
            this.saveAsTsmnu.Click += new System.EventHandler(this.SaveAsTsmnu_Click);
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggtillTsMnu,
            this.tabortTsMnu});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // läggtillTsMnu
            // 
            this.läggtillTsMnu.Name = "läggtillTsMnu";
            this.läggtillTsMnu.Size = new System.Drawing.Size(116, 22);
            this.läggtillTsMnu.Text = "Lägg till";
            this.läggtillTsMnu.Click += new System.EventHandler(this.LäggtillTsMnu_Click);
            // 
            // tabortTsMnu
            // 
            this.tabortTsMnu.Name = "tabortTsMnu";
            this.tabortTsMnu.Size = new System.Drawing.Size(116, 22);
            this.tabortTsMnu.Text = "Ta bort";
            this.tabortTsMnu.Click += new System.EventHandler(this.TabortTsMnu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 166);
            this.Controls.Add(this.lbxKontakter);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.tbxTelefonummer);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxTelefonummer;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.ListBox lbxKontakter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaTsMnu;
        private System.Windows.Forms.ToolStripMenuItem saveTsMnu;
        private System.Windows.Forms.ToolStripMenuItem saveAsTsmnu;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggtillTsMnu;
        private System.Windows.Forms.ToolStripMenuItem tabortTsMnu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

