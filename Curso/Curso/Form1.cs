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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            ConfigurarSplash();
        }

        //Método para configurar el SplashScreen.
        private void ConfigurarSplash()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

    }
}
