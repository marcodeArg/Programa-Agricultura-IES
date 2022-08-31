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

        private void btnCargarPro_Click(object sender, EventArgs e)
        {

        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srCultivos = new StreamReader("cultivos.txt");
            StreamReader srLocalidades = new StreamReader("localidades.txt");

            while(!srCultivos.EndOfStream)
            {
                cboNombreCulPro.Items.Add(srCultivos.ReadLine());
            }
            
            srLocalidades.Close();

            while (!srLocalidades.EndOfStream)
            {
                cboNombreLocPro.Items.Add(srLocalidades.ReadLine());
            }

            srCultivos.Close();

            

        }
    }
}
