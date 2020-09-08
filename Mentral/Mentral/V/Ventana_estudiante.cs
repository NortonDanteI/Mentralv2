using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentral.V
{
    public partial class Ventana_estudiante : Form
    {
        public Ventana_estudiante()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        #region Funcionalidades del formulario arrastrar, y redimensionar
        /*Metodo para re dimensionar el tamaño de un formulario en tiempo de ejecucion, el tamaño de la chuleta (rectangulo infrerior) sera definido en 10*/
        private readonly int tolerance = 10;
        /*El mensaje WM_NCHITTEST se envía a una ventana cuando el cursor se mueve o cuando se pulsa o se suelta uno de los botones del ratón.*/
        private const int WM_NCHITTEST = 132;
        /*la pantalla se modifica en todos los sentidos con el valor 17*/
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    /*LParam para obtener las coordenadas x,y*/
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        /*Dibujo el rectangulo pero solo su interior */
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            /*Excluyo el exterior del rectangulo*/
            region.Exclude(sizeGripRectangle);
            this.panel_contenedor.Region = region;
            this.Invalidate();
        }
        /*Color y Grip (las lineas, la maya) del rectangulo*/
        protected override void OnPaint(PaintEventArgs e)
        {
            /*color del rencgulo*/
            SolidBrush blueBrush = new SolidBrush(SystemColors.ControlLightLight);
            /*relleno el interior*/
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            /*lo pinto*/
            base.OnPaint(e);
            /*incluyo una maya, las linea horizontales dentro del rectangulo para que se pueda ver por el usuario es decir hacerlo mas intuitivo*/
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        #endregion
        #region Funcionalidades para abrir formularios dentro del panel y para ejecutar eventos de marcado de botones
        /*Metodo para abrir formularios dentro del panel, le paso como parametro un formulario*/
        private void AbrirFormulario<MiForm>() where MiForm : Form, new() {
            Form formulario;
            formulario = panel_derecho.Controls.OfType<MiForm>().FirstOrDefault();/*Busca el formulario dentro del panel*/
            /*Si el formulario no se encuentra*/
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false
                };
                /*Añado el formulario al panel*/
                panel_derecho.Controls.Add(formulario);
                /*Establesco a formulario como nuevo control*/
                panel_derecho.Tag = formulario;
                /*le remuevo los bordes, luego acoplo todo el formulario al tamaño del panel, y lo muestro, y con bring lo tiro de los primeros*/
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
                formulario.BringToFront();
                /*Al cerrar el formulario hago que se ejecute un evento*/
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else {
                formulario.BringToFront();
            }
        }
        /*Metodo utilizado al cerrar formulario*/
        private void CloseForms(Object sender, FormClosedEventArgs e) {
            /*Si el formulario no esta entonces cambia el color de los componentes en este caso los botones, esto es para que el usuario sepa que ventanas estan activas y cuales no*/
            //MessageBox.Show("|"+Application.OpenForms["Ventana_perfil"]+"|"+ Application.OpenForms["Ventana_desempeño"]);
            if (Application.OpenForms["Ventana_perfil_usuario"] == null) {
                boton_perfil.BackColor = SystemColors.GradientActiveCaption;
                emoticon_perfil.BackColor = SystemColors.GradientActiveCaption;
            }
            if (Application.OpenForms["Ventana_desempeño"] == null)
            {
                boton_desempeño.BackColor = SystemColors.GradientActiveCaption;
                emoticon_desempeño.BackColor = SystemColors.GradientActiveCaption;
            }
            if (Application.OpenForms["Ventana_responder_cuestionario"] == null)
            {
                boton_responder_cuestionario.BackColor = SystemColors.GradientActiveCaption;
                emoticon_responder.BackColor = SystemColors.GradientActiveCaption;
            }
            if (Application.OpenForms["Ventana_manual_usuario"] == null)
            {
                boton_manual_usuario.BackColor = SystemColors.GradientActiveCaption;
                emoticon_manual.BackColor = SystemColors.GradientActiveCaption;
            }
        }
        #endregion
        #region Eventos
        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres salir", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }  
        }
        private void Boton_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Boton_perfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Ventana_perfil_usuario>();
            boton_perfil.BackColor = SystemColors.MenuHighlight;
            emoticon_perfil.BackColor = SystemColors.MenuHighlight;
        }
        private void Boton_desempeño_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Ventana_desempeño>();
            boton_desempeño.BackColor = SystemColors.MenuHighlight;
            emoticon_desempeño.BackColor = SystemColors.MenuHighlight;
        }
       
        private void Boton_responder_cuestionario_click(object sender, EventArgs e)
        {
            AbrirFormulario<Ventana_comenzar_estudio>();
            boton_responder_cuestionario.BackColor = SystemColors.MenuHighlight;
            emoticon_responder.BackColor = SystemColors.MenuHighlight;
        }

        private void Boton_manual_usuario_click(object sender, EventArgs e)
        {
            AbrirFormulario<Ventana_manual_usuario>();
            boton_manual_usuario.BackColor = SystemColors.MenuHighlight;
            emoticon_manual.BackColor = SystemColors.MenuHighlight;
        }
        /*declaro variables para capturar posicion y tamaño antes de maximizar, para poder restaurar despues a la posicion y tamaño que tenia antes de maximizar*/
        int lx, ly;
        int sw, sh;

        int posY = 0;
        int posX = 0;

        private void Barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void Boton_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            /*hago no visibile y visible para que el icono se maximizar se vea y una ves presionado desaparesca y aparesca el de restaurar*/
            boton_maximizar.Visible = false;
            boton_restaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void Boton_restaurar_Click(object sender, EventArgs e)
        {
            boton_maximizar.Visible = true;
            boton_restaurar.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
        }
        #endregion
    }
}
