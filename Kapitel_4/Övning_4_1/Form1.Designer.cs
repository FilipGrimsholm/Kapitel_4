﻿namespace Övning_4_1
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
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.ArkivToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolstripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnErsätt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArkivToolstripMnuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(800, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // ArkivToolstripMnuItem
            // 
            this.ArkivToolstripMnuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolstripMnuItem,
            this.OpenToolstripMnuItem,
            this.SaveToolstripMnuItem,
            this.SaveAsToolstripMnuItem,
            this.CloseToolstripMnuItem});
            this.ArkivToolstripMnuItem.Name = "ArkivToolstripMnuItem";
            this.ArkivToolstripMnuItem.Size = new System.Drawing.Size(46, 20);
            this.ArkivToolstripMnuItem.Text = "Arkiv";
            // 
            // NewToolstripMnuItem
            // 
            this.NewToolstripMnuItem.Name = "NewToolstripMnuItem";
            this.NewToolstripMnuItem.Size = new System.Drawing.Size(129, 22);
            this.NewToolstripMnuItem.Text = "Nytt";
            this.NewToolstripMnuItem.Click += new System.EventHandler(this.NewToolstripMnuItem_Click);
            // 
            // OpenToolstripMnuItem
            // 
            this.OpenToolstripMnuItem.Name = "OpenToolstripMnuItem";
            this.OpenToolstripMnuItem.Size = new System.Drawing.Size(129, 22);
            this.OpenToolstripMnuItem.Text = "Öppna";
            this.OpenToolstripMnuItem.Click += new System.EventHandler(this.OpenToolstripMnuItem_Click);
            // 
            // SaveToolstripMnuItem
            // 
            this.SaveToolstripMnuItem.Name = "SaveToolstripMnuItem";
            this.SaveToolstripMnuItem.Size = new System.Drawing.Size(129, 22);
            this.SaveToolstripMnuItem.Text = "Spara";
            this.SaveToolstripMnuItem.Click += new System.EventHandler(this.SaveToolstripMnuItem_Click);
            // 
            // SaveAsToolstripMnuItem
            // 
            this.SaveAsToolstripMnuItem.Name = "SaveAsToolstripMnuItem";
            this.SaveAsToolstripMnuItem.Size = new System.Drawing.Size(129, 22);
            this.SaveAsToolstripMnuItem.Text = "Spara som";
            this.SaveAsToolstripMnuItem.Click += new System.EventHandler(this.SaveAsToolstripMnuItem_Click);
            // 
            // CloseToolstripMnuItem
            // 
            this.CloseToolstripMnuItem.Name = "CloseToolstripMnuItem";
            this.CloseToolstripMnuItem.Size = new System.Drawing.Size(129, 22);
            this.CloseToolstripMnuItem.Text = "Stäng";
            this.CloseToolstripMnuItem.Click += new System.EventHandler(this.CloseToolstripMnuItem_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(455, 41);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 1;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(583, 41);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(100, 20);
            this.tbxOutput.TabIndex = 2;
            // 
            // btnErsätt
            // 
            this.btnErsätt.Location = new System.Drawing.Point(698, 39);
            this.btnErsätt.Name = "btnErsätt";
            this.btnErsätt.Size = new System.Drawing.Size(83, 22);
            this.btnErsätt.TabIndex = 3;
            this.btnErsätt.Text = "Ersätt";
            this.btnErsätt.UseVisualStyleBackColor = true;
            this.btnErsätt.Click += new System.EventHandler(this.btnErsätt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "->";
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(12, 66);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxText.Size = new System.Drawing.Size(769, 372);
            this.tbxText.TabIndex = 5;
            this.tbxText.TextChanged += new System.EventHandler(this.tbxText_TextChanged);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnErsätt);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.MnuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem ArkivToolstripMnuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolstripMnuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolstripMnuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolstripMnuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolstripMnuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolstripMnuItem;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnErsätt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

