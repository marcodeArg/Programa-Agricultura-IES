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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srCultivos = new StreamReader("cultivos.txt");
            StreamReader srLocalidades = new StreamReader("localidades.txt");

            char varSeparador = Convert.ToChar(",");

            while(!srCultivos.EndOfStream)
            {
                string[] nombreCul = srCultivos.ReadLine().Split(varSeparador);

                cboNombreCulPro.Items.Add(nombreCul[1]);
            }
            
            srCultivos.Close();

            while (!srLocalidades.EndOfStream)
            {
                string[] nombreLoc = srLocalidades.ReadLine().Split(varSeparador);

                cboNombreLocPro.Items.Add(nombreLoc[1]);
            }

            srLocalidades.Close();
        }

        private void btnCargarPro_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("produccion.txt", true);

            DateTime varFecha = dtFecha.Value.Date;
            string varNombreLoc = cboNombreLocPro.Text;
            string varNombreCul = cboNombreCulPro.Text;
            string varTonelada = mskToneladaPro.Text;
            string varMensaje =  varFecha + "," + varNombreLoc + "," + varNombreCul + "," + varTonelada;

            mskToneladaPro.Clear();

            cboNombreCulPro.Focus();


            swProduccion.WriteLine(varMensaje);

            swProduccion.Close();
        }
    }
}
