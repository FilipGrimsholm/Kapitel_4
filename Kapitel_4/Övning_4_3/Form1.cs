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
            try
            {
                //Hämtar inmatad data
                string förnamn = tbxFörnamn.Text;
                string efternamn = tbxEfternamn.Text;
                string epost = tbxEpost.Text;
                string telefonnummer = tbxTelefonummer.Text;

                //Skapar en kontakt och lägger till den i listan
                Kontakt k = new Kontakt(förnamn, efternamn, epost, telefonnummer);
                kontaktlista.Add(k);
                lbxKontakter.Items.Add(k);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
        private void TabortTsMnu_Click(object sender, EventArgs e)
        {
            //Tar bort kontakten från kontaktlistan;
            Kontakt k = lbxKontakter.SelectedItem as Kontakt;
            kontaktlista.Remove(k);

            lbxKontakter.Items.RemoveAt(lbxKontakter.SelectedIndex);
            lbxKontakter.Items.Remove(lbxKontakter.SelectedItem);
            //Tar bort kontakten från listboxen
        }

        private void ÖppnaTsMnu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);

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
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
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
            try
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
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

        private void lbxKontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rensar föregående info
            tbxFörnamn.Clear();
            tbxEfternamn.Clear();
            tbxEpost.Clear();
            tbxTelefonummer.Clear();

            //Hämtar info från kontakten som valdes
            Kontakt k = lbxKontakter.SelectedItem as Kontakt;        
            tbxFörnamn.Text = k._förnamn;
            tbxEfternamn.Text = k._efternamn;
            tbxEpost.Text = k._epost;
            tbxTelefonummer.Text = k._telefonnummer;

            //Alternativ lösning - genomgång
            /*
            int i = lbxKontakter.SelectedIndex;
            tbxFörnamn.Text = kontaktlista[i].ToString();
            */
        }
    }
}
