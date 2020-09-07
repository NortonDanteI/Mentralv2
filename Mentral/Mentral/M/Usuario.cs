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
        /*atributos*/
        protected static string rut;
        protected static string nombre_pila;
        protected static string segundo_nombre;
        protected static string apellido_paterno;
        protected static string apellido_materno;
        private static string correo;
        private string[] datos;

        /*propiedades set y get*/
        public static string Rut { get => rut; set => rut = value; }
        public static string Nombre_pila { get => nombre_pila; set => nombre_pila = value; }
        public static string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public static string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public static string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public static string Correo { get => correo; set => correo = value; }

        /*constructores*/
        public Usuario()
        {
        }

        /*metodos*/
        public Boolean Logear(String rut, String contraseña) {
            if (Conexion_a_la_bd.Buscar_en_estudiantes(rut, contraseña)) {
                datos = Conexion_a_la_bd.Obtener_datos_estudiante(rut, contraseña);
                Usuario estudiante = new Estudiante(datos[0],datos[1],datos[2],datos[3],datos[4],datos[5],datos[6],datos[7]); 
                return true;
            }
            else {
                if (Conexion_a_la_bd.Buscar_en_docentes(rut,contraseña)) {
                    Usuario docente = new Docente();
                    //Conexion_a_la_bd.Buscar_docente_con_rut_y_contraseña(rut, contraseña);
                    return true;
                }
            }
            return false;
        }
    }
}
            