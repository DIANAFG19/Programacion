using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Biblioteca para poder usar WindowsFormsApplicationBase.
using Microsoft.VisualBasic.ApplicationServices;

namespace Curso
{
    class Aplicacion : WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            base.OnCreateSplashScreen();
            //Pantalla de Presentación.
            this.SplashScreen = new Presentacion();
            this.MinimumSplashScreenDisplayTime = 2000;
        }

        protected override void OnCreateMainForm()
        {
            base.OnCreateMainForm();
            this.MainForm = new Menu();
            //Argumentos en la línea de órdenes.
            if (this.CommandLineArgs.Count > 0)
            {
                if(this.CommandLineArgs[0] == "/max" || this.CommandLineArgs[0] == "-max")
                {
                    this.MainForm.WindowState = FormWindowState.Maximized;
                }

            }
        }

    }
}
