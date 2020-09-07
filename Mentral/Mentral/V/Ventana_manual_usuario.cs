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
    public partial class Ventana_manual_usuario : Form
    {
        public Ventana_manual_usuario()
        {
            InitializeComponent();
        }

        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
