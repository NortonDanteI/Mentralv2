using Mentral.V;
using Mentral.C;
using Mentral.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace Mentral
{ 
    static class Principal
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Motor_de_inferencia.Generar_estructura();
            //Motor_de_inferencia.Fuzzificar_estructura();
            Application.Run(new Ventana_login());
            //Application.Run(new Ventana_desempeño());
            //Application.Run(new Ventana_comenzar_estudio());
            /*
            String respuesta,ok;
            respuesta = "desarrollo de síntomas especificos tras la exposición a uno o mas eventos traumaticos";
            ok=Conexion_a_la_bd.Buscar_respuesta("cual es la característica diagnóstica principal del trastorno de éstres postraumático");
            if (respuesta == ok) { MessageBox.Show("ENTRO"); }*/
            //Application.Run(new Ventana_comenzar_estudio());


        }
    }
}