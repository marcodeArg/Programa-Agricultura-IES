using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoralesSP1H1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades fLocalidades = new frmLocalidades();
            fLocalidades.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos fCultivos = new frmCultivos();
            fCultivos.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion fProduccion = new frmProduccion();
            fProduccion.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acceso denegado!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            //frmConsulta fConsulta = new frmConsulta();
            //fConsulta.ShowDialog();
        }
    }
}
