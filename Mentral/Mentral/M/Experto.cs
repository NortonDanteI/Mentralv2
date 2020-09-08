using System;
using Mentral.M;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.C;

namespace Mentral.M
{
    class Experto : Usuario
    {
        //atributos

        
        public Experto(String rut,String contraseña,String nombre, String correo, String conexion,String tipo)
        {
            Rut = rut;
            Contraseña = contraseña;
            Nombre = nombre;
            Correo = correo;
            Conexion = conexion;
            Tipo = tipo;
        }

        public Experto(){}
        
        public void Ver_data()
        {
            MessageBox.Show("metodo utilizado para ver la data");
        }
        public void Modificar_data(String seccion_a_modificar, String seccion, String trastorno_a_modificar, String trastorno, String pregunta_a_modificar, String pregunta, String respuesta_a_modificar, String respuesta)
        { 
            //Las modificaciones son independientes y en orden
            if (Validar.Validar_seccion(seccion_a_modificar) && Validar.Validar_seccion(seccion))
            {
                Conexion_a_la_bd.Modificar_seccion(seccion_a_modificar, seccion);
            }

            if (Validar.Validar_trastorno(trastorno_a_modificar) && Validar.Validar_trastorno(trastorno)) 
            {
                Conexion_a_la_bd.Modificar_trastorno(trastorno_a_modificar, trastorno);
            }

            if (Validar.Validar_pregunta(pregunta_a_modificar) && Validar.Validar_pregunta(pregunta))
            {
                Conexion_a_la_bd.Modificar_pregunta(pregunta_a_modificar, pregunta);
            }
                        
            if (Validar.Validar_respuesta(respuesta_a_modificar) && Validar.Validar_respuesta(respuesta))
            {
                Conexion_a_la_bd.Modificar_respuesta(respuesta_a_modificar, respuesta);
            }
        }
        public void Incorporar_data(String seccion, String trastorno, String pregunta, String respuesta,int es_respuesta)
        {
            int contador=0;
            // Si ingresa todos los campos
            if (Validar.Validar_seccion(seccion) && Validar.Validar_trastorno(trastorno) && Validar.Validar_pregunta(pregunta) && Validar.Validar_respuesta(respuesta))
            {
                if (Conexion_a_la_bd.Trastornos_por_seccion(seccion) < 2)
                {
                    Conexion_a_la_bd.Registrar_seccion(seccion);
                    Conexion_a_la_bd.Registrar_trastorno(trastorno, seccion);                   
                }
                else {
                    MessageBox.Show("Ha sobrepasado la inserción de trastornos por sección");
                }
                if (Conexion_a_la_bd.Registrar_pregunta(pregunta, trastorno) == false) { contador++; }
                if (Conexion_a_la_bd.Registrar_respuesta(respuesta) == false) { contador++; }
                if (contador != 2) { Conexion_a_la_bd.Registrar_rel_pregunta_alternativa(pregunta, respuesta, es_respuesta); }
            }
            else {
                MessageBox.Show("La información que esta proporcionando no es válida.");
            }
        }
    }
}
