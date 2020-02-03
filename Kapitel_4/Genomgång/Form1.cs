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


namespace Genomgång
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = tbxText.Text;
            StreamWriter sw = new StreamWriter("text.txt");
            sw.Write(text);
            sw.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileStream inStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(inStream);
                string text = sr.ReadToEnd();
                tbxText.Text = Text;
                sr.Dispose();
            }
        }
    }
}
