namespace Mentral.V
{
    partial class Ventana_bienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_bienvenida));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gif2 = new System.Windows.Forms.PictureBox();
            this.gif1 = new System.Windows.Forms.PictureBox();
            this.nombre_usuario = new System.Windows.Forms.Label();
            this.bienvenida = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.imagen_izquierda = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_izquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 70);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(152, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.gif2);
            this.panel2.Controls.Add(this.gif1);
            this.panel2.Controls.Add(this.nombre_usuario);
            this.panel2.Controls.Add(this.bienvenida);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.imagen_izquierda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 431);
            this.panel2.TabIndex = 1;
            // 
            // gif2
            // 
            this.gif2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gif2.Image = ((System.Drawing.Image)(resources.GetObject("gif2.Image")));
            this.gif2.Location = new System.Drawing.Point(201, 40);
            this.gif2.Name = "gif2";
            this.gif2.Size = new System.Drawing.Size(72, 61);
            this.gif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif2.TabIndex = 6;
            this.gif2.TabStop = false;
            // 
            // gif1
            // 
            this.gif1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gif1.Image = ((System.Drawing.Image)(resources.GetObject("gif1.Image")));
            this.gif1.Location = new System.Drawing.Point(123, 40);
            this.gif1.Name = "gif1";
            this.gif1.Size = new System.Drawing.Size(47, 41);
            this.gif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif1.TabIndex = 5;
            this.gif1.TabStop = false;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.AutoSize = true;
            this.nombre_usuario.Font = new System.Drawing.Font("TradeMark Demo", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_usuario.Location = new System.Drawing.Point(576, 120);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(298, 60);
            this.nombre_usuario.TabIndex = 3;
            this.nombre_usuario.Text = "Nombre de usuario";
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Dock = System.Windows.Forms.DockStyle.Left;
            this.bienvenida.Font = new System.Drawing.Font("meatloaf", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(411, 0);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(542, 120);
            this.bienvenida.TabIndex = 2;
            this.bienvenida.Text = "Bienvenida/o";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(451, 233);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularProgressBar1.OuterMargin = -75;
            this.circularProgressBar1.OuterWidth = 75;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar1.ProgressWidth = 20;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.circularProgressBar1.Size = new System.Drawing.Size(180, 166);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(5, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // imagen_izquierda
            // 
            this.imagen_izquierda.BackColor = System.Drawing.SystemColors.Window;
            this.imagen_izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagen_izquierda.Image = ((System.Drawing.Image)(resources.GetObject("imagen_izquierda.Image")));
            this.imagen_izquierda.Location = new System.Drawing.Point(0, 0);
            this.imagen_izquierda.Name = "imagen_izquierda";
            this.imagen_izquierda.Size = new System.Drawing.Size(411, 431);
            this.imagen_izquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_izquierda.TabIndex = 0;
            this.imagen_izquierda.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Ventana_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana_bienvenida";
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Ventana_bienvenida_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_izquierda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imagen_izquierda;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label nombre_usuario;
        private System.Windows.Forms.PictureBox gif1;
        private System.Windows.Forms.PictureBox gif2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}