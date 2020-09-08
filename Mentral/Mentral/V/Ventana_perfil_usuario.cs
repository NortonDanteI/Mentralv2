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
    public partial class Ventana_perfil_usuario : Form
    {
        public Ventana_perfil_usuario()
        {
            InitializeComponent();
        }

        #region eventos
        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Boton_modificar_Click(object sender, EventArgs e)
        {
            //Si la contraseña cambio
            if (((Encriptar.Encripta(contraseña.Text)) != (Usuario.Contraseña)) && Validar.Validar_contraseña(contraseña.Text))
            {
                Usuario.Contraseña = Encriptar.Encripta(contraseña.Text);
                if (nombre.Text != Usuario.Nombre && Validar.Validar_nombre(nombre.Text)) { Usuario.Nombre = nombre.Text; }
                if (correo_electronico.Text != Usuario.Correo && Validar.Validar_correo(correo_electronico.Text)) { Usuario.Correo = correo_electronico.Text; }
                Conexion_a_la_bd.Modificar_usuario();
                nombre.ForeColor = Color.AliceBlue;
                correo_electronico.ForeColor = Color.AliceBlue;
                contraseña.Text = "Contraseña";
                contraseña.ForeColor = Color.AliceBlue;
                contraseña.PasswordChar = char.Parse("\0");
            }
            else {// Si la contraseña no cambio pero lo demas si
                if ((Encriptar.Encripta(contraseña.Text)) == (Usuario.Contraseña)) {
                    if (nombre.Text != Usuario.Nombre && Validar.Validar_nombre(nombre.Text) || 
                        correo_electronico.Text != Usuario.Correo && Validar.Validar_correo(correo_electronico.Text)) { 
                            Usuario.Nombre = nombre.Text;
                            Usuario.Correo = correo_electronico.Text;
                            Conexion_a_la_bd.Modificar_usuario();
                    }
                }
            }
        }
        private void Ventana_perfil_Load(object sender, EventArgs e)
        {
            rut.Text = Usuario.Rut;
            nombre.Text = Usuario.Nombre;
            correo_electronico.Text = Usuario.Correo;
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
            if (nombre.Text == Usuario.Nombre)
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }

        private void Correo_electronico_Enter(object sender, EventArgs e)
        {
            if (correo_electronico.Text == Usuario.Correo)
            {
                correo_electronico.Text = "";
                correo_electronico.ForeColor = Color.Black;
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
                nombre.Text = Usuario.Nombre;
                nombre.ForeColor = Color.AliceBlue;
            }
        }

        private void Correo_electronico_Leave(object sender, EventArgs e)
        {
            if (correo_electronico.Text == "")
            {
                correo_electronico.Text = Usuario.Correo;
                correo_electronico.ForeColor = Color.AliceBlue;
            }
        }
        #endregion

       
    }
}