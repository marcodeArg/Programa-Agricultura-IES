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
            bool varBandera = false;
            char varSeparador = Convert.ToChar(",");

            //Crear el arhivo si todavia no existe
            StreamWriter swArchivoLoc = new StreamWriter("localidades.txt", true);
            swArchivoLoc.Close();


            StreamReader srLocalidades = new StreamReader("localidades.txt");

            //Validar si el archivo tiene algo
            while (!srLocalidades.EndOfStream && !varBandera)
            {
                string[] nombreLoc = srLocalidades.ReadLine().Split(varSeparador);

                //Validar si ya se cargo antes el mismo ID 
                if (varIDLoc == nombreLoc[0])
                {
                    varBandera = true;
                }
            }

            srLocalidades.Close();

            //Cargar por primera vez y tambien si el ID no esta repetido
            if (!varBandera)
            {
                StreamWriter swCultivos = new StreamWriter("localidades.txt", true);

                swCultivos.WriteLine(varIDLoc + "," + varNombreLoc);
                swCultivos.Close();

                MessageBox.Show("Localidad cargada correctamente.");

                //Limpiar los campos
                mskIDLoc.Clear();
                txtNombreLoc.Clear();

                mskIDLoc.Focus();
            }
            else
            {
                MessageBox.Show("El numero identificador ya existe para otra localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mskIDLoc.Focus();
            }


        }
    }
}
