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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnCargarLoc_Click(object sender, EventArgs e)
        {
            string varIDLoc = mskIDLoc.Text;
            string varNombreLoc = txtNombreLoc.Text;

            StreamWriter miSW = new StreamWriter("localidades.txt", true);
            miSW.WriteLine("ID de Localidad: " + varIDLoc + " | Nombre de Localidad: " + varNombreLoc);
            miSW.Close();

            mskIDLoc.Clear();
            txtNombreLoc.Clear();
        }
    }
}
