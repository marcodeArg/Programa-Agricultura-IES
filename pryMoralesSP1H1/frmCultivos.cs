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

namespace pryMoralesSP1H1
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnCargarCul_Click(object sender, EventArgs e)
        {
            string varIDCul = mskIDCul.Text;
            string varNombreCul = txtNombreCul.Text;

            StreamWriter miSW = new StreamWriter("cultivos.txt", true);
            miSW.WriteLine(varIDCul + "," + varNombreCul);
            miSW.Close();

            mskIDCul.Clear();
            txtNombreCul.Clear();
        }
    }
}
