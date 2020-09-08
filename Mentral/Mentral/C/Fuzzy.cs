using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentral.M;

namespace Mentral.C
{
    class Fuzzy
    {

        #region Funciones de membresia
        public static float Singleton(float x, float valor)
        {
            if (x == valor) {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static float Triangular(float x,float a, float b)
        {
            float m = (a+b)/2;
            if (x <= a)
            {
                return 0;
            }
            else {
                if ((x > a) && (x <= m))
                {
                    x = (x - a) / (m - a);
                    return x;
                }
                else {
                    if (x > m && x < b)
                    {
                        x = (b - x) / (b - m);
                        return x;
                    }
                    else {
                        return 0;                    
                    }
                }
            }
        }
        public static float Trapezoidal(float x, float a, float b, float c, float d)
        {
            if ((x < a) || (x > d))
            {
                return 0;
            }
            else {
                if ((x >= a) && (x<=b)) {
                    x = (x - a) / (b - a);
                    return x;
                }
                else{
                    if ((x >= b) && (x <= c))
                    {
                        return 1;
                    }
                    else {
                        x = (d - x) / (d - c);
                        return x;
                    }
                }
            }
        }
        #endregion

        #region Modificadores linguisticos
        public static float Concentracion(float x)
        {
            x = (float)Math.Pow(x, 2);
            return x;
        }
        public static float Dilatacion(float x)
        {
            x = (float)(2 * x) - (float)(Math.Pow(x, 2));
            return x;
        }
        #endregion

        #region Operadores lógicos
        public static float AND(float a, float b)
        {
            float x;
            x=(float)Math.Min(a, b);
            return x;
        }
        public static float OR(float a, float b)
        {
            float x;
            x = (float)Math.Max(a, b);
            return x;
        }
        public static float Mandani(float a, float b)
        {
            float x;
            x = (float)Math.Max(a, b);
            return x;
        }
        #endregion

        #region Segmento para fuzificar los trastornos
        public static (string,float)[] Fuzificar(String trastorno)
        {
            (string, float)[] etiquetas = new (string,float)[5];
            int dominio = Conexion_a_la_bd.Total_preguntas(trastorno);
            int acertadas = Conexion_a_la_bd.Total_acertadas(trastorno);
            Console.WriteLine(acertadas+"|"+dominio);
            #region supuestos
            /*Rangos = 100% de asertividad      para Totalmente aprendido.
              Rangos = 70% de asertivida a 100% para Aprendido.
              Rangos = 25% de asertividad a 75% para Casi aprendio.
              Rangos = 0% de asertividad a 30%  para Algo aprendido.
              Rangos = 0% de asertividad        para No aprendido.*/
            #endregion

            /*Entra sin fuzificar sale fuzificado*/
            if (dominio == 0)
            {
                etiquetas[0] = ("Totalmente aprendido", 1);
                etiquetas[1] = ("Aprendido", 0);
                etiquetas[2] = ("Casi aprendido", 0);
                etiquetas[3] = ("Algo aprendido", 0);
                etiquetas[4] = ("No aprendido", 0);
            }
            else {
                #region Pertenencia a Totalmente aprendido
                etiquetas[0] = ("Totalmente aprendido", Singleton(acertadas, dominio));
                #endregion

                #region Pertenencia a Aprendido
                float aceptable = ((float)dominio * (float)60) / (float)100;
                etiquetas[1] = ("Aprendido", Triangular(acertadas, aceptable, dominio));
                #endregion

                #region Pertenencia a Casi aprendido
                float inferior, soporte_inferior, soporte_superior, superior;
                inferior = (float)((dominio * 20) / 100);
                soporte_inferior = (float)((dominio * 40) / 100);
                soporte_superior = (float)((dominio * 60) / 100);
                superior = (float)((dominio * 80) / 100);
                etiquetas[2] = ("Casi aprendido", Dilatacion(Dilatacion(Trapezoidal(acertadas, inferior, soporte_inferior, soporte_superior, superior))));
                #endregion

                #region Pertenencia a Algo aprendido
                superior = (float)((dominio * 40) / 100);
                etiquetas[3] = ("Algo aprendido", Dilatacion(Triangular(acertadas, 0, superior)));
                #endregion

                #region Pertenencia a No aprendido
                etiquetas[4] = ("No aprendido", Singleton(acertadas, 0));
                #endregion
            }
            return etiquetas;
        }
        #endregion

        #region Segmento para hacer inferencias hacia seccion
        public static (string, float)[] Inferir_nivel_1(Nodo nodo)
        {
            (string, float)[] etiquetas = new (string, float)[5];
            
            if (nodo.Hijo != null) {
                Nodo aux = nodo.Hijo;
                #region Reglas para 2 trastornos -> Total 12 reglas (Se aplico reducción)
                if (aux.Hermano != null) {
                    #region Reglas para 2 trastornos -> Total 12 reglas

                    float regla_1 = AND(aux.Etiquetas[0].Item2, aux.Hermano.Etiquetas[0].Item2);
                    etiquetas[0] = ("Totalmente aprendido", regla_1);

                    float regla_2 = AND(aux.Etiquetas[0].Item2, OR(aux.Hermano.Etiquetas[1].Item2, aux.Hermano.Etiquetas[2].Item2));
                    float regla_3 = AND(aux.Etiquetas[1].Item2, OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2));
                    float regla_4 = AND(aux.Etiquetas[2].Item2, aux.Hermano.Etiquetas[0].Item2);
                    float valor = Mandani(regla_2, regla_3);
                    etiquetas[1] = ("Aprendido", Mandani(valor, regla_4));

                    float regla_5 = AND(aux.Etiquetas[0].Item2, OR(aux.Hermano.Etiquetas[3].Item2, aux.Hermano.Etiquetas[4].Item2));
                    float regla_6 = AND(aux.Etiquetas[1].Item2, OR(aux.Hermano.Etiquetas[4].Item2,(OR(aux.Hermano.Etiquetas[2].Item2, aux.Hermano.Etiquetas[3].Item2))));
                    float regla_7 = AND(aux.Etiquetas[2].Item2, OR(aux.Hermano.Etiquetas[3].Item2, (OR(aux.Hermano.Etiquetas[1].Item2, aux.Hermano.Etiquetas[2].Item2))));
                    float regla_8 = AND(aux.Etiquetas[3].Item2, OR(aux.Hermano.Etiquetas[2].Item2, (OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2))));
                    float regla_9 = AND(aux.Etiquetas[4].Item2, OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2));
                    valor = Mandani(regla_5, regla_6);
                    valor = Mandani(valor, regla_7);
                    valor = Mandani(valor,regla_8);
                    etiquetas[2] = ("Casi aprendido", Mandani(valor,regla_9));

                    float regla_10 = AND(aux.Etiquetas[2].Item2, aux.Hermano.Etiquetas[4].Item2);
                    float regla_11 = AND(aux.Etiquetas[3].Item2, OR(aux.Hermano.Etiquetas[3].Item2, aux.Hermano.Etiquetas[4].Item2));
                    float regla_12 = AND(aux.Etiquetas[4].Item2, OR(aux.Hermano.Etiquetas[2].Item2, aux.Hermano.Etiquetas[3].Item2));
                    valor = Mandani(regla_10, regla_11);
                    etiquetas[3] = ("Algo aprendido", Mandani(valor,regla_12));

                    float regla_13 = AND(aux.Etiquetas[4].Item2, aux.Hermano.Etiquetas[4].Item2);
                    etiquetas[4] = ("No aprendido", regla_13);
                    #endregion
                }
                #endregion
                else
                {
                    #region Reglas para 1 trastorno -> Total 5 reglas
                    etiquetas[0] = ("Totalmente aprendido", aux.Etiquetas[0].Item2);
                    etiquetas[1] = ("Aprendido", aux.Etiquetas[1].Item2);
                    etiquetas[2] = ("Casi aprendido", aux.Etiquetas[2].Item2);
                    etiquetas[3] = ("Algo aprendido", aux.Etiquetas[3].Item2);
                    etiquetas[4] = ("No aprendido", aux.Etiquetas[4].Item2);
                    #endregion
                }
            }
            return etiquetas;
        }
        #endregion

        #region Segmento para hacer inferencias hacia conocimiento general
        public static (string, float)[] Inferir_nivel_0(Nodo nodo)
        {
            (string, float)[] etiquetas = new (string, float)[5];

            if (nodo.Hijo != null)
            {
                Nodo aux = nodo.Hijo;
                #region Reglas para 2 secciones -> Total 12 reglas (Se aplico reducción)
                if (aux.Hermano != null)
                {
                    #region Reglas para 2 trastornos -> Total 12 reglas

                    float regla_1 = AND(aux.Etiquetas[0].Item2, aux.Hermano.Etiquetas[0].Item2);
                    etiquetas[0] = ("Totalmente aprendido", regla_1);

                    float regla_2 = AND(aux.Etiquetas[0].Item2, OR(aux.Hermano.Etiquetas[1].Item2, aux.Hermano.Etiquetas[2].Item2));
                    float regla_3 = AND(aux.Etiquetas[1].Item2, OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2));
                    float regla_4 = AND(aux.Etiquetas[2].Item2, aux.Hermano.Etiquetas[0].Item2);
                    float valor = Mandani(regla_2, regla_3);
                    etiquetas[1] = ("Aprendido", Mandani(valor, regla_4));

                    float regla_5 = AND(aux.Etiquetas[0].Item2, OR(aux.Hermano.Etiquetas[3].Item2, aux.Hermano.Etiquetas[4].Item2));
                    float regla_6 = AND(aux.Etiquetas[1].Item2, OR(aux.Hermano.Etiquetas[4].Item2, (OR(aux.Hermano.Etiquetas[2].Item2, aux.Hermano.Etiquetas[3].Item2))));
                    float regla_7 = AND(aux.Etiquetas[2].Item2, OR(aux.Hermano.Etiquetas[3].Item2, (OR(aux.Hermano.Etiquetas[1].Item2, aux.Hermano.Etiquetas[2].Item2))));
                    float regla_8 = AND(aux.Etiquetas[3].Item2, OR(aux.Hermano.Etiquetas[2].Item2, (OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2))));
                    float regla_9 = AND(aux.Etiquetas[4].Item2, OR(aux.Hermano.Etiquetas[0].Item2, aux.Hermano.Etiquetas[1].Item2));
                    valor = Mandani(regla_5, regla_6);
                    valor = Mandani(valor, regla_7);
                    valor = Mandani(valor, regla_8);
                    etiquetas[2] = ("Casi aprendido", Mandani(valor, regla_9));

                    float regla_10 = AND(aux.Etiquetas[2].Item2, aux.Hermano.Etiquetas[4].Item2);
                    float regla_11 = AND(aux.Etiquetas[3].Item2, OR(aux.Hermano.Etiquetas[3].Item2, aux.Hermano.Etiquetas[4].Item2));
                    float regla_12 = AND(aux.Etiquetas[4].Item2, OR(aux.Hermano.Etiquetas[2].Item2, aux.Hermano.Etiquetas[3].Item2));
                    valor = Mandani(regla_10, regla_11);
                    etiquetas[3] = ("Algo aprendido", Mandani(valor, regla_12));

                    float regla_13 = AND(aux.Etiquetas[4].Item2, aux.Hermano.Etiquetas[4].Item2);
                    etiquetas[4] = ("No aprendido", regla_13);
                    #endregion
                }
                #endregion
                else
                {
                    #region Reglas para 1 trastorno -> Total 5 reglas
                    etiquetas[0] = ("Totalmente aprendido", aux.Etiquetas[0].Item2);
                    etiquetas[1] = ("Aprendido", aux.Etiquetas[1].Item2);
                    etiquetas[2] = ("Casi aprendido", aux.Etiquetas[2].Item2);
                    etiquetas[3] = ("Algo aprendido", aux.Etiquetas[3].Item2);
                    etiquetas[4] = ("No aprendido", aux.Etiquetas[4].Item2);
                    #endregion
                }
            }
            return etiquetas;
        }
        #endregion
    }
}