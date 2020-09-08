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
            this.nombre = new System.Windows.Forms.TextBox();
            this.correo_electronico = new System.Windows.Forms.TextBox();
            this.boton_registrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estudiante = new System.Windows.Forms.RadioButton();
            this.experto = new System.Windows.Forms.RadioButton();
            this.icono_registrate = new System.Windows.Forms.PictureBox();
            this.Barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boton_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rut.ForeColor = System.Drawing.Color.AliceBlue;
            this.rut.Location = new System.Drawing.Point(27, 145);
            this.rut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(225, 29);
            this.rut.TabIndex = 1;
            this.rut.Text = "Rut";
            this.rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rut.Enter += new System.EventHandler(this.Rut_Enter);
            this.rut.Leave += new System.EventHandler(this.Rut_Leave);
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.contraseña.ForeColor = System.Drawing.Color.AliceBlue;
            this.contraseña.Location = new System.Drawing.Point(268, 145);
            this.contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(255, 29);
            this.contraseña.TabIndex = 2;
            this.contraseña.Text = "Contraseña";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.nombre.Location = new System.Drawing.Point(27, 197);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(496, 29);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Enter += new System.EventHandler(this.Nombre_Enter);
            this.nombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // correo_electronico
            // 
            this.correo_electronico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo_electronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.correo_electronico.ForeColor = System.Drawing.Color.AliceBlue;
            this.correo_electronico.Location = new System.Drawing.Point(27, 253);
            this.correo_electronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.Size = new System.Drawing.Size(496, 29);
            this.correo_electronico.TabIndex = 4;
            this.correo_electronico.Text = "Correo electrónico";
            this.correo_electronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correo_electronico.Enter += new System.EventHandler(this.Correo_electronico_Enter);
            this.correo_electronico.Leave += new System.EventHandler(this.Correo_electronico_Leave);
            // 
            // boton_registrar
            // 
            this.boton_registrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.boton_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_registrar.Location = new System.Drawing.Point(153, 383);
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.icono_registrate);
            this.panel1.Controls.Add(this.rut);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.correo_electronico);
            this.panel1.Controls.Add(this.boton_registrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 466);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estudiante);
            this.groupBox1.Controls.Add(this.experto);
            this.groupBox1.Location = new System.Drawing.Point(90, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 61);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // estudiante
            // 
            this.estudiante.AutoSize = true;
            this.estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiante.Location = new System.Drawing.Point(21, 21);
            this.estudiante.Name = "estudiante";
            this.estudiante.Size = new System.Drawing.Size(109, 24);
            this.estudiante.TabIndex = 11;
            this.estudiante.TabStop = true;
            this.estudiante.Text = "Estudiante";
            this.estudiante.UseVisualStyleBackColor = true;
            // 
            // experto
            // 
            this.experto.AutoSize = true;
            this.experto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experto.Location = new System.Drawing.Point(238, 21);
            this.experto.Name = "experto";
            this.experto.Size = new System.Drawing.Size(87, 24);
            this.experto.TabIndex = 12;
            this.experto.TabStop = true;
            this.experto.Text = "Experto";
            this.experto.UseVisualStyleBackColor = true;
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
            // Ventana_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 466);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_registrate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barratitulo;
        private System.Windows.Forms.PictureBox boton_minimizar;
        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox correo_electronico;
        private System.Windows.Forms.Button boton_registrar;
        private System.Windows.Forms.Panel panel1;      
        private System.Windows.Forms.PictureBox icono_registrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton estudiante;
        private System.Windows.Forms.RadioButton experto;
    }
}