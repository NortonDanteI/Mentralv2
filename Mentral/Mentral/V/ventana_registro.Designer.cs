namespace Mentral.V
{
    partial class Ventana_registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_registro));
            this.Barratitulo = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.PictureBox();
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.rut = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.primer_nombre = new System.Windows.Forms.TextBox();
            this.segundo_nombre = new System.Windows.Forms.TextBox();
            this.apellido_paterno = new System.Windows.Forms.TextBox();
            this.apellido_materno = new System.Windows.Forms.TextBox();
            this.institucion_educativa = new System.Windows.Forms.TextBox();
            this.carrera = new System.Windows.Forms.TextBox();
            this.boton_registrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icono_registrate = new System.Windows.Forms.PictureBox();
            this.correo_electronico = new System.Windows.Forms.TextBox();
            this.Barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_registrate)).BeginInit();
            this.SuspendLayout();
            // 
            // Barratitulo
            // 
            this.Barratitulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Barratitulo.Controls.Add(this.boton_minimizar);
            this.Barratitulo.Controls.Add(this.boton_cerrar);
            this.Barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barratitulo.Location = new System.Drawing.Point(0, 0);
            this.Barratitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Barratitulo.Name = "Barratitulo";
            this.Barratitulo.Size = new System.Drawing.Size(552, 39);
            this.Barratitulo.TabIndex = 1;
            this.Barratitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barratitulo_MouseMove);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("boton_minimizar.Image")));
            this.boton_minimizar.Location = new System.Drawing.Point(485, 9);
            this.boton_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(25, 25);
            this.boton_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_minimizar.TabIndex = 5;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Click += new System.EventHandler(this.Boton_minimizar_Click);
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boton_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar.Image")));
            this.boton_cerrar.Location = new System.Drawing.Point(516, 9);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 4;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // rut
            // 
            this.rut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rut.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.rut.ForeColor = System.Drawing.Color.AliceBlue;
            this.rut.Location = new System.Drawing.Point(27, 145);
            this.rut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(225, 39);
            this.rut.TabIndex = 0;
            this.rut.Text = "Rut";
            this.rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rut.Enter += new System.EventHandler(this.Rut_Enter);
            this.rut.Leave += new System.EventHandler(this.Rut_Leave);
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.contraseña.ForeColor = System.Drawing.Color.AliceBlue;
            this.contraseña.Location = new System.Drawing.Point(268, 145);
            this.contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(255, 39);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Contraseña";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // primer_nombre
            // 
            this.primer_nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.primer_nombre.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.primer_nombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.primer_nombre.Location = new System.Drawing.Point(27, 199);
            this.primer_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.primer_nombre.Name = "primer_nombre";
            this.primer_nombre.Size = new System.Drawing.Size(225, 39);
            this.primer_nombre.TabIndex = 2;
            this.primer_nombre.Text = "Primer nombre";
            this.primer_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primer_nombre.Enter += new System.EventHandler(this.Primer_nombre_Enter);
            this.primer_nombre.Leave += new System.EventHandler(this.Primer_nombre_Leave);
            // 
            // segundo_nombre
            // 
            this.segundo_nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.segundo_nombre.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.segundo_nombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.segundo_nombre.Location = new System.Drawing.Point(268, 199);
            this.segundo_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.segundo_nombre.Name = "segundo_nombre";
            this.segundo_nombre.Size = new System.Drawing.Size(255, 39);
            this.segundo_nombre.TabIndex = 3;
            this.segundo_nombre.Text = "Segundo nombre";
            this.segundo_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.segundo_nombre.Enter += new System.EventHandler(this.Segundo_nombre_Enter);
            this.segundo_nombre.Leave += new System.EventHandler(this.Segundo_nombre_Leave);
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.apellido_paterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellido_paterno.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.apellido_paterno.ForeColor = System.Drawing.Color.AliceBlue;
            this.apellido_paterno.Location = new System.Drawing.Point(27, 253);
            this.apellido_paterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellido_paterno.Name = "apellido_paterno";
            this.apellido_paterno.Size = new System.Drawing.Size(225, 39);
            this.apellido_paterno.TabIndex = 4;
            this.apellido_paterno.Text = "Apellido paterno";
            this.apellido_paterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellido_paterno.Enter += new System.EventHandler(this.Apellido_paterno_Enter);
            this.apellido_paterno.Leave += new System.EventHandler(this.Apellido_paterno_Leave);
            // 
            // apellido_materno
            // 
            this.apellido_materno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.apellido_materno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellido_materno.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.apellido_materno.ForeColor = System.Drawing.Color.AliceBlue;
            this.apellido_materno.Location = new System.Drawing.Point(268, 253);
            this.apellido_materno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellido_materno.Name = "apellido_materno";
            this.apellido_materno.Size = new System.Drawing.Size(255, 39);
            this.apellido_materno.TabIndex = 5;
            this.apellido_materno.Text = "Apellido materno";
            this.apellido_materno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellido_materno.Enter += new System.EventHandler(this.Apellido_materno_Enter);
            this.apellido_materno.Leave += new System.EventHandler(this.Apellido_materno_Leave);
            // 
            // institucion_educativa
            // 
            this.institucion_educativa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.institucion_educativa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.institucion_educativa.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.institucion_educativa.ForeColor = System.Drawing.Color.AliceBlue;
            this.institucion_educativa.Location = new System.Drawing.Point(27, 307);
            this.institucion_educativa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.institucion_educativa.Name = "institucion_educativa";
            this.institucion_educativa.Size = new System.Drawing.Size(496, 39);
            this.institucion_educativa.TabIndex = 6;
            this.institucion_educativa.Text = "Institución educativa";
            this.institucion_educativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.institucion_educativa.Enter += new System.EventHandler(this.Institucion_educativa_Enter);
            this.institucion_educativa.Leave += new System.EventHandler(this.Institucion_educativa_Leave);
            // 
            // carrera
            // 
            this.carrera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.carrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carrera.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.carrera.ForeColor = System.Drawing.Color.AliceBlue;
            this.carrera.Location = new System.Drawing.Point(27, 361);
            this.carrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carrera.Name = "carrera";
            this.carrera.Size = new System.Drawing.Size(496, 39);
            this.carrera.TabIndex = 7;
            this.carrera.Text = "Carrera";
            this.carrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carrera.Enter += new System.EventHandler(this.Carrera_Enter);
            this.carrera.Leave += new System.EventHandler(this.Carrera_Leave);
            // 
            // boton_registrar
            // 
            this.boton_registrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_registrar.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.boton_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_registrar.Location = new System.Drawing.Point(171, 484);
            this.boton_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_registrar.Name = "boton_registrar";
            this.boton_registrar.Size = new System.Drawing.Size(201, 50);
            this.boton_registrar.TabIndex = 9;
            this.boton_registrar.Text = "Registrar";
            this.boton_registrar.UseVisualStyleBackColor = false;
            this.boton_registrar.Click += new System.EventHandler(this.Boton_registrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.icono_registrate);
            this.panel1.Controls.Add(this.correo_electronico);
            this.panel1.Controls.Add(this.boton_registrar);
            this.panel1.Controls.Add(this.primer_nombre);
            this.panel1.Controls.Add(this.carrera);
            this.panel1.Controls.Add(this.apellido_paterno);
            this.panel1.Controls.Add(this.apellido_materno);
            this.panel1.Controls.Add(this.institucion_educativa);
            this.panel1.Controls.Add(this.segundo_nombre);
            this.panel1.Controls.Add(this.rut);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 571);
            this.panel1.TabIndex = 12;
            // 
            // icono_registrate
            // 
            this.icono_registrate.Image = ((System.Drawing.Image)(resources.GetObject("icono_registrate.Image")));
            this.icono_registrate.Location = new System.Drawing.Point(123, 44);
            this.icono_registrate.Name = "icono_registrate";
            this.icono_registrate.Size = new System.Drawing.Size(308, 79);
            this.icono_registrate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono_registrate.TabIndex = 10;
            this.icono_registrate.TabStop = false;
            // 
            // correo_electronico
            // 
            this.correo_electronico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo_electronico.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.correo_electronico.ForeColor = System.Drawing.Color.AliceBlue;
            this.correo_electronico.Location = new System.Drawing.Point(27, 415);
            this.correo_electronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.Size = new System.Drawing.Size(496, 39);
            this.correo_electronico.TabIndex = 8;
            this.correo_electronico.Text = "Correo electrónico";
            this.correo_electronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correo_electronico.Enter += new System.EventHandler(this.Correo_electronico_Enter);
            this.correo_electronico.Leave += new System.EventHandler(this.Correo_electronico_Leave);
            // 
            // Ventana_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 571);
            this.Controls.Add(this.Barratitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana_registro";
            this.Opacity = 0.95D;
            this.Text = "ventana_registro";
            this.Barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_registrate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barratitulo;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox primer_nombre;
        private System.Windows.Forms.TextBox segundo_nombre;
        private System.Windows.Forms.TextBox apellido_paterno;
        private System.Windows.Forms.TextBox apellido_materno;
        private System.Windows.Forms.TextBox institucion_educativa;
        private System.Windows.Forms.TextBox carrera;
        private System.Windows.Forms.Button boton_registrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox correo_electronico;
        private System.Windows.Forms.PictureBox icono_registrate;
    }
}