using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.M
{
    class Docente : Usuario
    {
        //atributos
        private string titulo;

        public string Titulo { get => titulo; set => titulo = value; }

        //constructor
        public Docente()
        {

        }
        //metodos
        public void Ver_desempeño_estudiante()
        {
            MessageBox.Show("metodo utilizado para ver el desempeño de un estudiante");
        }
        public void Generar_cuestionario()
        {
            MessageBox.Show("metodo utilizado para generar cuestionarios");
        }
    }
}
