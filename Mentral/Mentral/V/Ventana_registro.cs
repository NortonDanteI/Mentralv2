using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Mentral.M;
using System.Text.RegularExpressions;
using Mentral.C;
using System.Globalization;

namespace Mentral.V
{
    public partial class Ventana_registro : Form
    {
        public Ventana_registro()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BringToFront();
        }

        #region eventos
        int posY = 0;
        int posX = 0;

        private void Barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void Boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Rut_Enter(object sender, EventArgs e)
        {
            if (rut.Text == "Rut")
            {
                rut.Text = "";
                rut.ForeColor = Color.Black;
            }
        }
        
        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (contraseña.Text == "Contraseña")
            {
                contraseña.Text = "";
                contraseña.ForeColor = Color.Black;
                contraseña.PasswordChar = '*';
            }
        }
        private void Nombre_Enter(object sender, EventArgs e)
        {
            if (nombre.Text == "Nombre")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }
        private void Correo_electronico_Enter(object sender, EventArgs e)
        {
            if (correo_electronico.Text == "Correo electrónico")
            {
                correo_electronico.Text = "";
                correo_electronico.ForeColor = Color.Black;
            }
        }
        private void Rut_Leave(object sender, EventArgs e)
        {
            if (rut.Text == "")
            {
                rut.Text = "Rut";
                rut.ForeColor = Color.AliceBlue;
            }
        }
        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Contraseña";
                contraseña.ForeColor = Color.AliceBlue;
                contraseña.PasswordChar = char.Parse("\0");
            }
        }
        private void Nombre_Leave(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                nombre.Text = "Nombre";
                nombre.ForeColor = Color.AliceBlue;
            }
        }    
        private void Correo_electronico_Leave(object sender, EventArgs e)
        {
            if (correo_electronico.Text == "")
            {
                correo_electronico.Text = "Correo electrónico";
                correo_electronico.ForeColor = Color.AliceBlue;
            }
        }
        private void Boton_registrar_Click(object sender, EventArgs e)
        {
            string conexion = (DateTime.Now.ToShortDateString());
            if (Validar.Validar_rut(rut.Text) && Validar.Validar_contraseña(contraseña.Text) && Validar.Validar_nombre(nombre.Text) && Validar.Validar_correo(correo_electronico.Text) && (estudiante.Checked || experto.Checked))
            {
                if (estudiante.Checked) {
                    new Estudiante((rut.Text), (contraseña.Text), ((nombre.Text).Substring(0, 1).ToUpper()) + (nombre.Text).Substring(1), (correo_electronico.Text), (conexion), (estudiante.Text));
                    Conexion_a_la_bd.Registrar_usuario();
                }
                if (experto.Checked) {
                    new Experto((rut.Text), (contraseña.Text), ((nombre.Text).Substring(0, 1).ToUpper()) + ((nombre.Text).Substring(1)), (correo_electronico.Text), (conexion), (experto.Text));
                    Conexion_a_la_bd.Registrar_usuario();
                }   
            }
        }
        #endregion
    }
}
