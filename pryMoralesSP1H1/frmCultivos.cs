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
            bool varBandera = false;
            char varSeparador = Convert.ToChar(",");

            //Crear el arhivo si todavia no existe
            StreamWriter swArchivoCul = new StreamWriter("cultivos.txt", true);
            swArchivoCul.Close();

            StreamReader srCultivos = new StreamReader("cultivos.txt");

            //Validar si el archivo tiene algo
            while (!srCultivos.EndOfStream && !varBandera)
            {
                string[] nombreCul = srCultivos.ReadLine().Split(varSeparador);

                //Validar si ya se cargo antes el mismo ID 
                if (varIDCul == nombreCul[0])
                {
                    varBandera = true;
                }
            }

            srCultivos.Close();

            //Cargar por primera vez y tambien si el ID no esta repetido
            if (!varBandera)
            {
                StreamWriter swCultivos = new StreamWriter("cultivos.txt", true);

                swCultivos.WriteLine(varIDCul + "," + varNombreCul);
                swCultivos.Close();

                MessageBox.Show("Cultivo cargado correctamente.");

                //Limpiar los campos
                mskIDCul.Clear();
                txtNombreCul.Clear();

                mskIDCul.Focus();
            }
            else
            {
                MessageBox.Show("El numero identificador ya existe para otro cultivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mskIDCul.Focus();
            }
        }
    }
}
