using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.C;
using MySql.Data.MySqlClient;

namespace Mentral.M
{
    class Conexion_a_la_bd
    {
        #region atributos de la clase
        private static MySqlConnection conexion;
        private static readonly string datos_de_la_conexion = "server=127.0.0.1; port=3306; username=root; password=; database=mentral";
        private static string consulta;
        private static MySqlDataReader lectura;
        private static MySqlCommand comando;
        private static string[] cadena_de_datos;

        #endregion
        public static void Registrar_usuario(String rut, String contraseña, String nombre_de_pila, String segundo_nombre, String apellido_paterno, String apellido_materno, String institucion_educativa, String carrera, String correo)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `estudiantes`(`rut`, `contraseña`, `nombre_de_pila`, `segundo_nombre`, `apellido_paterno`, `apellido_materno`, `institucion_educativa`, `carrera`, `correo`) VALUES ('" + rut + "','" + Encriptar.Encripta(contraseña) + "','" + nombre_de_pila + "','" + segundo_nombre + "','" + apellido_paterno + "','" + apellido_materno + "','" + institucion_educativa + "','" + carrera + "','" + correo + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Te haz registrado con éxito");
            }
            catch (MySqlException) {
                MessageBox.Show("No se ha podido registrar");
            }
        }

        public static void Modificar_usuario(String rut, String contraseña, String nombre_de_pila, String segundo_nombre, String apellido_paterno, String apellido_materno, String institucion_educativa, String carrera, String correo) {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "UPDATE `estudiantes` SET `contraseña` = '"+Encriptar.Encripta(contraseña)+"',`nombre_de_pila` = '" + nombre_de_pila+ "', `segundo_nombre` = '"+segundo_nombre+ "',`apellido_paterno` = '"+apellido_paterno+ "',`apellido_materno`='"+apellido_materno+ "', `institucion_educativa` ='"+institucion_educativa+ "', `carrera` = '"+carrera+ "', `correo` = '"+correo+"' WHERE `rut` = '" + rut + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos han sido cambiados");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e+"No se han podido modificar tus datos");
            }
        }
        public static String[] Obtener_datos_estudiante(string rut, string contraseña)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `estudiantes` WHERE `rut`='" + rut + "' AND `contraseña`='" + Encriptar.Encripta(contraseña) + "'";
        
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    cadena_de_datos = new string[] {lectura.GetString(0), lectura.GetString(2), lectura.GetString(3), lectura.GetString(4), lectura.GetString(5), lectura.GetString(6), lectura.GetString(7), lectura.GetString(8)};
                }
                conexion.Close();
                return (cadena_de_datos);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return (null);
        }

        public static Boolean Buscar_en_estudiantes(string rut, string contraseña)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            Boolean encontro = false;
            consulta = "SELECT * FROM `estudiantes` WHERE `rut`='" + rut + "' AND `contraseña`='" + Encriptar.Encripta(contraseña) + "'";
            try
            {
                conexion.Open();
                comando = new MySqlCommand(consulta, conexion);
                lectura = null;
                lectura = comando.ExecuteReader();

                while (lectura.Read())
                {
                    encontro = true;
                }
                conexion.Close();

                return encontro;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error de consulta");
            }
            return encontro;
        }

        public static Boolean Buscar_en_docentes(string rut, string contraseña)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            Boolean encontro = false;
            consulta = "SELECT * FROM `docentes` WHERE `rut`='" + rut + "' AND `contraseña`='" + Encriptar.Encripta(contraseña) + "'";
            try
            {
                conexion.Open();
                comando = new MySqlCommand(consulta, conexion);
                lectura = null;
                lectura = comando.ExecuteReader();

                while (lectura.Read())
                {
                    encontro = true;
                }
                conexion.Close();

                return encontro;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error de consulta");
            }
            return encontro;
        }

        public static List<String> Obtener_listado_de_trastornos() {
            List<string> lista = new List<string>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT `nombre_trastorno` FROM `trastornos_mentales`";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    lista.Add(lectura.GetString(0));
                }
                conexion.Close();
                return (lista);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return (lista);
        }
    }
}
