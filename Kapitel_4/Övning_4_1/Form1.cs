using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnErsätt_Click(object sender, EventArgs e)
        {

        }

        private void NewToolstripMnuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolstripMnuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }

        private void SaveToolstripMnuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveAsToolstripMnuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseToolstripMnuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
