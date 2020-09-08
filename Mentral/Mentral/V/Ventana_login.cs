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
using System.Security.Cryptography;

namespace Mentral.V
{
    public partial class Ventana_login : Form
    {
        public Ventana_login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #region Eventos
        private void Texto_contraseña_Enter(object sender, EventArgs e)
        {
            if (texto_contraseña.Text == "Contraseña")
            {
                texto_contraseña.Text = "";
                texto_contraseña.ForeColor = Color.Black;
                texto_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Texto_contraseña_Leave(object sender, EventArgs e)
        {
            if (texto_contraseña.Text == "")
            {
                texto_contraseña.Text = "Contraseña";
                texto_contraseña.ForeColor = Color.AliceBlue;
                texto_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Todos los derechos reservados a Norton Irarrázabal");
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Boton_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Boton_ingresar_Click(object sender, EventArgs e){
            if (texto_rut.Text != "Rut" && texto_contraseña.Text != "Contraseña"){
                Usuario usuario = new Usuario();
                if (usuario.Logear(texto_rut.Text, texto_contraseña.Text)) {
                    this.Hide();     
                    if (Usuario.Tipo =="Estudiante") {
                        Motor_de_inferencia.Generar_estructura();
                        Motor_de_inferencia.Fuzzificar_estructura();
                        Ventana_bienvenida ventana_bienvenida_1 = new Ventana_bienvenida();
                        ventana_bienvenida_1.ShowDialog();
                        Ventana_estudiante ventana_principal_1 = new Ventana_estudiante();
                        ventana_principal_1.Show();
                        ventana_principal_1.FormClosed += Salir;
                    }
                    if (Usuario.Tipo == "Experto") {
                        Ventana_bienvenida ventana_bienvenida_1 = new Ventana_bienvenida();
                        ventana_bienvenida_1.ShowDialog();
                        Ventana_experto ventana_principal_2 = new Ventana_experto();
                        ventana_principal_2.Show();
                        ventana_principal_2.FormClosed += Salir;
                    }
                }
                else {
                    MessageBox.Show("Credenciales no validas");
                    texto_rut.Text = "Rut";
                    texto_contraseña.Text = "Contraseña";
                    texto_contraseña.ForeColor = Color.AliceBlue;
                    texto_contraseña.UseSystemPasswordChar = false;
                    texto_rut.Focus();
                }
            }
            else {
                MessageBox.Show("Ingrese su rut xx.xxx.xxx-x y contraseña");
            }
        }
        private void Salir(object sender, FormClosedEventArgs e) {
            texto_rut.Text= "Rut";
            texto_contraseña.Text = "Contraseña";
            texto_contraseña.ForeColor = Color.AliceBlue;
            texto_contraseña.UseSystemPasswordChar = false;
            this.Show();
            texto_rut.Focus();
        }
        private void Registrarse_Click(object sender, EventArgs e)
        {
            Ventana_registro ventana_registro_1 = new Ventana_registro();
            ventana_registro_1.Show();
        }

        private void Texto_rut_Enter(object sender, EventArgs e)
        {
            if (texto_rut.Text == "Rut")
            {
                texto_rut.Text = "";
                texto_rut.ForeColor = Color.Black;
            }
        }

        private void Texto_rut_Leave(object sender, EventArgs e)
        {
            if (texto_rut.Text == "")
            {
                texto_rut.Text = "Rut";
                texto_rut.ForeColor = Color.AliceBlue;
            }
        }
        int posY = 0;
        int posX = 0;

        private void Barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }
        #endregion
    }
}
