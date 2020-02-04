using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Övning_4_1
{
    public partial class Form1 : Form
    {
        string filename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnErsätt_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tbxInput.Text;
                string output = tbxOutput.Text;

                tbxText.Text = tbxText.Text.Replace(input, output);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void NewToolstripMnuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = dlgSaveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filename = dlgSaveFile.FileName;
                    FileStream inström = new FileStream(dlgSaveFile.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter läsare = new StreamWriter(inström);
                    läsare.Dispose();
                }
                else
                {
                    MessageBox.Show("The operation was canceled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! /n " + ex.ToString());
            }
        }

        private void OpenToolstripMnuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = dlgOpenFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filename = dlgOpenFile.FileName;
                    FileStream inström = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader läsare = new StreamReader(inström);

                    string filltext = läsare.ReadToEnd();
                    tbxText.Text = filltext;
                    läsare.Dispose();
                }
                else
                {
                    MessageBox.Show("The operation was canceled");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void SaveToolstripMnuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename == "")
                {
                    DialogResult result = dlgSaveFile.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        FileStream utStröm = new FileStream(dlgSaveFile.FileName, FileMode.Create, FileAccess.Write);
                        filename = dlgSaveFile.FileName;
                        StreamWriter skrivare = new StreamWriter(utStröm);

                        skrivare.Write(tbxText.Text);
                        skrivare.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("The operation was canceled");
                    }
                }
                else
                {
                    FileStream utStröm = new FileStream(filename, FileMode.Create, FileAccess.Write);
                    StreamWriter skrivare = new StreamWriter(utStröm);

                    skrivare.Write(tbxText.Text);
                    skrivare.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void SaveAsToolstripMnuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = dlgSaveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream utStröm = new FileStream(dlgSaveFile.FileName, FileMode.Create, FileAccess.Write);
                    filename = dlgSaveFile.FileName;
                    StreamWriter skrivare = new StreamWriter(utStröm);

                    skrivare.Write(tbxText.Text);
                    skrivare.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void CloseToolstripMnuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void tbxText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
