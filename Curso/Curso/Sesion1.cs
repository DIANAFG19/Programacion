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
    public partial class Sesion1 : Form
    {
        private TextBox objTextBox = null;
        public Sesion1()
        {
            InitializeComponent();
        }

        private void tbGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void tbGradosF_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si se escribio en la caja de texto grados centígrados...
                if(objTextBox == tbGradosC)
                {
                    grados = Convert.ToDouble(tbGradosC.Text) * 9.0 / 5.0 + 32;
                    //Mostrar el resultado redondeado a dos decimales.
                    tbGradosF.Text = string.Format("{0:F2}", grados);
                }
                //Si se escribio en la caja de texto grados fahrenheit...
                if (objTextBox == tbGradosF)
                {
                    grados = (Convert.ToDouble(tbGradosF.Text) - 32.0) * 5.0 / 9.0;
                    //Mostrar el resultado redondeado a dos decimales.
                    tbGradosC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                tbGradosC.Text = "0.00";
                tbGradosF.Text = "32.00";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
