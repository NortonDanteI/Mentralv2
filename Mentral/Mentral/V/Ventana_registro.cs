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
        /*Este codigo es para poder desplazar paneles, el DllImport funciona en tiempo de ejecución*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        /*Mando el mensaje con las coordenadas*/
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Rut_Enter(object sender, EventArgs e)
        {
            if (rut.Text == "Rut")
            {
                rut.Text = "";
                rut.ForeColor = Color.Black;
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

        private void Barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Contraseña";
                contraseña.ForeColor = Color.AliceBlue;
                contraseña.PasswordChar = char.Parse("\0");
            }
        }

        private void Primer_nombre_Leave(object sender, EventArgs e)
        {
            if (primer_nombre.Text == "")
            {
                primer_nombre.Text = "Primer nombre";
                primer_nombre.ForeColor = Color.AliceBlue;
            }
        }

        private void Primer_nombre_Enter(object sender, EventArgs e)
        {
            if (primer_nombre.Text == "Primer nombre")
            {
                primer_nombre.Text = "";
                primer_nombre.ForeColor = Color.Black;
            }
        }

        private void Segundo_nombre_Leave(object sender, EventArgs e)
        {
            if (segundo_nombre.Text == "")
            {
                segundo_nombre.Text = "Segundo nombre";
                segundo_nombre.ForeColor = Color.AliceBlue;
            }
        }

        private void Segundo_nombre_Enter(object sender, EventArgs e)
        {
            if (segundo_nombre.Text == "Segundo nombre")
            {
                segundo_nombre.Text = "";
                segundo_nombre.ForeColor = Color.Black;
            }
        }

        private void Apellido_paterno_Enter(object sender, EventArgs e)
        {
            if (apellido_paterno.Text == "Apellido paterno")
            {
                apellido_paterno.Text = "";
                apellido_paterno.ForeColor = Color.Black;
            }
        }

        private void Apellido_paterno_Leave(object sender, EventArgs e)
        {
            if (apellido_paterno.Text == "")
            {
                apellido_paterno.Text = "Apellido paterno";
                apellido_paterno.ForeColor = Color.AliceBlue;
            }
        }

        private void Apellido_materno_Leave(object sender, EventArgs e)
        {
            if (apellido_materno.Text == "")
            {
                apellido_materno.Text = "Apellido materno";
                apellido_materno.ForeColor = Color.AliceBlue;
            }
        }

        private void Apellido_materno_Enter(object sender, EventArgs e)
        {
            if (apellido_materno.Text == "Apellido materno")
            {
                apellido_materno.Text = "";
                apellido_materno.ForeColor = Color.Black;
            }
        }

        private void Institucion_educativa_Leave(object sender, EventArgs e)
        {
            if (institucion_educativa.Text == "")
            {
                institucion_educativa.Text = "Institución educativa";
                institucion_educativa.ForeColor = Color.AliceBlue;
            }
        }

        private void Institucion_educativa_Enter(object sender, EventArgs e)
        {
            if (institucion_educativa.Text == "Institución educativa")
            {
                institucion_educativa.Text = "";
                institucion_educativa.ForeColor = Color.Black;
            }
        }

        private void Carrera_Leave(object sender, EventArgs e)
        {
            if (carrera.Text == "")
            {
                carrera.Text = "Carrera";
                carrera.ForeColor = Color.AliceBlue;
            }
        }

        private void Carrera_Enter(object sender, EventArgs e)
        {
            if (carrera.Text == "Carrera")
            {
                carrera.Text = "";
                carrera.ForeColor = Color.Black;
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

        private void Correo_electronico_Enter(object sender, EventArgs e)
        {
            if (correo_electronico.Text == "Correo electrónico")
            {
                correo_electronico.Text = "";
                correo_electronico.ForeColor = Color.Black;
            }
        }

        private void Boton_registrar_Click(object sender, EventArgs e)
        {
            if (Validar.Validar_rut(rut.Text) && Validar.Validar_contraseña(contraseña.Text) && Validar.Validar_primer_nombre(primer_nombre.Text) 
                && Validar.Validar_segundo_nombre(segundo_nombre.Text) && Validar.Validar_apellido_paterno(apellido_paterno.Text) 
                && Validar.Validar_apellido_materno(apellido_materno.Text) && Validar.Validar_institucion_educativa(institucion_educativa.Text) 
                && Validar.Validar_carrera(carrera.Text) && Validar.Validar_correo(correo_electronico.Text))
            {
                Conexion_a_la_bd.Registrar_usuario(rut.Text,contraseña.Text,primer_nombre.Text,segundo_nombre.Text,apellido_paterno.Text,apellido_materno.Text,institucion_educativa.Text,carrera.Text,correo_electronico.Text);
            }
        }
    }
}
