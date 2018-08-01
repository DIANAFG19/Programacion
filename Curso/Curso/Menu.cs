using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSesion1_Click(object sender, EventArgs e)
        {
            //LLAMADA A UN FORMULARIO.
            //Creamos un objeto para el formulario Sesion1.
            Sesion1 sesion1 = new Sesion1();
            //Mostramos el formulario a través del objeto sesion1.
            sesion1.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //CERRAR EL FORMULARIO.
            //Lo cierra terminando las acciones de todos los componnetes y no quede trabajando nada en memoria.
            Dispose();
        }
    }
}
