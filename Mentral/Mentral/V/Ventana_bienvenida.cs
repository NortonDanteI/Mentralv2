﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.M;

namespace Mentral.V
{
    public partial class Ventana_bienvenida : Form
    {
        public Ventana_bienvenida()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 2;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.038;
            if (this.Opacity == 0)
            {
                timer1.Stop();
                timer2.Stop();
                this.Close();
            }
        }

        private void Ventana_bienvenida_Load_1(object sender, EventArgs e)
        {
            nombre_usuario.Text = Usuario.Nombre;
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
