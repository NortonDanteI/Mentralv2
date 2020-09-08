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
        
        public static Boolean Validar_nombre(string texto)
        {
            if (texto.Length > 3 && texto.Contains(".") != true && texto != "Ingrese nombre")
            {
                return true;

            }
            else
            {
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

        public static Boolean Validar_seccion(string texto)
        {
            if (texto.Length > 10 && texto != "Ingrese sección" && texto != "Ingrese sección a modificar" && texto != "Ingrese el cambio de sección")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static Boolean Validar_trastorno(string texto)
        {
            if (texto.Length>10 && texto!= "Ingrese trastorno" && texto != "Ingrese trastorno a modificar" && texto != "Ingrese el cambio de trastorno")
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public static Boolean Validar_pregunta(string texto)
        {
            if (texto.Length > 10  && texto != "Ingrese pregunta" && texto != "Ingrese pregunta modificar" && texto != "Ingrese el cambio de pregunta")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean Validar_respuesta(string texto)
        {
            if (texto.Length > 10 && texto != "Ingrese respuesta" && texto != "Ingrese respuesta a modificar" && texto != "Ingrese el cambio de respuesta" && texto != "alternativa")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
