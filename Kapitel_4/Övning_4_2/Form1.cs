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

namespace Övning_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÖppna_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = dlgÖppnaFil.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream inström = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader läsare = new StreamReader(inström);

                    string förnamn = läsare.ReadLine();
                    string efternamn = läsare.ReadLine();
                    string epost = läsare.ReadLine();
                    string telefonnummer = läsare.ReadLine();                 

                    tbxFörnamn.Text = förnamn;
                    tbxEfternamn.Text = efternamn;
                    tbxEpost.Text = epost;
                    tbxTelefonnummer.Text = telefonnummer;
                    
                    läsare.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnSparasom_Click(object sender, EventArgs e)
        {        
            try
            {
                dlgSaveFil.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                DialogResult result = dlgSaveFil.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream inström = new FileStream(dlgSaveFil.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter skrivare = new StreamWriter(inström);

                    skrivare.WriteLine(tbxFörnamn.Text);
                    skrivare.WriteLine(tbxEfternamn.Text);
                    skrivare.WriteLine(tbxEpost.Text);
                    skrivare.WriteLine(tbxTelefonnummer.Text);

                    skrivare.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
