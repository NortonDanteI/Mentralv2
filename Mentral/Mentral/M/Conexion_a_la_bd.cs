using System;
using System.Collections.Generic;
using System.Data;
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
        private static readonly string datos_de_la_conexion = "server=127.0.0.1; port=3306; username=root; password=; database=mentralv2";
        private static string consulta;
        private static MySqlDataReader lectura;
        private static MySqlCommand comando;
        private static string[] cadena_de_datos;
        #endregion

        #region segmento de la ventana registrar
        public static void Registrar_usuario()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `usuarios` (`rut`, `contraseña`, `nombre`, `correo`, `conexion`, `tipo`) VALUES('" + Usuario.Rut + "','" + Encriptar.Encripta(Usuario.Contraseña) + "','" + Usuario.Nombre + "','" + Usuario.Correo + "','" + Usuario.Conexion + "','" + Usuario.Tipo + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El usuario se ha registrado con éxito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido registrar al usuario");
            }
        }

        #endregion

        #region Segmento de la ventana perfil_usuario
        public static void Modificar_usuario()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "UPDATE `usuarios` SET `contraseña` = '" + Usuario.Contraseña + "',`nombre` = '" + Usuario.Nombre + "',`correo` = '" + Usuario.Correo + "' WHERE `rut` = '" + Usuario.Rut + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos de usuario han sido cambiados");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e + "No se han podido modificar tus datos");
            }
        }
        #endregion

        #region Semento para clase Usuario
        public static String[] Obtener_usuario(string rut, string contraseña)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `usuarios` WHERE `rut`='" + rut + "' AND `contraseña`='" + Encriptar.Encripta(contraseña) + "'";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    cadena_de_datos = new string[] { lectura.GetString(0), lectura.GetString(1), lectura.GetString(2), lectura.GetString(3), lectura.GetString(4), lectura.GetString(5) };
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
        #endregion

        #region Segmento de la ventana ver
        public static DataTable Obtener_data_secciones_de_conocimiento()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `secciones`";
            DataTable data = new DataTable();

            try
            {
                conexion.Open();
                MySqlDataAdapter d = new MySqlDataAdapter(consulta, conexion);
                d.Fill(data);
                return (data);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se puede obtener la data de secciones");
            }
            return null;
        }
        public static DataTable Obtener_data_trastornos_mentales()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `trastornos`";
            DataTable data = new DataTable();

            try
            {
                conexion.Open();
                MySqlDataAdapter d = new MySqlDataAdapter(consulta, conexion);
                d.Fill(data);
                return (data);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se puede obtener la data de trastornos");
            }
            return null;
        }
        public static DataTable Obtener_data_preguntas()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `preguntas`";
            DataTable data = new DataTable();

            try
            {
                conexion.Open();
                MySqlDataAdapter d = new MySqlDataAdapter(consulta, conexion);
                d.Fill(data);
                return (data);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se puede obtener la data de preguntas");
            }
            return null;
        }
        public static DataTable Obtener_data_alternativas()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `alternativas`";
            DataTable data = new DataTable();

            try
            {
                conexion.Open();
                MySqlDataAdapter d = new MySqlDataAdapter(consulta, conexion);
                d.Fill(data);
                return (data);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se puede obtener la data de alternativas");
            }
            return null;
        }
        public static DataTable Obtener_data_relacion()
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `rel_preguntas_alternativas`";
            DataTable data = new DataTable();

            try
            {
                conexion.Open();
                MySqlDataAdapter d = new MySqlDataAdapter(consulta, conexion);
                d.Fill(data);
                return (data);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se puede obtener la data de relaciones");
            }
            return null;
        }
        #endregion

        #region Segmento de la ventana modificar
        public static void Modificar_seccion(String seccion_a_modificar, String seccion)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = ("UPDATE `secciones` SET `seccion` = '" + seccion + "' WHERE `secciones`.`seccion` = '" + seccion_a_modificar + "'");
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            int registros_modificados;

            try
            {
                conexion.Open();
                registros_modificados = comando.ExecuteNonQuery();
                conexion.Close();

                if (registros_modificados > 0)
                {
                    MessageBox.Show("La sección de conocimiento se ha modificado con éxito.");
                }
                else {
                    MessageBox.Show("La sección no ha sido modificada.");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en modificar registros.");
            }
        }
        public static void Modificar_trastorno(String trastorno_a_modificar, String trastorno)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = ("UPDATE `trastornos` SET `trastorno` = '" + trastorno + "' WHERE `trastornos`.`trastorno` = '" + trastorno_a_modificar + "'");
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            int registros_modificados;

            try
            {
                conexion.Open();
                registros_modificados = comando.ExecuteNonQuery();
                conexion.Close();

                if (registros_modificados > 0)
                {
                    MessageBox.Show("El trastorno se ha modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("El trastorno no ha sido modificado.");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en modificar registros.");
            }
        }
        public static void Modificar_pregunta(String pregunta_a_modificar, String pregunta)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = ("UPDATE `preguntas` SET `pregunta` = '" + pregunta + "' WHERE `preguntas`.`pregunta` = '" + pregunta_a_modificar + "'");
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            int registros_modificados;

            try
            {
                conexion.Open();
                registros_modificados = comando.ExecuteNonQuery();
                conexion.Close();

                if (registros_modificados > 0)
                {
                    MessageBox.Show("La pregunta se ha modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("La pregunta no ha sido modificada.");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en modificar registros.");
            }
        }
        public static void Modificar_respuesta(String respuesta_a_modificar, String respuesta)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = ("UPDATE `alternativas` SET `alternativa` = '" + respuesta + "' WHERE `alternativas`.`alternativa` = '" + respuesta_a_modificar + "'");
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            int registros_modificados;

            try
            {
                conexion.Open();
                registros_modificados = comando.ExecuteNonQuery();
                conexion.Close();

                if (registros_modificados > 0)
                {
                    MessageBox.Show("La respuesta se ha modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("La respuesta no ha sido modificada.");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en modificar registros.");
            }
        }
        #endregion

        #region segmento de las ventana incoporar
        public static int Trastornos_por_seccion(String seccion) {
            List<String> lista = new List<String>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `trastornos` WHERE `seccion1` LIKE '" + ((seccion).ToLower()) + "'";
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
                return (lista.Count);
            }
            catch (MySqlException)
            {
                MessageBox.Show("A ocurrido un error al buscar los trastornos por sección en la Base de datos.");
            }
            return (lista.Count);

        }
        public static void Registrar_seccion(String seccion)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `secciones`(`seccion`) VALUES ('" + (seccion.ToLower()) + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("La seccion se ha incorporado con éxito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha registrado la sección, ya se encontraba en la Base de conocimiento");
            }
        }

        public static void Registrar_trastorno(String trastorno, String seccion1)
        {

            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `trastornos` (`trastorno`, `seccion1`) VALUES ('" + (trastorno.ToLower()) + "','" + (seccion1.ToLower()) + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El trastorno se ha registrado con éxito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha registrado el trastorno, ya se encontraba en la Base de conocimiento");
            }
        }

        public static Boolean Registrar_pregunta(String pregunta, String trastorno)
        {

            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `preguntas` (`pregunta`, `trastorno1`) VALUES ('" + (pregunta.ToLower()) + "','" + (trastorno.ToLower()) + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("La pregunta se ha registrado con éxito");
                return true;
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se registrado la pregunta, ya se encontraba en la Base de conocimiento");
            }
            return false;
        }

        public static Boolean Registrar_respuesta(String respuesta)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `alternativas` (`alternativa`) VALUES ('" + (respuesta.ToLower()) + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("La respuesta se ha registrado con éxito");
                return true;       
            }
            catch (MySqlException)
            {
                MessageBox.Show("La respuesta no se ha registrado");
            }
            return false;
        }

        public static void Registrar_rel_pregunta_alternativa(String pregunta, String respuesta,int es_respuesta)
        {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "INSERT INTO `rel_preguntas_alternativas` (`pregunta1`, `alternativa1`, `es_respuesta`) VALUES ('" + pregunta.ToLower() + "','" + respuesta.ToLower() + "','" + (es_respuesta) + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("La relación se ha registrado con éxito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha registrado la relación, esta ya se encontraba en la Base");
            }
        }
        #endregion

        #region Segmento Motor_de_inferencia
        public static int Total_preguntas(String trastorno)
        {
            List<String> lista = new List<String>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT `pregunta` FROM `preguntas` WHERE `trastorno1` LIKE '" + trastorno + "'";
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
                return (lista.Count);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener el listado ");
            }
            return (lista.Count);
        }
        public static int Total_acertadas(String trastorno)
        {
            List<float> lista = new List<float>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            Estudiante.Rut = "18.919.953-8"; //Eliminar cuando termine el desarrollo del software....
            consulta = "SELECT conocimiento FROM `rel_preguntas_usuarios` WHERE `conocimiento` >= 0.61 AND `pregunta1` IN (SELECT pregunta FROM `preguntas` WHERE `trastorno1` LIKE '" + trastorno + "') AND `rut1` LIKE '" + Estudiante.Rut + "'";
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    lista.Add(lectura.GetFloat(0));
                }
                conexion.Close();
                return (lista.Count);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (lista.Count);
        }
        public static List<String> Obtener_trastornos_de_seccion(String seccion) {
            List<String> lista = new List<String>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT `trastorno` FROM `trastornos` WHERE `seccion1` LIKE '" + seccion + "'";

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
                MessageBox.Show("No se ha podido obtener el listado de trastornos de la seccion");
            }
            return (lista);
        }
        public static List<String> Obtener_listado_de_trastornos()
        {
            List<String> lista = new List<String>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT `trastorno` FROM `trastornos`";

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
                MessageBox.Show("No se ha podido obtener el listado de trastornos");
            }
            return (lista);
        }
        public static List<String> Obtener_listado_de_secciones()
        {
            List<String> lista = new List<String>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT seccion FROM `secciones`";

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
                MessageBox.Show("No se ha podido obtener el listado de secciones.");
            }
            return (lista);
        }
        #endregion

        #region Segmento necesario para el agente
        public static String Obtener_seccion_trastorno(String trastorno) {
            String seccion = "No hay seccion para ese trastorno";
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT seccion1 FROM `trastornos` WHERE `trastorno` LIKE '"+trastorno+"'";
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    seccion = (lectura.GetString(0));
                }
                conexion.Close();
                return (seccion);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return seccion;
        }
        public static List<string> Buscar_preguntas(String trastorno)
        {
            List<string> lista = new List<string>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT pregunta FROM `preguntas` WHERE `trastorno1` LIKE '" + trastorno + "'";            
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
                return lista;
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (lista);
        }
        public static Boolean Correcta(String pregunta) {
            Boolean x = true;
            conexion = new MySqlConnection(datos_de_la_conexion);
            Usuario.Rut = "18.919.953-8";
            consulta = "SELECT * FROM `rel_preguntas_usuarios` WHERE `rut1` LIKE '" + Usuario.Rut+"' AND `pregunta1` LIKE '"+pregunta+"' AND `conocimiento` >= 0.61";
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    x = false;               
                }
                conexion.Close();
                return x;
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (x);
        }
        public static String Buscar_respuesta(string pregunta) {
            String respuesta = "";
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT `alternativa1` FROM `rel_preguntas_alternativas` WHERE `pregunta1` LIKE '" + pregunta+"'";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    respuesta = (lectura.GetString(0));
                }
                conexion.Close();
                return (respuesta);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return (respuesta);
        }
        public static List<String> Buscar_alternativas()
        {
            List<String> ok2 = new List<string>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `alternativas`";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    ok2.Add(lectura.GetString(0));
                }
                conexion.Close();
                return (ok2);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se han podido obtener las alternativas");
            }
            return (ok2);
        }
        public static void Contesto_usuario(String pregunta, float valor) {
            conexion = new MySqlConnection(datos_de_la_conexion);
            string fecha = (DateTime.Now.ToShortDateString());
            consulta = "INSERT INTO `rel_preguntas_usuarios` (`rut1`, `pregunta1`, `conocimiento`, `fecha`) VALUES ('"+Usuario.Rut+"', '"+pregunta+"', '"+valor+"', '"+fecha+"')";
            MySqlCommand comando = new MySqlCommand(consulta, conexion) { CommandTimeout = 60 };
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (MySqlException)
            {
                
            }
        }
        public static float Buscar_respuesta_usuario(String pregunta) {
            float valor=0;
            conexion = new MySqlConnection(datos_de_la_conexion);
            Usuario.Rut = "18.919.953-8";
            consulta = "SELECT conocimiento FROM `rel_preguntas_usuarios` WHERE `rut1` LIKE '"+Usuario.Rut+"' AND `pregunta1` LIKE '"+pregunta+"'";
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    valor = lectura.GetFloat(0);
                }
                conexion.Close();
                return (valor);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return (valor);

        }
        public static List<String> Obtener_preguntas_trastorno(string trastorno)
        {
            List<String> lista = new List<string>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT pregunta FROM `preguntas` WHERE `trastorno1` LIKE '" + trastorno + "'";

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
            return (null);
        }

        public static List<int> Obtener_trastornos_aprendidos(String trastorno)
        {
            List<int> lista = new List<int>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            //Debo buscar aquellas que esten por sobre el umbral aceptable 0.61 ya que esto es correcto
            Estudiante.Rut = "18.919.953-8";
            consulta = "SELECT codigo_pregunta1 FROM `relacion_preguntas_estudiantes` WHERE `estado_de_conocimiento` >= 0.61 AND `codigo_pregunta1` IN (SELECT codigo_pregunta FROM `preguntas` WHERE `trastorno1` LIKE '" + trastorno + "') AND `rut1` LIKE '" + Estudiante.Rut + "'";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    lista.Add(lectura.GetInt32(0));
                }
                conexion.Close();
                return (lista);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (lista);
        }

        public static List<string> Obtener_preguntas_trastorno_no_aprendidos(int codigos,String trastorno)
        {
            List<string> lista = new List<string>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            //Debo buscar aquellas que esten por sobre el umbral aceptable 0.61 ya que esto es correcto
            //SELECT pregunta FROM `preguntas` WHERE `codigo_pregunta` != (48) AND `trastorno1` LIKE 'trastorno de estrés postraumático'
            consulta = "SELECT pregunta FROM `preguntas` WHERE `codigo_pregunta` != '"+codigos+"' AND `trastorno1` LIKE '"+trastorno+"'";

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
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (lista);
        }

        public static String Buscar_respuesta_por_cod(int codigo) {
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `relacion_preguntas_alternativas` WHERE `codigo_pregunta1` ='"+codigo+"'";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    cadena_de_datos = new string[] { lectura.GetString(2) };
                }
                conexion.Close();

                return (cadena_de_datos[0]);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Este usuario no se encuentra en la base de datos");
            }
            return (null);
        }

         
        public static int Buscar_codigo_pregunta(String pregunta)
        {
            List<int> lista = new List<int>();
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT codigo_pregunta FROM `preguntas` WHERE `pregunta` LIKE '"+ pregunta+ "'";
            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    lista.Add(lectura.GetInt32(0));
                    return (lista[0]);
                }
                conexion.Close();
                return (0);

            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido obtener la cantidad de respuestas correctas");
            }
            return (0);
        }

        public static List<String> Obtener_Total_alternativas()
        {
            List<String> lista = new List<string>(); 
            conexion = new MySqlConnection(datos_de_la_conexion);
            consulta = "SELECT * FROM `alternativas`";

            try
            {
                conexion.Open();
                lectura = null;
                comando = new MySqlCommand(consulta, conexion);
                lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    lista.Add( lectura.GetString(0) );
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
        #endregion
    }
}