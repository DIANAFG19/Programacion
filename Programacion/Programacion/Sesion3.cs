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
    public partial class Sesion3 : Form
    {
        public float num;
        public float resultado;
        public string mostrar;
        public float resul;

        public Sesion3()
        {
            InitializeComponent();
        }

        private void Sesion3_Load(object sender, EventArgs e)
        {
            btnMenos.Visible = false;
            btnPor.Visible = false;
            btnEntre.Visible = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            btnMas.Visible = true;
            btnMenos.Visible = false;
            btnPor.Visible = false;
            btnEntre.Visible = false;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            num = Convert.ToSingle(tbNumero.Text);
            tbNumero.Clear();
            tbNumero.Focus();
            resultado = resultado + num;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            resul = resultado + num;
            tbResultado.Text = Convert.ToString(resul);
            tbNumero.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            btnMenos.Visible = true;
            btnMas.Visible = false;
            btnPor.Visible = false;
            btnEntre.Visible = false;
        }
    }
}
