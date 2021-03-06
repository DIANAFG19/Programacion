﻿using System;
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

        private void Presentacion_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 3;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
