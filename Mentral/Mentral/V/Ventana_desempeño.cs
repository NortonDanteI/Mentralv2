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
    public partial class Ventana_desempeño : Form
    {
        int nivel = 0;
        String conocimiento_general_texto="";
        String conocimiento_secciones_texto="";
        String conocimiento_trastornos_texto="";
        public Ventana_desempeño()
        {
            InitializeComponent();
        }
        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TransversaPre(Nodo nodo)
        {           
            if (nodo == null)
            {
                return;
            }
            if (nivel == 0) {
                conocimiento_general_texto += (nodo.Nombre + Environment.NewLine +
                                               nodo.Etiquetas[0].Item1 + ": " + nodo.Etiquetas[0].Item2 + Environment.NewLine +
                                               nodo.Etiquetas[1].Item1 + ": " + nodo.Etiquetas[1].Item2 + Environment.NewLine +
                                               nodo.Etiquetas[2].Item1 + ": " + nodo.Etiquetas[2].Item2 + Environment.NewLine +
                                               nodo.Etiquetas[3].Item1 + ": " + nodo.Etiquetas[3].Item2 + Environment.NewLine +
                                               nodo.Etiquetas[4].Item1 + ": " + nodo.Etiquetas[4].Item2 + Environment.NewLine);
            }
            if (nivel == 1)
            {
                conocimiento_secciones_texto += (nodo.Nombre + Environment.NewLine +
                                           nodo.Etiquetas[0].Item1 + ": " + nodo.Etiquetas[0].Item2 + Environment.NewLine +
                                           nodo.Etiquetas[1].Item1 + ": " + nodo.Etiquetas[1].Item2 + Environment.NewLine +
                                           nodo.Etiquetas[2].Item1 + ": " + nodo.Etiquetas[2].Item2 + Environment.NewLine +
                                           nodo.Etiquetas[3].Item1 + ": " + nodo.Etiquetas[3].Item2 + Environment.NewLine +
                                           nodo.Etiquetas[4].Item1 + ": " + nodo.Etiquetas[4].Item2 + Environment.NewLine);
            }
            if (nivel == 2)
            {
                conocimiento_trastornos_texto += (nodo.Nombre + Environment.NewLine + 
                                                  nodo.Etiquetas[0].Item1 + ": " + nodo.Etiquetas[0].Item2 + Environment.NewLine +
                                                  nodo.Etiquetas[1].Item1 + ": " + nodo.Etiquetas[1].Item2 + Environment.NewLine +
                                                  nodo.Etiquetas[2].Item1 + ": " + nodo.Etiquetas[2].Item2 + Environment.NewLine +
                                                  nodo.Etiquetas[3].Item1 + ": " + nodo.Etiquetas[3].Item2 + Environment.NewLine +
                                                  nodo.Etiquetas[4].Item1 + ": " + nodo.Etiquetas[4].Item2 + Environment.NewLine);
            }

            if (nodo.Hijo != null)
            {
                nivel++;
                TransversaPre(nodo.Hijo);
                nivel--;
            }
            if (nodo.Hermano != null)
            {
                TransversaPre(nodo.Hermano);
            }
        }
        
        private void Ventana_desempeño_Load(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();         
            TransversaPre(Arbol.Raiz_statica);
            conocimiento_general.Text = conocimiento_general_texto;
            conocimiento_secciones.Text = conocimiento_secciones_texto;
            conocimiento_trastornos.Text = conocimiento_trastornos_texto;
        }
    }
}
