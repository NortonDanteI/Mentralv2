using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.M
{
    class Usuario
    {
        #region atributos
        private static string rut;
        private static string contraseña;
        private static string nombre;
        private static string correo;
        private static string conexion;
        private static string tipo;
        #endregion

        #region propiedades
        public static string Rut { get => rut; set => rut = value; }
        public static string Contraseña { get => contraseña; set =>  contraseña = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Correo { get => correo; set => correo = value; }
        public static string Conexion { get => conexion; set => conexion = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        #endregion
        /*constructores*/
        public Usuario()
        {
        }

        /*metodos*/
        public Boolean Logear (String rut, String contraseña) {
            string[] datos = new string[6];
            datos = Conexion_a_la_bd.Obtener_usuario(rut, contraseña);
            if (datos != null) {
                if (datos[5]=="Estudiante") {
                    new Estudiante(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                    return true;
                }
                if (datos[5] == "Experto") {
                    new Experto(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                    return true;
                }
            }
            return false;
        }
    }
}
            