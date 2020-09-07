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
    public partial class Ventana_configuracion : Form
    {
        public Ventana_configuracion()
        {
            InitializeComponent();
        }
        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox_trastornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_trastornos.Text == comboBox_trastornos_2.Text) {
                comboBox_trastornos_2.Text = "";
            }
            if (comboBox_trastornos.Text == comboBox_trastornos_3.Text)
            {
                comboBox_trastornos_3.Text = "";
            }
        }

        private void ComboBox_trastornos_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_trastornos_2.Text == comboBox_trastornos.Text) {
                comboBox_trastornos.Text = "";
            }
            if(comboBox_trastornos_2.Text == comboBox_trastornos_3.Text)
            {
                comboBox_trastornos_3.Text = "";
            }
        }

        private void ComboBox_trastornos_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_trastornos_3.Text == comboBox_trastornos.Text) {
                comboBox_trastornos.Text = "";
            }
            if(comboBox_trastornos_3.Text == comboBox_trastornos_2.Text)
            {
               comboBox_trastornos_2.Text = "";
            }
        }

        private void Boton_guardar_Click(object sender, EventArgs e)
        {
            if (comboBox_umbral.Text != "" && comboBox_trastornos.Text != "" && comboBox_trastornos_2.Text != "" && comboBox_trastornos_3.Text != "")
            {
                ConfiguracionCache.Umbral = Int32.Parse(comboBox_umbral.Text);
                ConfiguracionCache.trastorno_1 = comboBox_trastornos.Text;
                ConfiguracionCache.trastorno_2 = comboBox_trastornos_2.Text;
                ConfiguracionCache.trastorno_3 = comboBox_trastornos_3.Text;
                MessageBox.Show("Configuracion guardada");
            }
            else {
                MessageBox.Show("Seleccione todo");
            }
            
        }

        private void ComboBox_trastornos_Enter(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista = Conexion_a_la_bd.Obtener_listado_de_trastornos();
            if (comboBox_trastornos.Items.Count < 1) {
                foreach (String trastorno in lista)
                {
                    comboBox_trastornos.Items.Add(trastorno);
                }
            }
        }

        private void ComboBox_trastornos_2_Enter(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista = Conexion_a_la_bd.Obtener_listado_de_trastornos();

            if (comboBox_trastornos_2.Items.Count < 1)
            {
                foreach (String trastorno in lista)
                {
                    comboBox_trastornos_2.Items.Add(trastorno);
                }
            }
        }

        private void ComboBox_trastornos_3_Enter(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista = Conexion_a_la_bd.Obtener_listado_de_trastornos();

            if (comboBox_trastornos_3.Items.Count < 1)
            {
                foreach (String trastorno in lista)
                {
                    comboBox_trastornos_3.Items.Add(trastorno);
                }
            }
        }

        private void Ventana_configuracion_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista = Conexion_a_la_bd.Obtener_listado_de_trastornos();
            foreach (String trastorno in lista)
            {
                comboBox_trastornos.Items.Add(trastorno);
                comboBox_trastornos_2.Items.Add(trastorno);
                comboBox_trastornos_3.Items.Add(trastorno);
            }
        }
    }
}