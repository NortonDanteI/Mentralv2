namespace Mentral.V
{
    partial class Ventana_configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_configuracion));
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.label_umbral = new System.Windows.Forms.Label();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.comboBox_umbral = new System.Windows.Forms.ComboBox();
            this.comboBox_trastornos = new System.Windows.Forms.ComboBox();
            this.comboBox_trastornos_2 = new System.Windows.Forms.ComboBox();
            this.comboBox_trastornos_3 = new System.Windows.Forms.ComboBox();
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
            this.boton_cerrar.Location = new System.Drawing.Point(960, 11);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 5;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // label_umbral
            // 
            this.label_umbral.AutoSize = true;
            this.label_umbral.Font = new System.Drawing.Font("TradeMark Demo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_umbral.Location = new System.Drawing.Point(210, 77);
            this.label_umbral.Name = "label_umbral";
            this.label_umbral.Size = new System.Drawing.Size(121, 45);
            this.label_umbral.TabIndex = 8;
            this.label_umbral.Text = "Umbral :";
            // 
            // boton_guardar
            // 
            this.boton_guardar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_guardar.Font = new System.Drawing.Font("TradeMark Demo", 15F);
            this.boton_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_guardar.Location = new System.Drawing.Point(432, 466);
            this.boton_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(201, 44);
            this.boton_guardar.TabIndex = 12;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = false;
            this.boton_guardar.Click += new System.EventHandler(this.Boton_guardar_Click);
            // 
            // comboBox_umbral
            // 
            this.comboBox_umbral.Font = new System.Drawing.Font("TradeMark Demo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_umbral.FormattingEnabled = true;
            this.comboBox_umbral.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_umbral.Location = new System.Drawing.Point(361, 77);
            this.comboBox_umbral.Name = "comboBox_umbral";
            this.comboBox_umbral.Size = new System.Drawing.Size(89, 49);
            this.comboBox_umbral.TabIndex = 9;
            // 
            // comboBox_trastornos
            // 
            this.comboBox_trastornos.DropDownHeight = 200;
            this.comboBox_trastornos.Font = new System.Drawing.Font("TradeMark Demo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_trastornos.FormattingEnabled = true;
            this.comboBox_trastornos.IntegralHeight = false;
            this.comboBox_trastornos.Location = new System.Drawing.Point(218, 172);
            this.comboBox_trastornos.MaxDropDownItems = 28;
            this.comboBox_trastornos.Name = "comboBox_trastornos";
            this.comboBox_trastornos.Size = new System.Drawing.Size(612, 49);
            this.comboBox_trastornos.TabIndex = 13;
            this.comboBox_trastornos.SelectedIndexChanged += new System.EventHandler(this.ComboBox_trastornos_SelectedIndexChanged);
            this.comboBox_trastornos.Enter += new System.EventHandler(this.ComboBox_trastornos_Enter);
            // 
            // comboBox_trastornos_2
            // 
            this.comboBox_trastornos_2.DropDownHeight = 100;
            this.comboBox_trastornos_2.Font = new System.Drawing.Font("TradeMark Demo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_trastornos_2.FormattingEnabled = true;
            this.comboBox_trastornos_2.IntegralHeight = false;
            this.comboBox_trastornos_2.Location = new System.Drawing.Point(218, 275);
            this.comboBox_trastornos_2.MaxDropDownItems = 28;
            this.comboBox_trastornos_2.Name = "comboBox_trastornos_2";
            this.comboBox_trastornos_2.Size = new System.Drawing.Size(612, 49);
            this.comboBox_trastornos_2.TabIndex = 14;
            this.comboBox_trastornos_2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_trastornos_2_SelectedIndexChanged);
            this.comboBox_trastornos_2.Enter += new System.EventHandler(this.ComboBox_trastornos_2_Enter);
            // 
            // comboBox_trastornos_3
            // 
            this.comboBox_trastornos_3.DropDownHeight = 100;
            this.comboBox_trastornos_3.Font = new System.Drawing.Font("TradeMark Demo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_trastornos_3.FormattingEnabled = true;
            this.comboBox_trastornos_3.IntegralHeight = false;
            this.comboBox_trastornos_3.Location = new System.Drawing.Point(218, 375);
            this.comboBox_trastornos_3.MaxDropDownItems = 28;
            this.comboBox_trastornos_3.Name = "comboBox_trastornos_3";
            this.comboBox_trastornos_3.Size = new System.Drawing.Size(612, 49);
            this.comboBox_trastornos_3.TabIndex = 15;
            this.comboBox_trastornos_3.SelectedIndexChanged += new System.EventHandler(this.ComboBox_trastornos_3_SelectedIndexChanged);
            this.comboBox_trastornos_3.Enter += new System.EventHandler(this.ComboBox_trastornos_3_Enter);
            // 
            // Ventana_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(997, 685);
            this.Controls.Add(this.comboBox_trastornos_3);
            this.Controls.Add(this.comboBox_trastornos_2);
            this.Controls.Add(this.comboBox_trastornos);
            this.Controls.Add(this.comboBox_umbral);
            this.Controls.Add(this.label_umbral);
            this.Controls.Add(this.boton_cerrar);
            this.Controls.Add(this.boton_guardar);
            this.Name = "Ventana_configuracion";
            this.Text = "Ventana_configuracion";
            this.Load += new System.EventHandler(this.Ventana_configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.Label label_umbral;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.ComboBox comboBox_umbral;
        private System.Windows.Forms.ComboBox comboBox_trastornos;
        private System.Windows.Forms.ComboBox comboBox_trastornos_2;
        private System.Windows.Forms.ComboBox comboBox_trastornos_3;
    }
}