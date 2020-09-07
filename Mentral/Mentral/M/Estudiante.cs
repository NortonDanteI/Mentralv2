using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.M
{
    class Estudiante : Usuario
    {
        private static string institucion_educativa;
        private static string carrera;

        public static string Institucion_educativa { get => institucion_educativa; set => institucion_educativa = value; }
        public static string Carrera { get => carrera; set => carrera = value; }

        /*constructores*/
        public Estudiante(String rut, String nombre_pila, String segundo_nombre, String apellido_paterno, String apellido_materno, String institucion_educativa, String carrera, String correo)
        {
            Rut = rut;
            Nombre_pila = nombre_pila;
            Segundo_nombre = segundo_nombre;
            Apellido_paterno = apellido_paterno;
            Apellido_materno = apellido_materno;
            Correo = correo;
            Institucion_educativa = institucion_educativa;
            Carrera = carrera;
        }

        /*Metodos*/
        public void Ver_perfil()
        {
            MessageBox.Show("metodo utilizado para ver el perfil del estudiante");
        }
        public void Responder_cuestionario()
        {
            MessageBox.Show("metodo utilizado para responder cuestionarios");
        }
    }
}
