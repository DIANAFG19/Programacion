using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Programacion
{
    public partial class Sesion3 : Form
    {
        public string usuario = "";
        public string contras = "";

        public Sesion3()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            usuario = tbUsuario.Text;
            contras = tbContrasena.Text;
            if (usuario == "DIANA" && contras == "12345")
            {
                MessageBox.Show("¡¡BIENVENIDO ADMINISTRADOR!!");
            }
            else
            {
                MessageBox.Show("¡¡¡ACCESO DENEGADO!!!");
            }
            tbUsuario.Clear();
            tbContrasena.Clear();
            tbUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
