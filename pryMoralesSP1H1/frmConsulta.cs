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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            StreamReader srProduccion = new StreamReader("produccion.txt");

            char varSeparador = Convert.ToChar(",");
            string[] vecProduccion = srProduccion.ReadToEnd().Split(varSeparador);
            string varLocalidad = vecProduccion[1];
            string varCultivo = vecProduccion[2];
            string varTonelada = vecProduccion[3];


            while (!srProduccion.EndOfStream)
            {
                
                dgvConsulta.Rows.Add(varLocalidad);
                
            }
        }
    }
}
