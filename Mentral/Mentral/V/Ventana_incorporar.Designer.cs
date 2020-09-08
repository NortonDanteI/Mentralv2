namespace Mentral.V
{
    partial class Ventana_incorporar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_incorporar));
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.incorporar = new System.Windows.Forms.Button();
            this.respuesta_label = new System.Windows.Forms.Label();
            this.pregunta_label = new System.Windows.Forms.Label();
            this.trastorno_label = new System.Windows.Forms.Label();
            this.seccion_label = new System.Windows.Forms.Label();
            this.panel_derecho = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incorrecta = new System.Windows.Forms.CheckBox();
            this.correcta = new System.Windows.Forms.CheckBox();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.pregunta = new System.Windows.Forms.TextBox();
            this.trastorno = new System.Windows.Forms.TextBox();
            this.seccion = new System.Windows.Forms.TextBox();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            this.panel_izquierdo.SuspendLayout();
            this.panel_derecho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boton_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar.Image")));
            this.boton_cerrar.Location = new System.Drawing.Point(1478, 11);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 70;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // panel_izquierdo
            // 
            this.panel_izquierdo.AutoScrollMargin = new System.Drawing.Size(30, 0);
            this.panel_izquierdo.Controls.Add(this.incorporar);
            this.panel_izquierdo.Controls.Add(this.respuesta_label);
            this.panel_izquierdo.Controls.Add(this.pregunta_label);
            this.panel_izquierdo.Controls.Add(this.trastorno_label);
            this.panel_izquierdo.Controls.Add(this.seccion_label);
            this.panel_izquierdo.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_izquierdo.Location = new System.Drawing.Point(95, 0);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Size = new System.Drawing.Size(357, 629);
            this.panel_izquierdo.TabIndex = 59;
            // 
            // incorporar
            // 
            this.incorporar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.incorporar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incorporar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incorporar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.incorporar.Location = new System.Drawing.Point(15, 444);
            this.incorporar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incorporar.Name = "incorporar";
            this.incorporar.Size = new System.Drawing.Size(312, 50);
            this.incorporar.TabIndex = 6;
            this.incorporar.Text = "Incorporar";
            this.incorporar.UseVisualStyleBackColor = false;
            this.incorporar.Click += new System.EventHandler(this.Incorporar_Click);
            // 
            // respuesta_label
            // 
            this.respuesta_label.AutoSize = true;
            this.respuesta_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta_label.Location = new System.Drawing.Point(9, 347);
            this.respuesta_label.Name = "respuesta_label";
            this.respuesta_label.Size = new System.Drawing.Size(334, 32);
            this.respuesta_label.TabIndex = 58;
            this.respuesta_label.Text = "Respuesta                         :";
            // 
            // pregunta_label
            // 
            this.pregunta_label.AutoSize = true;
            this.pregunta_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta_label.Location = new System.Drawing.Point(9, 177);
            this.pregunta_label.Name = "pregunta_label";
            this.pregunta_label.Size = new System.Drawing.Size(328, 32);
            this.pregunta_label.TabIndex = 57;
            this.pregunta_label.Text = "Pregunta                           :";
            // 
            // trastorno_label
            // 
            this.trastorno_label.AutoSize = true;
            this.trastorno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trastorno_label.Location = new System.Drawing.Point(9, 117);
            this.trastorno_label.Name = "trastorno_label";
            this.trastorno_label.Size = new System.Drawing.Size(333, 32);
            this.trastorno_label.TabIndex = 56;
            this.trastorno_label.Text = "Trastorno                           :";
            // 
            // seccion_label
            // 
            this.seccion_label.AutoSize = true;
            this.seccion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion_label.Location = new System.Drawing.Point(9, 57);
            this.seccion_label.Name = "seccion_label";
            this.seccion_label.Size = new System.Drawing.Size(347, 32);
            this.seccion_label.TabIndex = 55;
            this.seccion_label.Text = "Seccion de conocimiento :";
            // 
            // panel_derecho
            // 
            this.panel_derecho.AutoScrollMargin = new System.Drawing.Size(30, 0);
            this.panel_derecho.Controls.Add(this.groupBox1);
            this.panel_derecho.Controls.Add(this.respuesta);
            this.panel_derecho.Controls.Add(this.pregunta);
            this.panel_derecho.Controls.Add(this.trastorno);
            this.panel_derecho.Controls.Add(this.seccion);
            this.panel_derecho.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_derecho.Location = new System.Drawing.Point(456, 0);
            this.panel_derecho.Name = "panel_derecho";
            this.panel_derecho.Size = new System.Drawing.Size(1000, 629);
            this.panel_derecho.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.incorrecta);
            this.groupBox1.Controls.Add(this.correcta);
            this.groupBox1.Location = new System.Drawing.Point(14, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // incorrecta
            // 
            this.incorrecta.AutoSize = true;
            this.incorrecta.Location = new System.Drawing.Point(163, 44);
            this.incorrecta.Name = "incorrecta";
            this.incorrecta.Size = new System.Drawing.Size(93, 21);
            this.incorrecta.TabIndex = 7;
            this.incorrecta.Text = "Incorrecta";
            this.incorrecta.UseVisualStyleBackColor = true;
            // 
            // correcta
            // 
            this.correcta.AutoSize = true;
            this.correcta.Location = new System.Drawing.Point(32, 44);
            this.correcta.Name = "correcta";
            this.correcta.Size = new System.Drawing.Size(84, 21);
            this.correcta.TabIndex = 5;
            this.correcta.Text = "Correcta";
            this.correcta.UseVisualStyleBackColor = true;
            // 
            // respuesta
            // 
            this.respuesta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.respuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.Color.AliceBlue;
            this.respuesta.Location = new System.Drawing.Point(14, 344);
            this.respuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.respuesta.Multiline = true;
            this.respuesta.Name = "respuesta";
            this.respuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.respuesta.Size = new System.Drawing.Size(961, 150);
            this.respuesta.TabIndex = 4;
            this.respuesta.Text = "Alternativa";
            this.respuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.respuesta.Enter += new System.EventHandler(this.Respuesta_Enter);
            this.respuesta.Leave += new System.EventHandler(this.Respuesta_Leave);
            // 
            // pregunta
            // 
            this.pregunta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.ForeColor = System.Drawing.Color.AliceBlue;
            this.pregunta.Location = new System.Drawing.Point(14, 174);
            this.pregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pregunta.Multiline = true;
            this.pregunta.Name = "pregunta";
            this.pregunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pregunta.Size = new System.Drawing.Size(961, 150);
            this.pregunta.TabIndex = 3;
            this.pregunta.Text = "Ingrese pregunta";
            this.pregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pregunta.Enter += new System.EventHandler(this.Pregunta_Enter);
            this.pregunta.Leave += new System.EventHandler(this.Pregunta_Leave);
            // 
            // trastorno
            // 
            this.trastorno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.trastorno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trastorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trastorno.ForeColor = System.Drawing.Color.AliceBlue;
            this.trastorno.Location = new System.Drawing.Point(14, 114);
            this.trastorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trastorno.Multiline = true;
            this.trastorno.Name = "trastorno";
            this.trastorno.Size = new System.Drawing.Size(961, 35);
            this.trastorno.TabIndex = 2;
            this.trastorno.Text = "Ingrese trastorno";
            this.trastorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trastorno.Enter += new System.EventHandler(this.Trastorno_Enter);
            this.trastorno.Leave += new System.EventHandler(this.Trastorno_Leave);
            // 
            // seccion
            // 
            this.seccion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.seccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion.ForeColor = System.Drawing.Color.AliceBlue;
            this.seccion.Location = new System.Drawing.Point(14, 54);
            this.seccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seccion.Multiline = true;
            this.seccion.Name = "seccion";
            this.seccion.Size = new System.Drawing.Size(961, 35);
            this.seccion.TabIndex = 1;
            this.seccion.Text = "Ingrese sección";
            this.seccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seccion.Enter += new System.EventHandler(this.Seccion_Enter);
            this.seccion.Leave += new System.EventHandler(this.Seccion_Leave);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.AutoScroll = true;
            this.panel_contenedor.AutoScrollMargin = new System.Drawing.Size(30, 0);
            this.panel_contenedor.Controls.Add(this.panel_derecho);
            this.panel_contenedor.Controls.Add(this.panel_izquierdo);
            this.panel_contenedor.Controls.Add(this.boton_cerrar);
            this.panel_contenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1515, 673);
            this.panel_contenedor.TabIndex = 54;
            // 
            // Ventana_incorporar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1515, 673);
            this.Controls.Add(this.panel_contenedor);
            this.Name = "Ventana_incorporar";
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            this.panel_izquierdo.ResumeLayout(false);
            this.panel_izquierdo.PerformLayout();
            this.panel_derecho.ResumeLayout(false);
            this.panel_derecho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Label seccion_label;
        private System.Windows.Forms.Label trastorno_label;
        private System.Windows.Forms.Label respuesta_label;
        private System.Windows.Forms.Label pregunta_label;
        private System.Windows.Forms.Button incorporar;
        private System.Windows.Forms.Panel panel_derecho;
        private System.Windows.Forms.TextBox trastorno;
        private System.Windows.Forms.TextBox seccion;
        private System.Windows.Forms.TextBox pregunta;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox incorrecta;
        private System.Windows.Forms.CheckBox correcta;
    }
}