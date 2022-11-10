using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class ServicioNormal : Form
    {
        private CDatosC cdatos = new CDatosC();
        public ServicioNormal()
        {
            InitializeComponent();
        }

        private void guardarNormal()
        {
            string linea;
            linea = txtIdentificacion1.Text + "" + txtNombre1.Text + "" + txtApellido1.Text;


            if (cdatos.escribir1(linea) == true)

                MessageBox.Show("Ha guardado un cliente casual");

            else
                MessageBox.Show("No se ha podido guardar el cliente...");
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            guardarNormal();
        }
    }
}
