using Mentral.M;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.V
{
    public partial class Ventana_comenzar_estudio : Form
    {
        public Ventana_comenzar_estudio()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Segmento de los componentes
        private void Cantidad_trastornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seleccione.Text == "1") {
                
                trastorno_1.Visible = true;
                trastorno_2.Visible = false;
                trastorno_3.Visible = false;

                trastorno_1_label.Visible = true;
                trastorno_2_label.Visible = false;          
                trastorno_3_label.Visible = false;
            }
            if (seleccione.Text == "2")
            {         
                trastorno_1.Visible = true;
                trastorno_2.Visible = true;
                trastorno_3.Visible = false;

                trastorno_1_label.Visible = true;
                trastorno_2_label.Visible = true;
                trastorno_3_label.Visible = false;
            }
            if (seleccione.Text == "3")
            {
                trastorno_1.Visible = true;
                trastorno_2.Visible = true;
                trastorno_3.Visible = true;

                trastorno_1_label.Visible = true;
                trastorno_2_label.Visible = true;
                trastorno_3_label.Visible = true;
            }
        }

        private void Trastorno_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (trastorno_1.Text == trastorno_2.Text)
            {
                trastorno_2.Text = "";
            }
            if (trastorno_1.Text == trastorno_3.Text)
            {
                trastorno_3.Text = "";
            }
        }

        private void Trastorno_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trastorno_2.Text == trastorno_1.Text)
            {
                trastorno_1.Text = "";
            }
            if (trastorno_2.Text == trastorno_3.Text)
            {
                trastorno_3.Text = "";
            }
        }
        private void Trastorno_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trastorno_3.Text == trastorno_1.Text)
            {
                trastorno_1.Text = "";
            }
            if (trastorno_3.Text == trastorno_2.Text)
            {
                trastorno_2.Text = "";
            }
        }
        #endregion

        private void Ventana_comenzar_estudio_Load(object sender, EventArgs e)
        {
            List<string> lista = Conexion_a_la_bd.Obtener_listado_de_trastornos();
            foreach (String trastorno in lista)
            {
                trastorno_1.Items.Add(trastorno);
                trastorno_2.Items.Add(trastorno);
                trastorno_3.Items.Add(trastorno);
            }
        }
        private void Boton_guardar_Click(object sender, EventArgs e)
        {
            List<String> trastornos_seleccionados = new List<string>();
            if ((trastorno_1.Visible) && (trastorno_1.Text != "") || (trastorno_2.Visible) && (trastorno_2.Text != "") || (trastorno_3.Visible) && (trastorno_3.Text != ""))
            {
                #region Activar visibilidad
                cuadrado_1.Visible = true;
                cuadrado_2.Visible = true;
                cuadrado_3.Visible = true;
                pregunta_1.Visible = true;
                pregunta_2.Visible = true;
                pregunta_3.Visible = true;
                grupo_1.Visible = true;
                grupo_2.Visible = true;
                grupo_3.Visible = true;
                boton_entregar.Visible = true;
                panel2.Visible = true;
                #endregion

                #region Mandar a cache los trastornos
                if (trastorno_1.Visible && trastorno_1.Text != "") { trastornos_seleccionados.Add(trastorno_1.Text); }
                if (trastorno_2.Visible && trastorno_2.Text != "") { trastornos_seleccionados.Add(trastorno_2.Text); }
                if (trastorno_3.Visible && trastorno_3.Text != "") { trastornos_seleccionados.Add(trastorno_3.Text); }
                SeleccionCache.Trastornos_seleccionados = trastornos_seleccionados;
                #endregion

                Agente_Docente.tiempo_actual = 1;
                Agente_Docente.objetivo_actual = 1;
                Agente_Docente.Solicitar_inferencia();
                Agente_Docente.Mandar_preguntas();
                Boolean valido = true;
                String[] ok = new string[3];

                #region Generar preguntas segun objetivos
                if (Agente_Docente.objetivo_actual == 1)
                {

                    if (Agente_Docente.Bolsa_1.Count == 0)
                    {
                        valido = false;
                        Agente_Docente.objetivo_actual++;
                    }
                    if (Agente_Docente.Bolsa_1.Count == 1)
                    {
                        ok[0] = Agente_Docente.Bolsa_1[0];
                        Agente_Docente.Bolsa_1.Remove(ok[0]);
                    }
                    if (Agente_Docente.Bolsa_1.Count == 2)
                    {
                        ok[0] = Agente_Docente.Bolsa_1[0];
                        ok[1] = Agente_Docente.Bolsa_1[1];
                        Agente_Docente.Bolsa_1.Remove(ok[0]);
                        Agente_Docente.Bolsa_1.Remove(ok[1]);
                    }
                    if (Agente_Docente.Bolsa_1.Count > 3)
                    {
                        ok[0] = Agente_Docente.Bolsa_1[0];
                        ok[1] = Agente_Docente.Bolsa_1[1];
                        ok[2] = Agente_Docente.Bolsa_1[2];
                        Agente_Docente.Bolsa_1.Remove(ok[0]);
                        Agente_Docente.Bolsa_1.Remove(ok[1]);
                        Agente_Docente.Bolsa_1.Remove(ok[2]);
                    }
                }
                if (Agente_Docente.objetivo_actual == 2)
                {
                    if (Agente_Docente.Bolsa_2.Count == 0)
                    {
                        valido = false;
                        Agente_Docente.objetivo_actual++;
                    }
                    if (Agente_Docente.Bolsa_2.Count == 1)
                    {
                        ok[0] = Agente_Docente.Bolsa_2[0];
                        Agente_Docente.Bolsa_2.Remove(ok[0]);
                    }
                    if (Agente_Docente.Bolsa_2.Count == 2)
                    {
                        ok[0] = Agente_Docente.Bolsa_2[0];
                        ok[1] = Agente_Docente.Bolsa_2[1];
                        Agente_Docente.Bolsa_2.Remove(ok[0]);
                        Agente_Docente.Bolsa_2.Remove(ok[1]);
                    }
                    if (Agente_Docente.Bolsa_2.Count > 3)
                    {
                        ok[0] = Agente_Docente.Bolsa_2[0];
                        ok[1] = Agente_Docente.Bolsa_2[1];
                        ok[2] = Agente_Docente.Bolsa_2[2];
                        Agente_Docente.Bolsa_2.Remove(ok[0]);
                        Agente_Docente.Bolsa_2.Remove(ok[1]);
                        Agente_Docente.Bolsa_2.Remove(ok[2]);
                    }
                }
                if (Agente_Docente.objetivo_actual == 3)
                {
                    if (Agente_Docente.Bolsa_3.Count == 0)
                    {
                        valido = false;
                        panel2.Visible = false;
                    }
                    if (Agente_Docente.Bolsa_3.Count == 1)
                    {
                        ok[0] = Agente_Docente.Bolsa_3[0];
                        Agente_Docente.Bolsa_3.Remove(ok[0]);
                    }
                    if (Agente_Docente.Bolsa_3.Count == 2)
                    {
                        ok[0] = Agente_Docente.Bolsa_3[0];
                        ok[1] = Agente_Docente.Bolsa_3[1];
                        Agente_Docente.Bolsa_3.Remove(ok[0]);
                        Agente_Docente.Bolsa_3.Remove(ok[1]);
                    }
                    if (Agente_Docente.Bolsa_3.Count > 3)
                    {
                        ok[0] = Agente_Docente.Bolsa_3[0];
                        ok[1] = Agente_Docente.Bolsa_3[1];
                        ok[2] = Agente_Docente.Bolsa_3[2];
                        Agente_Docente.Bolsa_3.Remove(ok[0]);
                        Agente_Docente.Bolsa_3.Remove(ok[1]);
                        Agente_Docente.Bolsa_3.Remove(ok[2]);
                    }
                }
                #endregion

                Random rnd = new Random();


                if (valido == true)
                {
                    #region Grupo 1
                    pregunta_1.Text = ok[0];
                    if (rnd.Next(0, 3) == 0)
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_1_1.Text = Agente_Docente.Alternativas[0];
                        respuesta_1_2.Text = Agente_Docente.Alternativas[1];
                        respuesta_1_3.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_1_1.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_1_2.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_1_3.Text);
                    }
                    else
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_1_3.Text = Agente_Docente.Alternativas[0];
                        respuesta_1_1.Text = Agente_Docente.Alternativas[1];
                        respuesta_1_2.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_1_3.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_1_1.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_1_2.Text);
                    }
                    #endregion

                    #region Grupo 2
                    pregunta_2.Text = ok[1];
                    if (rnd.Next(0, 3) == 0)
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_2_1.Text = Agente_Docente.Alternativas[0];
                        respuesta_2_2.Text = Agente_Docente.Alternativas[1];
                        respuesta_2_3.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_2_1.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_2_2.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_2_3.Text);
                    }
                    else
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_2_3.Text = Agente_Docente.Alternativas[0];
                        respuesta_2_1.Text = Agente_Docente.Alternativas[1];
                        respuesta_2_2.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_2_3.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_2_1.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_2_2.Text);
                    }
                    #endregion

                    #region grupo 3
                    pregunta_3.Text = ok[2];
                    if (rnd.Next(0, 3) == 0)
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_3_1.Text = Agente_Docente.Alternativas[0];
                        respuesta_3_2.Text = Agente_Docente.Alternativas[1];
                        respuesta_3_3.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_3_1.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_3_2.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_3_3.Text);
                    }
                    else
                    {
                        Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                        respuesta_3_3.Text = Agente_Docente.Alternativas[0];
                        respuesta_3_2.Text = Agente_Docente.Alternativas[1];
                        respuesta_3_1.Text = Agente_Docente.Alternativas[2];
                        Agente_Docente.Alternativas.Remove(respuesta_3_3.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_3_2.Text);
                        Agente_Docente.Alternativas.Remove(respuesta_3_1.Text);
                    }
                    #endregion
                }
            }
            else {
                MessageBox.Show("Haga las correspondientes selecciones.");
            }
        }

        private void Actividad()
        {
            Boolean valido = true;
            Agente_Docente.Solicitar_inferencia();
            Agente_Docente.Mandar_preguntas();

            String[] ok = new string[3];

            #region Generar preguntas segun objetivos
            if (Agente_Docente.objetivo_actual == 1)
            {

                if (Agente_Docente.Bolsa_1.Count == 0)
                {
                    valido = false;
                    Agente_Docente.objetivo_actual++;
                }
                if (Agente_Docente.Bolsa_1.Count == 1)
                {
                    ok[0] = Agente_Docente.Bolsa_1[0];
                    Agente_Docente.Bolsa_1.Remove(ok[0]);
                }
                if (Agente_Docente.Bolsa_1.Count == 2)
                {
                    ok[0] = Agente_Docente.Bolsa_1[0];
                    ok[1] = Agente_Docente.Bolsa_1[1];
                    Agente_Docente.Bolsa_1.Remove(ok[0]);
                    Agente_Docente.Bolsa_1.Remove(ok[1]);
                }
                if (Agente_Docente.Bolsa_1.Count > 3)
                {
                    ok[0] = Agente_Docente.Bolsa_1[0];
                    ok[1] = Agente_Docente.Bolsa_1[1];
                    ok[2] = Agente_Docente.Bolsa_1[2];
                    Agente_Docente.Bolsa_1.Remove(ok[0]);
                    Agente_Docente.Bolsa_1.Remove(ok[1]);
                    Agente_Docente.Bolsa_1.Remove(ok[2]);
                }
            }
            if (Agente_Docente.objetivo_actual == 2) {
                if (Agente_Docente.Bolsa_2.Count == 0)
                {
                    valido = false;
                    Agente_Docente.objetivo_actual++;
                }
                if (Agente_Docente.Bolsa_2.Count == 1)
                {
                    ok[0] = Agente_Docente.Bolsa_2[0];
                    Agente_Docente.Bolsa_2.Remove(ok[0]);
                }
                if (Agente_Docente.Bolsa_2.Count == 2)
                {
                    ok[0] = Agente_Docente.Bolsa_2[0];
                    ok[1] = Agente_Docente.Bolsa_2[1];
                    Agente_Docente.Bolsa_2.Remove(ok[0]);
                    Agente_Docente.Bolsa_2.Remove(ok[1]);
                }
                if (Agente_Docente.Bolsa_2.Count > 3)
                {
                    ok[0] = Agente_Docente.Bolsa_2[0];
                    ok[1] = Agente_Docente.Bolsa_2[1];
                    ok[2] = Agente_Docente.Bolsa_2[2];
                    Agente_Docente.Bolsa_2.Remove(ok[0]);
                    Agente_Docente.Bolsa_2.Remove(ok[1]);
                    Agente_Docente.Bolsa_2.Remove(ok[2]);
                }
            }
            if (Agente_Docente.objetivo_actual == 3)
            {
                if (Agente_Docente.Bolsa_3.Count == 0)
                {
                    valido = false;
                    panel2.Visible = false;
                }
                if (Agente_Docente.Bolsa_3.Count == 1) {
                    ok[0] = Agente_Docente.Bolsa_3[0];
                    Agente_Docente.Bolsa_3.Remove(ok[0]);
                }
                if (Agente_Docente.Bolsa_3.Count == 2)
                {
                    ok[0] = Agente_Docente.Bolsa_3[0];
                    ok[1] = Agente_Docente.Bolsa_3[1];
                    Agente_Docente.Bolsa_3.Remove(ok[0]);
                    Agente_Docente.Bolsa_3.Remove(ok[1]);
                }
                if (Agente_Docente.Bolsa_3.Count > 3)
                {
                    ok[0] = Agente_Docente.Bolsa_3[0];
                    ok[1] = Agente_Docente.Bolsa_3[1];
                    ok[2] = Agente_Docente.Bolsa_3[2];
                    Agente_Docente.Bolsa_3.Remove(ok[0]);
                    Agente_Docente.Bolsa_3.Remove(ok[1]);
                    Agente_Docente.Bolsa_3.Remove(ok[2]);
                }               
            }
            #endregion

            Random rnd = new Random();

            if (valido == true) {

                #region Grupo 1
                pregunta_1.Text = ok[0];
                if (rnd.Next(0, 3) == 0)
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_1_1.Text = Agente_Docente.Alternativas[0];
                    respuesta_1_2.Text = Agente_Docente.Alternativas[1];
                    respuesta_1_3.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_1_1.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_1_2.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_1_3.Text);
                }
                else
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_1_3.Text = Agente_Docente.Alternativas[0];
                    respuesta_1_1.Text = Agente_Docente.Alternativas[1];
                    respuesta_1_2.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_1_3.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_1_1.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_1_2.Text);
                }
                #endregion

                #region Grupo 2
                pregunta_2.Text = ok[1];
                if (rnd.Next(0, 3) == 0)
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_2_1.Text = Agente_Docente.Alternativas[0];
                    respuesta_2_2.Text = Agente_Docente.Alternativas[1];
                    respuesta_2_3.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_2_1.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_2_2.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_2_3.Text);
                }
                else
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_2_3.Text = Agente_Docente.Alternativas[0];
                    respuesta_2_1.Text = Agente_Docente.Alternativas[1];
                    respuesta_2_2.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_2_3.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_2_1.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_2_2.Text);
                }
                #endregion

                #region grupo 3
                pregunta_3.Text = ok[2];
                if (rnd.Next(0, 3) == 0)
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_3_1.Text = Agente_Docente.Alternativas[0];
                    respuesta_3_2.Text = Agente_Docente.Alternativas[1];
                    respuesta_3_3.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_3_1.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_3_2.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_3_3.Text);
                }
                else
                {
                    Agente_Docente.Mandar_alternativas(pregunta_1.Text);
                    respuesta_3_3.Text = Agente_Docente.Alternativas[0];
                    respuesta_3_2.Text = Agente_Docente.Alternativas[1];
                    respuesta_3_1.Text = Agente_Docente.Alternativas[2];
                    Agente_Docente.Alternativas.Remove(respuesta_3_3.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_3_2.Text);
                    Agente_Docente.Alternativas.Remove(respuesta_3_1.Text);
                }
                #endregion
            }

        }

        private void boton_entregar_Click(object sender, EventArgs e)
        {
            Agente_Docente.tiempo_actual ++;
            if (respuesta_1_1.Checked) { Agente_Docente.Evaluar(respuesta_1_1.Text, pregunta_1.Text); }
            if (respuesta_1_2.Checked) { Agente_Docente.Evaluar(respuesta_1_2.Text, pregunta_1.Text); }
            if (respuesta_1_3.Checked) { Agente_Docente.Evaluar(respuesta_1_3.Text, pregunta_1.Text); }
            if (respuesta_2_1.Checked) { Agente_Docente.Evaluar(respuesta_2_1.Text, pregunta_2.Text); }
            if (respuesta_2_2.Checked) { Agente_Docente.Evaluar(respuesta_2_2.Text, pregunta_2.Text); }
            if (respuesta_2_3.Checked) { Agente_Docente.Evaluar(respuesta_2_3.Text, pregunta_2.Text); }
            if (respuesta_3_1.Checked) { Agente_Docente.Evaluar(respuesta_3_1.Text, pregunta_3.Text); }
            if (respuesta_3_2.Checked) { Agente_Docente.Evaluar(respuesta_3_2.Text, pregunta_3.Text); }
            if (respuesta_3_3.Checked) { Agente_Docente.Evaluar(respuesta_3_3.Text, pregunta_3.Text); }
            Actividad();

        }

        private void boton_cerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
