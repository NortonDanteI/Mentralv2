using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.M;
using Mentral.C;

namespace Mentral.V
{
    public partial class Ventana_perfil : Form
    {
        public Ventana_perfil()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Carrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Correo_electronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Institucion_educativa_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Boton_registrar_Click(object sender, EventArgs e)
        {
            if (Validar.Validar_contraseña(contraseña.Text) && Validar.Validar_primer_nombre(primer_nombre.Text)
               && Validar.Validar_segundo_nombre(segundo_nombre.Text) && Validar.Validar_apellido_paterno(apellido_paterno.Text)
               && Validar.Validar_apellido_materno(apellido_materno.Text) && Validar.Validar_institucion_educativa(institucion_educativa.Text)
               && Validar.Validar_carrera(carrera.Text) && Validar.Validar_correo(correo_electronico.Text))
            {
                Conexion_a_la_bd.Modificar_usuario(rut.Text, contraseña.Text, primer_nombre.Text, segundo_nombre.Text, apellido_paterno.Text, apellido_materno.Text, institucion_educativa.Text, carrera.Text, correo_electronico.Text);
            }
        }

        private void Ventana_perfil_Load(object sender, EventArgs e)
        {
            rut.Text = Estudiante.Rut;
            primer_nombre.Text = Estudiante.Nombre_pila;
            segundo_nombre.Text = Estudiante.Segundo_nombre;
            apellido_paterno.Text = Estudiante.Apellido_paterno;
            apellido_materno.Text = Estudiante.Apellido_materno;
            carrera.Text = Estudiante.Carrera;
            institucion_educativa.Text = Estudiante.Institucion_educativa;
            correo_electronico.Text = Estudiante.Correo;
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

        private void Rut_Leave(object sender, EventArgs e)
        {
            if (rut.Text == "")
            {
                rut.Text = "Rut";
                rut.ForeColor = Color.AliceBlue;
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

        private void Segundo_nombre_Leave(object sender, EventArgs e)
        {
            if (segundo_nombre.Text == "")
            {
                segundo_nombre.Text = "Segundo nombre";
                segundo_nombre.ForeColor = Color.AliceBlue;
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
            if (primer_nombre.Text == "")
            {
                apellido_materno.Text = "Apellido materno";
                apellido_materno.ForeColor = Color.AliceBlue;
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

        private void Institucion_educativa_Leave(object sender, EventArgs e)
        {
            if (institucion_educativa.Text == "")
            {
                institucion_educativa.Text = "Institución educativa";
                institucion_educativa.ForeColor = Color.AliceBlue;
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}