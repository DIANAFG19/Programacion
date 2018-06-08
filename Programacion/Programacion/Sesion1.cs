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
    public partial class Sesion1 : Form
    {
        public Sesion1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo objeto.
            Inicio inicio = new Inicio();
            //Mostramos al objeto creado.
            inicio.Show();
            //Cerramos el formulario actual.
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo objeto.
            Inicio inicio = new Inicio();
            //Mostramos al objeto creado.
            inicio.Close();
            this.Close();
        }
    }
}
