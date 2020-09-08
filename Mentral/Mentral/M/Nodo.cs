using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentral.M
{
    class Nodo
    {
        private String nombre;
        private (String, float)[] etiquetas;
        private Nodo hijo;
        private Nodo hermano;

        public String Nombre { get => nombre; set => nombre = value; }
        public (String, float)[] Etiquetas { get => etiquetas; set => etiquetas= value; }
        public Nodo Hijo { get => hijo; set => hijo = value; }
        public Nodo Hermano { get => hermano; set => hermano = value; }

        public Nodo() {
            nombre = "";
            etiquetas = new(String,float)[5];
            hijo= null;
            hermano = null;
        }
    }
}
