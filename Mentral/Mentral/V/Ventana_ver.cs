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
    public partial class Ventana_ver : Form
    {
        public Ventana_ver()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ventana_ver_Load(object sender, EventArgs e)
        {
            secciones.DataSource = Conexion_a_la_bd.Obtener_data_secciones_de_conocimiento();
            trastornos.DataSource = Conexion_a_la_bd.Obtener_data_trastornos_mentales();
            preguntas.DataSource = Conexion_a_la_bd.Obtener_data_preguntas();
            alternativas.DataSource = Conexion_a_la_bd. Obtener_data_alternativas();
            rel_preguntas_alternativas.DataSource = Conexion_a_la_bd.Obtener_data_relacion();
        }
    }
}
