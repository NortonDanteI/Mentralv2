namespace Mentral.V
{
    partial class Ventana_ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_ver));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.boton_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_central = new System.Windows.Forms.Panel();
            this.rel_preguntas_alternativas = new System.Windows.Forms.DataGridView();
            this.alternativas = new System.Windows.Forms.DataGridView();
            this.trastornos = new System.Windows.Forms.DataGridView();
            this.preguntas = new System.Windows.Forms.DataGridView();
            this.secciones = new System.Windows.Forms.DataGridView();
            this.Base_label = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).BeginInit();
            this.panel_central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rel_preguntas_alternativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trastornos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secciones)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boton_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar.Image")));
            this.boton_cerrar.Location = new System.Drawing.Point(1604, 33);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(25, 23);
            this.boton_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boton_cerrar.TabIndex = 4;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Click += new System.EventHandler(this.Boton_cerrar_Click);
            // 
            // panel_central
            // 
            this.panel_central.AutoScroll = true;
            this.panel_central.AutoScrollMargin = new System.Drawing.Size(50, 10);
            this.panel_central.Controls.Add(this.rel_preguntas_alternativas);
            this.panel_central.Controls.Add(this.boton_cerrar);
            this.panel_central.Controls.Add(this.alternativas);
            this.panel_central.Controls.Add(this.trastornos);
            this.panel_central.Controls.Add(this.preguntas);
            this.panel_central.Controls.Add(this.secciones);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 46);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1600, 611);
            this.panel_central.TabIndex = 5;
            // 
            // rel_preguntas_alternativas
            // 
            this.rel_preguntas_alternativas.AllowUserToAddRows = false;
            this.rel_preguntas_alternativas.AllowUserToDeleteRows = false;
            this.rel_preguntas_alternativas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rel_preguntas_alternativas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rel_preguntas_alternativas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rel_preguntas_alternativas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rel_preguntas_alternativas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rel_preguntas_alternativas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rel_preguntas_alternativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rel_preguntas_alternativas.DefaultCellStyle = dataGridViewCellStyle2;
            this.rel_preguntas_alternativas.EnableHeadersVisualStyles = false;
            this.rel_preguntas_alternativas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rel_preguntas_alternativas.Location = new System.Drawing.Point(77, 815);
            this.rel_preguntas_alternativas.Margin = new System.Windows.Forms.Padding(0);
            this.rel_preguntas_alternativas.Name = "rel_preguntas_alternativas";
            this.rel_preguntas_alternativas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rel_preguntas_alternativas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.rel_preguntas_alternativas.RowHeadersVisible = false;
            this.rel_preguntas_alternativas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.rel_preguntas_alternativas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.rel_preguntas_alternativas.RowTemplate.Height = 24;
            this.rel_preguntas_alternativas.Size = new System.Drawing.Size(703, 296);
            this.rel_preguntas_alternativas.TabIndex = 17;
            // 
            // alternativas
            // 
            this.alternativas.AllowUserToAddRows = false;
            this.alternativas.AllowUserToDeleteRows = false;
            this.alternativas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.alternativas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.alternativas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alternativas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alternativas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alternativas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.alternativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alternativas.DefaultCellStyle = dataGridViewCellStyle6;
            this.alternativas.EnableHeadersVisualStyles = false;
            this.alternativas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alternativas.Location = new System.Drawing.Point(840, 443);
            this.alternativas.Margin = new System.Windows.Forms.Padding(10);
            this.alternativas.Name = "alternativas";
            this.alternativas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alternativas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.alternativas.RowHeadersVisible = false;
            this.alternativas.RowHeadersWidth = 56;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.alternativas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.alternativas.RowTemplate.Height = 24;
            this.alternativas.Size = new System.Drawing.Size(763, 296);
            this.alternativas.TabIndex = 16;
            // 
            // trastornos
            // 
            this.trastornos.AllowUserToAddRows = false;
            this.trastornos.AllowUserToDeleteRows = false;
            this.trastornos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.trastornos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.trastornos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trastornos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trastornos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trastornos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.trastornos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trastornos.DefaultCellStyle = dataGridViewCellStyle10;
            this.trastornos.EnableHeadersVisualStyles = false;
            this.trastornos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trastornos.Location = new System.Drawing.Point(840, 77);
            this.trastornos.Margin = new System.Windows.Forms.Padding(0);
            this.trastornos.Name = "trastornos";
            this.trastornos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trastornos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.trastornos.RowHeadersVisible = false;
            this.trastornos.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.trastornos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.trastornos.RowTemplate.Height = 24;
            this.trastornos.Size = new System.Drawing.Size(763, 301);
            this.trastornos.TabIndex = 15;
            // 
            // preguntas
            // 
            this.preguntas.AllowUserToAddRows = false;
            this.preguntas.AllowUserToDeleteRows = false;
            this.preguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.preguntas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.preguntas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.preguntas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preguntas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.preguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.preguntas.DefaultCellStyle = dataGridViewCellStyle14;
            this.preguntas.EnableHeadersVisualStyles = false;
            this.preguntas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preguntas.Location = new System.Drawing.Point(77, 442);
            this.preguntas.Margin = new System.Windows.Forms.Padding(0);
            this.preguntas.Name = "preguntas";
            this.preguntas.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preguntas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.preguntas.RowHeadersVisible = false;
            this.preguntas.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.preguntas.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.preguntas.RowTemplate.Height = 24;
            this.preguntas.Size = new System.Drawing.Size(703, 296);
            this.preguntas.TabIndex = 13;
            // 
            // secciones
            // 
            this.secciones.AllowUserToAddRows = false;
            this.secciones.AllowUserToDeleteRows = false;
            this.secciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.secciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.secciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.secciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.secciones.DefaultCellStyle = dataGridViewCellStyle18;
            this.secciones.EnableHeadersVisualStyles = false;
            this.secciones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secciones.Location = new System.Drawing.Point(77, 77);
            this.secciones.Margin = new System.Windows.Forms.Padding(0);
            this.secciones.Name = "secciones";
            this.secciones.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.secciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.secciones.RowHeadersVisible = false;
            this.secciones.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.secciones.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.secciones.RowTemplate.Height = 24;
            this.secciones.Size = new System.Drawing.Size(703, 301);
            this.secciones.TabIndex = 11;
            // 
            // Base_label
            // 
            this.Base_label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Base_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Base_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Base_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_label.ForeColor = System.Drawing.Color.AliceBlue;
            this.Base_label.Location = new System.Drawing.Point(0, 0);
            this.Base_label.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Base_label.Name = "Base_label";
            this.Base_label.Size = new System.Drawing.Size(1600, 46);
            this.Base_label.TabIndex = 2;
            this.Base_label.Text = "Base de conocimiento.";
            this.Base_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ventana_ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1600, 657);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.Base_label);
            this.Name = "Ventana_ver";
            this.Load += new System.EventHandler(this.Ventana_ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boton_cerrar)).EndInit();
            this.panel_central.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rel_preguntas_alternativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trastornos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boton_cerrar;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.TextBox Base_label;
        private System.Windows.Forms.DataGridView secciones;
        private System.Windows.Forms.DataGridView alternativas;
        private System.Windows.Forms.DataGridView trastornos;
        private System.Windows.Forms.DataGridView preguntas;
        private System.Windows.Forms.DataGridView rel_preguntas_alternativas;
    }
}