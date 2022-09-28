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

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            if (File.Exists("produccion.txt"))
            {
                char varSeparador = Convert.ToChar(",");
                int columna = 0;

                StreamReader srProduccion = new StreamReader("produccion.txt");

                while (!srProduccion.EndOfStream)
                {
                    dgvConsulta.Rows.Add();

                    string[] vecProduccion = srProduccion.ReadLine().Split(varSeparador);


                    dgvConsulta.Rows[columna].Cells[0].Value = vecProduccion[1];
                    dgvConsulta.Rows[columna].Cells[1].Value = vecProduccion[2];
                    dgvConsulta.Rows[columna].Cells[2].Value = vecProduccion[3];



                    columna++;
                }

                srProduccion.Close();
            }
            else
            {
                MessageBox.Show("Error, debe registrar los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
