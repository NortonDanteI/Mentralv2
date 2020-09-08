using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.M;

namespace Mentral.M
{
    class Agente_Docente
    {
        #region atributos
        private static string trastorno_a_trabajar;
        private static int respuestas_correctas = 0;
        private static int total_preguntas_realizadas=0;
        private static List<string> preguntas = new List<string>();
        private static List<string> alternativas = new List<string>();
        private static float rendimiento = 0;

        public static List<String> bolsa_1 = new List<string>();
        public static List<String> bolsa_2 = new List<string>();
        public static List<String> bolsa_3 = new List<string>();
        public static List<String> bolsa_4 = new List<string>();
        #endregion

        #region propiedades
        public static string Trastorno_a_trabajar { get => trastorno_a_trabajar; set => trastorno_a_trabajar = value; }
        public static int tiempo_actual { get; set; }
        public static int objetivo_actual { get; set; }
        public static int Respuestas_correctas { get => respuestas_correctas; set => respuestas_correctas = value; }
        public static int Total_de_preguntas_realizadas { get => total_preguntas_realizadas; set => total_preguntas_realizadas = value; }
        public static float Rendimiento { get => rendimiento; set => rendimiento = value; }
        public static List<String> Bolsa_1 { get => bolsa_1; set => bolsa_1 = value; }
        public static List<String> Bolsa_2 { get => bolsa_2; set => bolsa_2 = value; }
        public static List<String> Bolsa_3 { get => bolsa_3; set => bolsa_3 = value; }
        public static List<String> Bolsa_4 { get => bolsa_4; set => bolsa_4 = value; }
        public static List<String> Alternativas { get => alternativas; set => alternativas = value; }
        #endregion

        #region  Funciones de rendimiento y conocimiento
        public static void funcion_de_rendimiento()
        {
            float x;
            x = ((float) Respuestas_correctas / (float) Total_de_preguntas_realizadas);
            Rendimiento = x;
        }
        public static float funcion_conocimiento(float valor,int acerto)
        {
            float x;
            if (acerto == 1) {
                valor += (float)(0.6);
                if (valor>1) { return 1; }
                return valor;
            }
            if (acerto== 0) {
                valor -= (float)(0.59);
                if (valor < 0) { return 0; }
                return valor;
            }
            return 0;
        }
        #endregion

        #region Verbos por nivel
        public static Boolean Verbos_nivel_1(String pregunta)
        {
            List<String> verbos_nivel_1 = new List<string>();
            verbos_nivel_1.Add("definir");
            verbos_nivel_1.Add("defina");
            verbos_nivel_1.Add("describir");
            verbos_nivel_1.Add("decriba");
            verbos_nivel_1.Add("nombrar");
            verbos_nivel_1.Add("nombre");
            verbos_nivel_1.Add("identificar");
            verbos_nivel_1.Add("identifique");
            verbos_nivel_1.Add("reconozca");
            verbos_nivel_1.Add("diga");
            verbos_nivel_1.Add("enumere");
            verbos_nivel_1.Add("qué es");
            verbos_nivel_1.Add("cuál es");
            verbos_nivel_1.Add("cual es");
            verbos_nivel_1.Add("cuando");
            foreach (var dat in verbos_nivel_1)
            {
                if (pregunta.Contains(dat)) { return true; }
            }
            return false;
        }
        public static Boolean Verbos_nivel_2(String pregunta)
        {
            List<String> verbos_nivel_2 = new List<string>();
            verbos_nivel_2.Add("infiera");
            verbos_nivel_2.Add("categorice");
            verbos_nivel_2.Add("construya");
            verbos_nivel_2.Add("que significa");
            verbos_nivel_2.Add("comparación");
            verbos_nivel_2.Add("relaciona");
            verbos_nivel_2.Add("que afirmación es");
            verbos_nivel_2.Add("resuma");
            verbos_nivel_2.Add("resumiria");
            verbos_nivel_2.Add("muestre");
            verbos_nivel_2.Add("qué es");
            verbos_nivel_2.Add("compara");
            verbos_nivel_2.Add("cómo clasificarias");
            verbos_nivel_2.Add("cómo afecta");
            verbos_nivel_2.Add("por qué");
            verbos_nivel_2.Add("porque");
            verbos_nivel_2.Add("explique");
            verbos_nivel_2.Add("cuales");

            foreach (var dat in verbos_nivel_2)
            {
                if (pregunta.Contains(dat)) { return true; }
            }
            return false;
        }
        public static Boolean Verbos_nivel_3(String pregunta)
        {
            List<String> verbos_nivel_3 = new List<string>();
            verbos_nivel_3.Add("ejemplifique");
            verbos_nivel_3.Add("que harias");
            verbos_nivel_3.Add("ejemplos");
            verbos_nivel_3.Add("ejemplo");
            verbos_nivel_3.Add("interpretaria");
            verbos_nivel_3.Add("interprete");
            verbos_nivel_3.Add("aplique");
            verbos_nivel_3.Add("cómo clasificaria");
            verbos_nivel_3.Add("implementaria");
            verbos_nivel_3.Add("aplicarias");
            verbos_nivel_3.Add("aplicaria");
            verbos_nivel_3.Add("aplicarías");
            verbos_nivel_3.Add("determine");
            verbos_nivel_3.Add("emplearia");
            verbos_nivel_3.Add("cómo utilizaria");
            verbos_nivel_3.Add("revise");
            foreach (var dat in verbos_nivel_3)
            {
                if (pregunta.Contains(dat)) { return true; }
            }
            return false;
        }
        public static Boolean Verbos_nivel_4(String pregunta)
        {
            List<String> verbos_nivel_4 = new List<string>();
            verbos_nivel_4.Add("cuáles son las partes");
            verbos_nivel_4.Add("analice");
            verbos_nivel_4.Add("a que categoría");
            verbos_nivel_4.Add("distinga");
            verbos_nivel_4.Add("causa");
            verbos_nivel_4.Add("motivo");
            verbos_nivel_4.Add("determine");
            verbos_nivel_4.Add("descomponga");
            verbos_nivel_4.Add("interpretaria");
            verbos_nivel_4.Add("simplificaria");
            verbos_nivel_4.Add("deconstruiria");
            verbos_nivel_4.Add("como se relaciona");
            verbos_nivel_4.Add("concluya");
            verbos_nivel_4.Add("que conclusiones");

            foreach (var dat in verbos_nivel_4)
            {
                if (pregunta.Contains(dat)) { return true; }
            }
            return false;
        }
        #endregion

        #region Para obtener el trastorno a trabajar
        public static void Solicitar_inferencia()
        {
            Trastorno_a_trabajar = Motor_de_inferencia.Inferir();
        }
        #endregion
        public static Boolean Valida(String pregunta)
        {
            return (Conexion_a_la_bd.Correcta(pregunta));
        }

        #region Código para determinar complejidad de las preguntas
        public static int Obtener_complejidad(String pregunta)
        {
            int nivel = 1;
            if (Verbos_nivel_1(pregunta))
            {
                nivel = 1;
            }
            if (Verbos_nivel_2(pregunta))
            {
                nivel = 2;
            }
            if (Verbos_nivel_3(pregunta))
            {
                nivel = 3;
            }
            if (Verbos_nivel_4(pregunta))
            {
                nivel = 4;
            }
            return nivel;
        }
        #endregion

        #region Segmento para crear las bolsas de preguntas por nivel
        public static void Crear_bolsa()
        {
            preguntas = Conexion_a_la_bd.Buscar_preguntas(Trastorno_a_trabajar);
            foreach (var pregunta in preguntas) {
                if (Valida(pregunta)) {
                    if (Obtener_complejidad(pregunta) == 1)
                    {
                        Bolsa_1.Add(pregunta);
                    }
                    if (Obtener_complejidad(pregunta) == 2)
                    {
                        Bolsa_2.Add(pregunta);
                    }
                    if (Obtener_complejidad(pregunta) == 3)
                    {
                        Bolsa_3.Add(pregunta);
                    }
                }
            }
        }
        #endregion

        #region Segmento para mandar preguntas
        public static List<String> Mandar_preguntas()
        {
            Crear_bolsa();

            if (objetivo_actual == 1) {
                return Bolsa_1;
            }
            if (objetivo_actual == 2)
            {
                return Bolsa_2;
            }
            if (objetivo_actual == 3)
            {
                return Bolsa_3;
            }
            if (objetivo_actual == 4)
            {
                return Bolsa_4;
            }
            return null;
        }
        #endregion
        public static List<String> Mandar_alternativas(String pregunta)
        {
            Alternativas.Add(Conexion_a_la_bd.Buscar_respuesta(pregunta));//1
            List<string> alter = new List<string>();
            alter = Conexion_a_la_bd.Buscar_alternativas();
            Random rnd = new Random();
            int num;
            while (Alternativas.Count != 3) {
                num = rnd.Next(0, (alter.Count));
                if (Alternativas[0] != alter[num]) {
                    Alternativas.Add(alter[num]);
                }
            }
            return Alternativas;
        }

        public static void Decidir() {
            if (Rendimiento>0.08 && tiempo_actual>3) {
                objetivo_actual++;
                tiempo_actual = 0;
            }
        }

        #region Segmento para evaluar las respuestas
        public static void Evaluar(String respuesta, String pregunta) {
            total_preguntas_realizadas++;
            if (respuesta == Conexion_a_la_bd.Buscar_respuesta(pregunta))
            {
                float ok2=(float)Conexion_a_la_bd.Buscar_respuesta_usuario(pregunta);
                respuestas_correctas++;
                Conexion_a_la_bd.Contesto_usuario(pregunta,funcion_conocimiento(ok2,1));
            }
            else {
                float ok2 = (float)Conexion_a_la_bd.Buscar_respuesta_usuario(pregunta);
                Conexion_a_la_bd.Contesto_usuario(pregunta, funcion_conocimiento(ok2,0));
            }
            funcion_de_rendimiento();
            Decidir();
        }
        #endregion
    }
}
//\r\