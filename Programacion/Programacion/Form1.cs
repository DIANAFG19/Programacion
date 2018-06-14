using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSesion1_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo objeto.
            Sesion1 sesion1 = new Sesion1();
            //Mostramos al objeto creado.
            sesion1.Show();
            //Ocultamos este formulario.
            this.Hide();
        }

        private void btnSesion2_Click(object sender, EventArgs e)
        {
            Sesion2 sesion2 = new Sesion2();
            sesion2.Show();
            this.Hide();
        }

        private void btnSesion3_Click(object sender, EventArgs e)
        {
            Sesion3 sesion3 = new Sesion3();
            sesion3.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cerramos nuestro formulario.
            Close();
        }       
    }
}
