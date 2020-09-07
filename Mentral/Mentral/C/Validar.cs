using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mentral.C
{
    class Validar
    {
        #region metodos de validacion con expresiones regulares
        public static Boolean Validar_rut(string texto) {
            Regex regular = new Regex(@"^(\d{2}\.\d{3}\.\d{3}-)([a-zA-Z]{1}$|\d{1}$)");
            if (regular.IsMatch(texto))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El rut ingresado no es valido.");
                return false;
            }
        }
        public static Boolean Validar_contraseña(string contraseña)
        {

            if (contraseña.Length >= 4 && contraseña != "Contraseña")
            {
                return true;
            }
            else
            {
                MessageBox.Show("La contraseña no es valida");
                return false;
            }
        }
        public static Boolean Validar_primer_nombre(string texto) {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{2,50}");
            if (regular.IsMatch(texto)&& (texto!="Primer nombre"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El primer nombre no es valido.");
                return false;
            }
        }
        public static Boolean Validar_segundo_nombre(string texto)
        {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{2,50}");
            if (regular.IsMatch(texto) && (texto != "Segundo nombre"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El segundo nombre no es valido.");
                return false;
            }
        }
        public static Boolean Validar_apellido_paterno(string texto)
        {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{2,50}");
            if (regular.IsMatch(texto) && (texto != "Apellido paterno"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El apellido paterno no es valido.");
                return false;
            }
        }
        public static Boolean Validar_apellido_materno(string texto)
        {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{2,50}");
            if (regular.IsMatch(texto) && (texto != "Apellido materno"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El apellido materno no es valido.");
                return false;
            }
        }
        public static Boolean Validar_institucion_educativa(string texto)
        {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{3,50}");
            if (regular.IsMatch(texto) && (texto != "Institución educativa"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La institución educativa no es valida.");
                return false;
            }
        }
        public static Boolean Validar_carrera(string texto)
        {
            Regex regular = new Regex(@"[a-zA-ZñÑ\s]{4,50}");
            if (regular.IsMatch(texto) && (texto != "Carrera"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La carrera no es valida.");
                return false;
            }
        }
        public static Boolean Validar_correo(string texto)
        {
            Regex regular = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
            if (regular.IsMatch(texto))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El correo esta mal escrito.");
                return false;
            }
        }
        #endregion
    }
}
