namespace Mentral.V
{
    partial class Ventana_manual_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_manual_usuario));
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boton_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar.Image")));
            this.boton_cerrar.Location = new System.Drawing.Point(743, 11);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 4;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(800, 450);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ventana_manual_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_cerrar);
            this.Controls.Add(this.textBox1);
            this.Name = "Ventana_manual_usuario";
            this.Text = "ventana_manual_usuario";
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}