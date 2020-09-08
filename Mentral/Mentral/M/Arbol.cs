using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Mentral.C;
using Mentral.M;

namespace Mentral.M
{
    class Arbol
    {
        #region atributos
        private static Nodo raiz_static;
        private Nodo raiz;
        private Nodo trabajo;
        private int nivel = 0;
        private String etiqueta ="";
        #endregion
        public static Nodo Raiz_statica { get => raiz_static; set => raiz_static = value; }
        public Arbol()
        {
            raiz = new Nodo();
        }
        public Nodo Insertar(String nombre,Nodo nodo) {
            //Si no hay nodo donde insertar, tomamos como si fuera la raiz
            if (nodo==null) {
                raiz = new Nodo();
                raiz.Nombre = nombre;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            //Si no tiene hijo , insertamos el dato como hijo
            if (nodo.Hijo == null)
            {
                Nodo temp = new Nodo();
                temp.Nombre = nombre;
                nodo.Hijo = temp;
                return temp;
            }
            //Si tiene hijo, insertamos como hermano
            else {
                trabajo = nodo.Hijo;
                //ultimo hermano
                while (trabajo.Hermano!=null) {
                    trabajo = trabajo.Hermano;
                }
                Nodo temp = new Nodo();
                temp.Nombre = nombre;
                trabajo.Hermano = temp;
                return temp;          
            }    
        }
        public void TransversaPost(Nodo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            if (nodo.Hijo != null)
            {
                nivel++;
                TransversaPost(nodo.Hijo);
                nivel--;
            }
            if (nodo.Hermano != null)
            {
                TransversaPost(nodo.Hermano);
            }
            if (nivel == 2)
            {
                nodo.Etiquetas = Fuzzy.Fuzificar(nodo.Nombre);
            }
            if (nivel == 1) {
                nodo.Etiquetas = Fuzzy.Inferir_nivel_1(nodo);
            }
            if (nivel == 0)
            {
                nodo.Etiquetas = Fuzzy.Inferir_nivel_0(nodo);
                //Arbol.raiz_static = nodo;
            }
        }
        public void TransversaPre(Nodo nodo) {
            if (nodo == null) {
                return;
            }
            MessageBox.Show("Nivel: " + nivel + " |Nombre del nodo: " + nodo.Nombre +"| "+
                nodo.Etiquetas[0].Item1 + ": " + nodo.Etiquetas[0].Item2+"| "+
                nodo.Etiquetas[1].Item1 + ": " + nodo.Etiquetas[1].Item2+"| "+
                nodo.Etiquetas[2].Item1 + ": " + nodo.Etiquetas[2].Item2 + "| " +
                nodo.Etiquetas[3].Item1 + ": " + nodo.Etiquetas[3].Item2 + "| " +
                nodo.Etiquetas[4].Item1 + ": " + nodo.Etiquetas[4].Item2);
            
            if (nodo.Hijo != null) {
                nivel++;
                TransversaPre(nodo.Hijo);
                nivel--;
            }
            if (nodo.Hermano != null) {
                TransversaPre(nodo.Hermano);
            }
        }
        public Nodo Buscar(String seccion, Nodo nodo) {
            Nodo encontrado = null;
            if (nodo == null) { return encontrado; }
            if (nodo.Nombre.CompareTo(seccion) == 0) {
                encontrado = nodo;
                return encontrado;
            }
            if (nodo.Hijo != null) {
                encontrado = Buscar(seccion, nodo.Hijo);
                if (encontrado != null) { return encontrado; }
            }
            if (nodo.Hermano != null) {
                encontrado = Buscar(seccion, nodo.Hermano);
                if (encontrado!=null) { return encontrado; }
            }
            return encontrado;
        }
    }
}
