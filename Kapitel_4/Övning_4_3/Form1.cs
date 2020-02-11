using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_4_3
{
    public partial class Form1 : Form
    {
        static List<Kontakt> kontaktlista = new List<Kontakt>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LäggtillTsMnu_Click(object sender, EventArgs e)
        {

        }

        private void TabortTsMnu_Click(object sender, EventArgs e)
        {

        }

        private void ÖppnaTsMnu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);;

                    string förnamn = sr.ReadLine();
                    while(förnamn != null)
                    {
                        string efternamn = sr.ReadLine();
                        string epost = sr.ReadLine();
                        string telefonnummer = sr.ReadLine();
                        Kontakt k = new Kontakt(förnamn, efternamn, epost, telefonnummer);

                    }

                    sr.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void SaveTsMnu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs);

                    foreach (Kontakt k in kontaktlista)
                    {
                        sr.WriteLine(tbxFörnamn.Text);
                        sr.WriteLine(tbxEfternamn.Text);
                        sr.WriteLine(tbxEpost.Text);
                        sr.WriteLine(tbxTelefonummer.Text);
                    }

                    sr.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void SaveAsTsmnu_Click(object sender, EventArgs e)
        {

        }
    }
}
