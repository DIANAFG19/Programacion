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
    public partial class Sesion4 : Form
    {
        //Declaramos variables a utilizar
        public bool cadena = true;
        public int primer;
        public int ultimo;
        public int resultado;
        public string operacion = "";

        public Sesion4()
        {
            InitializeComponent();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text == "0")
            {
                return;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "0";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "1";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "2";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "3";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "4";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "5";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "6";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "7";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "8";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (cadena == true)
            {
                tbPantalla.Text = "9";
                cadena = false;
            }
            else
            {
                tbPantalla.Text = tbPantalla.Text + "9";
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primer = Convert.ToInt32(tbPantalla.Text);
            cadena = true;
            ultimo = ultimo + primer;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            cadena = true;
            primer = Convert.ToInt32(tbPantalla.Text);
            ultimo = primer - ultimo;
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            ultimo = 1;
            operacion = "*";
            cadena = true;
            primer = Convert.ToInt32(tbPantalla.Text);
            ultimo = ultimo * primer;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacion == "+")
            {
                resultado = ultimo + primer;
                tbPantalla.Text = Convert.ToString(resultado);
                cadena = true;
            }
            else if (operacion == "-")
            {
                resultado = primer - ultimo;
                tbPantalla.Text = Convert.ToString(resultado);
                cadena = true;
            }
            else if (operacion == "*")
            {
                resultado = ultimo * primer;
                tbPantalla.Text = Convert.ToString(resultado);
                cadena = true;
            }
            else
            {
                tbPantalla.Text = "ERROR";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbPantalla.Clear();
            cadena = true;
            primer = 0;
            ultimo = 0;
            resultado = 0;
            operacion = "";
        }
    }
}
