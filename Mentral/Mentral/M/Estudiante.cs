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
        /*constructores*/
        public Estudiante(String rut,String contraseña, String nombre, String correo, String conexion,String tipo)
        {
            Rut = rut;
            Contraseña = contraseña;
            Nombre = nombre;
            Correo = correo;
            Conexion = conexion;
            Tipo = tipo;
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
