using System;
using System.Drawing;
using System.Windows.Forms;
using Mentral.M;

namespace Mentral.V
{
    public partial class Ventana_modificar : Form
    {
        public Ventana_modificar()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seccion_a_modificar_Leave(object sender, EventArgs e)
        {
            if (seccion_a_modificar.Text == "")
            {
                seccion_a_modificar.Text = "Ingrese sección a modificar";
                seccion_a_modificar.ForeColor = Color.AliceBlue;
                seccion_a_modificar.TextAlign = HorizontalAlignment.Center;
            }
        }
        private void Trastorno_a_modificar_Leave(object sender, EventArgs e)
        {
            if (trastorno_a_modificar.Text == "")
            {
                trastorno_a_modificar.Text = "Ingrese trastorno a modificar";
                trastorno_a_modificar.ForeColor = Color.AliceBlue;
                trastorno_a_modificar.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Pregunta_a_modificar_Leave(object sender, EventArgs e)
        {
            if (pregunta_a_modificar.Text == "")
            {
                pregunta_a_modificar.Text = "Ingrese pregunta a modificar";
                pregunta_a_modificar.ForeColor = Color.AliceBlue;
                pregunta_a_modificar.TextAlign = HorizontalAlignment.Center;
            }
        }
        private void Respuesta_a_modificar_Leave(object sender, EventArgs e)
        {
            if (respuesta_a_modificar.Text == "")
            {
                respuesta_a_modificar.Text = "Ingrese respuesta a modificar";
                respuesta_a_modificar.ForeColor = Color.AliceBlue;
                respuesta_a_modificar.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Trastorno_Leave(object sender, EventArgs e)
        {
            if (trastorno.Text == "")
            {
                trastorno.Text = "Ingrese el cambio de trastorno";
                trastorno.ForeColor = Color.AliceBlue;
                trastorno.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Pregunta_Leave(object sender, EventArgs e)
        {
            if (pregunta.Text == "")
            {
                pregunta.Text = "Ingrese el cambio de pregunta";
                pregunta.ForeColor = Color.AliceBlue;
                pregunta.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void Respuesta_Leave(object sender, EventArgs e)
        {
            if (respuesta.Text == "")
            {
                respuesta.Text = "Ingrese el cambio de respuesta";
                respuesta.ForeColor = Color.AliceBlue;
                respuesta.TextAlign = HorizontalAlignment.Center;
            }
        }
        private void Seccion_Leave(object sender, EventArgs e)
        {
            if (seccion.Text == "")
            {
                seccion.Text = "Ingrese el cambio de sección";
                seccion.ForeColor = Color.AliceBlue;
                seccion.TextAlign = HorizontalAlignment.Center;
            }
        }
        //Enters
        private void Seccion_a_modificar_Enter(object sender, EventArgs e)
        {
            if (seccion_a_modificar.Text == "Ingrese sección a modificar")
            {
                seccion_a_modificar.Text = "";
                seccion_a_modificar.ForeColor = Color.Black;
                seccion_a_modificar.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void Trastorno_a_modificar_Enter(object sender, EventArgs e)
        {
            if (trastorno_a_modificar.Text == "Ingrese trastorno a modificar")
            {
                trastorno_a_modificar.Text = "";
                trastorno_a_modificar.ForeColor = Color.Black;
                trastorno_a_modificar.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Pregunta_a_modificar_Enter(object sender, EventArgs e)
        {
            if (pregunta_a_modificar.Text == "Ingrese pregunta a modificar")
            {
                pregunta_a_modificar.Text = "";
                pregunta_a_modificar.ForeColor = Color.Black;
                pregunta_a_modificar.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Respuesta_a_modificar_Enter(object sender, EventArgs e)
        {
            if (respuesta_a_modificar.Text == "Ingrese respuesta a modificar")
            {
                respuesta_a_modificar.Text = "";
                respuesta_a_modificar.ForeColor = Color.Black;
                respuesta_a_modificar.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void Seccion_Enter(object sender, EventArgs e)
        {
            if (seccion.Text == "Ingrese el cambio de sección")
            {
                seccion.Text = "";
                seccion.ForeColor = Color.Black;
                seccion.TextAlign = HorizontalAlignment.Left;
            }
        }
        private void Trastorno_Enter(object sender, EventArgs e)
        {
            if (trastorno.Text == "Ingrese el cambio de trastorno")
            {
                trastorno.Text = "";
                trastorno.ForeColor = Color.Black;
                trastorno.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Pregunta_Enter(object sender, EventArgs e)
        {
            if (pregunta.Text == "Ingrese el cambio de pregunta")
            {
                pregunta.Text = "";
                pregunta.ForeColor = Color.Black;
                pregunta.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Respuesta_Enter(object sender, EventArgs e)
        {
            if (respuesta.Text == "Ingrese el cambio de respuesta")
            {
                respuesta.Text = "";
                respuesta.ForeColor = Color.Black;
                respuesta.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Experto experto = new Experto();
            experto.Modificar_data(((seccion_a_modificar.Text).ToLower()),
                                   ((seccion.Text).ToLower()),
                                   ((trastorno_a_modificar.Text).ToLower()),
                                   ((trastorno.Text).ToLower()),
                                   ((pregunta_a_modificar.Text).ToLower()),
                                   ((pregunta.Text).ToLower()),
                                   ((respuesta_a_modificar.Text).ToLower()),
                                   ((respuesta.Text).ToLower())
                                   ); ;
        }
    }
}
