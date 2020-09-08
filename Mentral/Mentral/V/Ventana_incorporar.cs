using Mentral.C;
using Mentral.M;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.V
{
    public partial class Ventana_incorporar : Form
    {
        public Ventana_incorporar()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incorporar_Click(object sender, EventArgs e)
        {
            int es_respuesta = 0;
            if (correcta.Checked || incorrecta.Checked) {
                Experto experto = new Experto();
                if (correcta.Checked) { es_respuesta = 1; }
                if (incorrecta.Checked) { es_respuesta = 2; }
                experto.Incorporar_data(seccion.Text, trastorno.Text, pregunta.Text, respuesta.Text, es_respuesta);
            } 
        }
        private void Seccion_Enter(object sender, EventArgs e)
        {
            if (seccion.Text == "Ingrese sección")
            {
                seccion.TextAlign = HorizontalAlignment.Left;
                seccion.Text = "";
                seccion.ForeColor = Color.Black;
            }
        }
        private void Seccion_Leave(object sender, EventArgs e)
        {
            if (seccion.Text == "")
            {
                seccion.Text = "Ingrese sección";
                seccion.ForeColor = Color.AliceBlue;
                seccion.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Trastorno_Enter(object sender, EventArgs e)
        {
            if (trastorno.Text == "Ingrese trastorno")
            {
                trastorno.TextAlign = HorizontalAlignment.Left;
                trastorno.Text = "";
                trastorno.ForeColor = Color.Black;
            }
        }

        private void Trastorno_Leave(object sender, EventArgs e)
        {
            if (trastorno.Text == "")
            {          
                trastorno.Text = "Ingrese trastorno";
                trastorno.ForeColor = Color.AliceBlue;
                trastorno.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Pregunta_Enter(object sender, EventArgs e)
        {
            if (pregunta.Text == "Ingrese pregunta")
            {
                pregunta.TextAlign = HorizontalAlignment.Left;
                pregunta.Text = "";
                pregunta.ForeColor = Color.Black;
            }
        }

        private void Pregunta_Leave(object sender, EventArgs e)
        {
            if (pregunta.Text == "")
            {
                pregunta.TextAlign = HorizontalAlignment.Center;
                pregunta.Text = "Ingrese pregunta";
                pregunta.ForeColor = Color.AliceBlue;
            }
        }

        private void Respuesta_Enter(object sender, EventArgs e)
        {
            if (respuesta.Text == "Alternativa")
            {
                respuesta.TextAlign = HorizontalAlignment.Left;
                respuesta.Text = "";
                respuesta.ForeColor = Color.Black;
            }
        }

        private void Respuesta_Leave(object sender, EventArgs e)
        {
            if (respuesta.Text == "")
            {
                respuesta.TextAlign = HorizontalAlignment.Center;
                respuesta.Text = "Alternativa";
                respuesta.ForeColor = Color.AliceBlue;
            }
        }
    }
}
