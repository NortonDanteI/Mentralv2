using Mentral.C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.M
{
    class Motor_de_inferencia
    {
        private static List<String> secciones;
        private static List<String> trastornos;
        public static void Generar_estructura(){
            Arbol arbol = new Arbol();
            //nivel 0
            Nodo raiz = arbol.Insertar("Conocimiento general", null);
            Nodo nivel_1;
            //nivel 1
            secciones = Conexion_a_la_bd.Obtener_listado_de_secciones();
            foreach (var seccion_ in secciones)
            {
                nivel_1 = arbol.Insertar(seccion_, raiz);
                //nivel 2
                trastornos = Conexion_a_la_bd.Obtener_trastornos_de_seccion(seccion_);
                foreach (var trastorno_ in trastornos)
                {
                    arbol.Insertar(trastorno_, nivel_1);
                }
            }
            Arbol.Raiz_statica = raiz;
        }
        public static void Fuzzificar_estructura()
        {
            Arbol arbol = new Arbol();
            arbol.TransversaPost(Arbol.Raiz_statica);
        }
        public static int Mayor_pertenencia(Nodo nodo) {
            int mayor=0;
            for (int b = 0; b< (nodo.Etiquetas.Length - 1);b++) {
                if (nodo.Etiquetas[b].Item2<nodo.Etiquetas[b+1].Item2) {
                    mayor = b + 1; 
                }
            }
            return mayor;
        
        }
        public static String Inferir() {

            #region variables necesarias para inferir
            List<string> trastorno_lista = new List<string>();
            trastorno_lista = SeleccionCache.Trastornos_seleccionados;
            String seccion;

            int indice_pertenencia;
            Boolean completa = false ;
            (string, int)[] seccion_candidata = new (string,int)[10];
            (string, int)[] trastorno_candidato = new (string, int)[14];
            String seccion_a_trabajar;
            String trastorno_a_trabajar = SeleccionCache.Trastornos_seleccionados[0];

            Arbol arbol = new Arbol();
            Nodo nodo;
            #endregion

            #region seccion para encontrar la seccion con menor conocimiento
            int a = 0;
            foreach (var value in trastorno_lista) {
                seccion = Conexion_a_la_bd.Obtener_seccion_trastorno(value);
                
                nodo = arbol.Buscar(seccion, Arbol.Raiz_statica);
                indice_pertenencia = Mayor_pertenencia(nodo);
                if ((indice_pertenencia) != 0) { completa = true; }
                seccion_candidata[a] = (seccion,indice_pertenencia);
                a++;
            }
            if (completa == false) { return "Ya ha completado todos los trastornos"; }

            seccion_a_trabajar = seccion_candidata[0].Item1;
            for (int b=0;b<seccion_candidata.Length-1;b++) {
                if (seccion_candidata[b].Item2<seccion_candidata[b+1].Item2) {
                    seccion_a_trabajar = seccion_candidata[b + 1].Item1;
                }
            }
            #endregion

            #region seccion para encontrar el trastorno con menor conocimiento
            nodo = arbol.Buscar(seccion_a_trabajar, Arbol.Raiz_statica);
            Nodo aux;
            int c = 0;
            foreach (var value in trastorno_lista) {
                aux = arbol.Buscar(trastorno_lista[c], nodo);
                if (aux != null) {
                    indice_pertenencia = Mayor_pertenencia(aux);
                    trastorno_candidato[c] = (trastorno_lista[c], indice_pertenencia);                 
                }
                c++;
            }
            for (int d = 0; d < trastorno_candidato.Length-1; d++) {
                if (trastorno_candidato[d].Item2 < trastorno_candidato[d + 1].Item2) {
                    trastorno_a_trabajar = trastorno_candidato[d + 1].Item1;
                }
            }
            #endregion

            return trastorno_a_trabajar;
        }
    }
}
