namespace Mentral.V
{
    partial class Ventana_perfil_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_perfil_usuario));
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.correo_electronico = new System.Windows.Forms.TextBox();
            this.contraseña_label = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label_correo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.nombre_label = new System.Windows.Forms.Label();
            this.rut_label = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.rut = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boton_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar.Image")));
            this.boton_cerrar.Location = new System.Drawing.Point(1200, 11);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 3;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // correo_electronico
            // 
            this.correo_electronico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.correo_electronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correo_electronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_electronico.ForeColor = System.Drawing.Color.AliceBlue;
            this.correo_electronico.Location = new System.Drawing.Point(779, 243);
            this.correo_electronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.Size = new System.Drawing.Size(408, 31);
            this.correo_electronico.TabIndex = 7;
            this.correo_electronico.Text = "Correo electrónico";
            this.correo_electronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correo_electronico.Enter += new System.EventHandler(this.Correo_electronico_Enter);
            this.correo_electronico.Leave += new System.EventHandler(this.Correo_electronico_Leave);
            // 
            // contraseña_label
            // 
            this.contraseña_label.AutoSize = true;
            this.contraseña_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_label.Location = new System.Drawing.Point(484, 128);
            this.contraseña_label.Name = "contraseña_label";
            this.contraseña_label.Size = new System.Drawing.Size(198, 32);
            this.contraseña_label.TabIndex = 32;
            this.contraseña_label.Text = "Contraseña   : ";
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.ForeColor = System.Drawing.Color.AliceBlue;
            this.contraseña.Location = new System.Drawing.Point(778, 129);
            this.contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(408, 31);
            this.contraseña.TabIndex = 8;
            this.contraseña.Text = "Contraseña";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correo.Location = new System.Drawing.Point(485, 242);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(200, 32);
            this.label_correo.TabIndex = 33;
            this.label_correo.Text = "Correo            : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // boton_modificar
            // 
            this.boton_modificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.boton_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_modificar.Location = new System.Drawing.Point(939, 299);
            this.boton_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(248, 50);
            this.boton_modificar.TabIndex = 35;
            this.boton_modificar.Text = "Modificar";
            this.boton_modificar.UseVisualStyleBackColor = false;
            this.boton_modificar.Click += new System.EventHandler(this.Boton_modificar_Click);
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_label.Location = new System.Drawing.Point(484, 187);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(200, 32);
            this.nombre_label.TabIndex = 43;
            this.nombre_label.Text = "Nombre          : ";
            // 
            // rut_label
            // 
            this.rut_label.AutoSize = true;
            this.rut_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut_label.Location = new System.Drawing.Point(484, 73);
            this.rut_label.Name = "rut_label";
            this.rut_label.Size = new System.Drawing.Size(207, 32);
            this.rut_label.TabIndex = 42;
            this.rut_label.Text = "Rut                  :  ";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.AliceBlue;
            this.nombre.Location = new System.Drawing.Point(779, 188);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(408, 31);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Enter += new System.EventHandler(this.Nombre_Enter);
            this.nombre.Leave += new System.EventHandler(this.Nombre_Leave);
            // 
            // rut
            // 
            this.rut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rut.Enabled = false;
            this.rut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut.ForeColor = System.Drawing.Color.AliceBlue;
            this.rut.Location = new System.Drawing.Point(779, 74);
            this.rut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(408, 31);
            this.rut.TabIndex = 1;
            this.rut.TabStop = false;
            this.rut.Text = "Rut";
            this.rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(30, 0);
            this.panel1.Controls.Add(this.boton_cerrar);
            this.panel1.Controls.Add(this.nombre_label);
            this.panel1.Controls.Add(this.rut_label);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.rut);
            this.panel1.Controls.Add(this.boton_modificar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_correo);
            this.panel1.Controls.Add(this.contraseña_label);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Controls.Add(this.correo_electronico);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 437);
            this.panel1.TabIndex = 51;
            // 
            // Ventana_perfil_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1237, 437);
            this.Controls.Add(this.panel1);
            this.Name = "Ventana_perfil_usuario";
            this.Text = "ventana_perfil";
            this.Load += new System.EventHandler(this.Ventana_perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.TextBox correo_electronico;
        private System.Windows.Forms.Label contraseña_label;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label rut_label;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.Panel panel1;
    }
}