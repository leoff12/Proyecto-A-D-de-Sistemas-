namespace ProyectoFinal.Formularios
{
    partial class AgregarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEvento));
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mtxtFechaEvento = new System.Windows.Forms.MaskedTextBox();
            this.lblHInicio = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkAccesible = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTipoDeEvento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGuardarEvento = new Guna.UI2.WinForms.Guna2Button();
            this.cmbImagen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipoDeEvento = new System.Windows.Forms.Label();
            this.txtCuposDisp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCuposDisp = new System.Windows.Forms.Label();
            this.mtxtHFin = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreEvento.Location = new System.Drawing.Point(20, 103);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(290, 40);
            this.txtNombreEvento.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(16, 77);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 23);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título del Evento";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 146);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(203, 23);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción del Evento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.Location = new System.Drawing.Point(20, 171);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(291, 97);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(572, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(155, 23);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha del Evento";
            // 
            // mtxtFechaEvento
            // 
            this.mtxtFechaEvento.Location = new System.Drawing.Point(777, 114);
            this.mtxtFechaEvento.Mask = "00/00/0000";
            this.mtxtFechaEvento.Name = "mtxtFechaEvento";
            this.mtxtFechaEvento.Size = new System.Drawing.Size(100, 40);
            this.mtxtFechaEvento.TabIndex = 11;
            this.mtxtFechaEvento.ValidatingType = typeof(System.DateTime);
            this.mtxtFechaEvento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtFechaEvento_MaskInputRejected);
            // 
            // lblHInicio
            // 
            this.lblHInicio.AutoSize = true;
            this.lblHInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHInicio.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHInicio.ForeColor = System.Drawing.Color.Black;
            this.lblHInicio.Location = new System.Drawing.Point(572, 171);
            this.lblHInicio.Name = "lblHInicio";
            this.lblHInicio.Size = new System.Drawing.Size(104, 23);
            this.lblHInicio.TabIndex = 12;
            this.lblHInicio.Text = "Hora Inicio";
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHFin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.Black;
            this.lblHFin.Location = new System.Drawing.Point(572, 220);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(84, 23);
            this.lblHFin.TabIndex = 14;
            this.lblHFin.Text = "Hora Fin";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 24;
            this.guna2GroupBox1.Controls.Add(this.chkAccesible);
            this.guna2GroupBox1.Controls.Add(this.cmbCategoria);
            this.guna2GroupBox1.Controls.Add(this.cmbTipoDeEvento);
            this.guna2GroupBox1.Controls.Add(this.btnGuardarEvento);
            this.guna2GroupBox1.Controls.Add(this.pictureBox);
            this.guna2GroupBox1.Controls.Add(this.cmbImagen);
            this.guna2GroupBox1.Controls.Add(this.lblImagen);
            this.guna2GroupBox1.Controls.Add(this.lblCategoria);
            this.guna2GroupBox1.Controls.Add(this.lblTipoDeEvento);
            this.guna2GroupBox1.Controls.Add(this.txtCuposDisp);
            this.guna2GroupBox1.Controls.Add(this.lblCuposDisp);
            this.guna2GroupBox1.Controls.Add(this.mtxtHFin);
            this.guna2GroupBox1.Controls.Add(this.lblHFin);
            this.guna2GroupBox1.Controls.Add(this.mtxtHInicio);
            this.guna2GroupBox1.Controls.Add(this.lblHInicio);
            this.guna2GroupBox1.Controls.Add(this.mtxtFechaEvento);
            this.guna2GroupBox1.Controls.Add(this.lblFecha);
            this.guna2GroupBox1.Controls.Add(this.txtDescripcion);
            this.guna2GroupBox1.Controls.Add(this.lblDescripcion);
            this.guna2GroupBox1.Controls.Add(this.lblTitulo);
            this.guna2GroupBox1.Controls.Add(this.txtNombreEvento);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(80, 55);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(987, 577);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Información del Evento";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // chkAccesible
            // 
            this.chkAccesible.AutoSize = true;
            this.chkAccesible.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAccesible.CheckedState.BorderRadius = 0;
            this.chkAccesible.CheckedState.BorderThickness = 0;
            this.chkAccesible.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAccesible.CheckMarkColor = System.Drawing.SystemColors.Highlight;
            this.chkAccesible.ForeColor = System.Drawing.Color.Black;
            this.chkAccesible.Location = new System.Drawing.Point(574, 494);
            this.chkAccesible.Name = "chkAccesible";
            this.chkAccesible.Size = new System.Drawing.Size(151, 36);
            this.chkAccesible.TabIndex = 28;
            this.chkAccesible.Text = "Accesible";
            this.chkAccesible.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAccesible.UncheckedState.BorderRadius = 0;
            this.chkAccesible.UncheckedState.BorderThickness = 0;
            this.chkAccesible.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategoria.ItemHeight = 30;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Deportes",
            "Cultura",
            "Educación"});
            this.cmbCategoria.Location = new System.Drawing.Point(20, 392);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(198, 36);
            this.cmbCategoria.TabIndex = 27;
            // 
            // cmbTipoDeEvento
            // 
            this.cmbTipoDeEvento.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDeEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDeEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeEvento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeEvento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDeEvento.ItemHeight = 30;
            this.cmbTipoDeEvento.Items.AddRange(new object[] {
            "PAGA",
            "GRATUITO"});
            this.cmbTipoDeEvento.Location = new System.Drawing.Point(20, 299);
            this.cmbTipoDeEvento.Name = "cmbTipoDeEvento";
            this.cmbTipoDeEvento.Size = new System.Drawing.Size(198, 36);
            this.cmbTipoDeEvento.TabIndex = 26;
            // 
            // btnGuardarEvento
            // 
            this.btnGuardarEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEvento.BorderRadius = 10;
            this.btnGuardarEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarEvento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvento.ForeColor = System.Drawing.Color.Pink;
            this.btnGuardarEvento.Location = new System.Drawing.Point(336, 515);
            this.btnGuardarEvento.Name = "btnGuardarEvento";
            this.btnGuardarEvento.Size = new System.Drawing.Size(212, 45);
            this.btnGuardarEvento.TabIndex = 25;
            this.btnGuardarEvento.Text = "Guardar Evento";
            this.btnGuardarEvento.Click += new System.EventHandler(this.btnGuardarEvento_Click);
            // 
            // cmbImagen
            // 
            this.cmbImagen.BackColor = System.Drawing.Color.Transparent;
            this.cmbImagen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImagen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbImagen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbImagen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbImagen.ItemHeight = 30;
            this.cmbImagen.Location = new System.Drawing.Point(20, 485);
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.Size = new System.Drawing.Size(140, 36);
            this.cmbImagen.TabIndex = 23;
            this.cmbImagen.SelectedIndexChanged += new System.EventHandler(this.cmbImagen_SelectedIndexChanged);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Black;
            this.lblImagen.Location = new System.Drawing.Point(15, 458);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(167, 23);
            this.lblImagen.TabIndex = 22;
            this.lblImagen.Text = "Imagen del Evento";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(16, 366);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 23);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblTipoDeEvento
            // 
            this.lblTipoDeEvento.AutoSize = true;
            this.lblTipoDeEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDeEvento.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeEvento.ForeColor = System.Drawing.Color.Black;
            this.lblTipoDeEvento.Location = new System.Drawing.Point(15, 272);
            this.lblTipoDeEvento.Name = "lblTipoDeEvento";
            this.lblTipoDeEvento.Size = new System.Drawing.Size(138, 23);
            this.lblTipoDeEvento.TabIndex = 19;
            this.lblTipoDeEvento.Text = "Tipo de Evento";
            // 
            // txtCuposDisp
            // 
            this.txtCuposDisp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuposDisp.DefaultText = "";
            this.txtCuposDisp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCuposDisp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCuposDisp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuposDisp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuposDisp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuposDisp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCuposDisp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuposDisp.Location = new System.Drawing.Point(778, 66);
            this.txtCuposDisp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCuposDisp.Name = "txtCuposDisp";
            this.txtCuposDisp.PasswordChar = '\0';
            this.txtCuposDisp.PlaceholderText = "";
            this.txtCuposDisp.SelectedText = "";
            this.txtCuposDisp.Size = new System.Drawing.Size(100, 40);
            this.txtCuposDisp.TabIndex = 17;
            this.txtCuposDisp.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txtCuposDisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuposDisp_KeyPress);
            // 
            // lblCuposDisp
            // 
            this.lblCuposDisp.AutoSize = true;
            this.lblCuposDisp.BackColor = System.Drawing.Color.Transparent;
            this.lblCuposDisp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuposDisp.ForeColor = System.Drawing.Color.Black;
            this.lblCuposDisp.Location = new System.Drawing.Point(572, 77);
            this.lblCuposDisp.Name = "lblCuposDisp";
            this.lblCuposDisp.Size = new System.Drawing.Size(162, 23);
            this.lblCuposDisp.TabIndex = 16;
            this.lblCuposDisp.Text = "Cupos Disponibles";
            // 
            // mtxtHFin
            // 
            this.mtxtHFin.Location = new System.Drawing.Point(778, 208);
            this.mtxtHFin.Mask = "00:00";
            this.mtxtHFin.Name = "mtxtHFin";
            this.mtxtHFin.Size = new System.Drawing.Size(74, 40);
            this.mtxtHFin.TabIndex = 15;
            this.mtxtHFin.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHInicio
            // 
            this.mtxtHInicio.Location = new System.Drawing.Point(777, 160);
            this.mtxtHInicio.Mask = "00:00";
            this.mtxtHInicio.Name = "mtxtHInicio";
            this.mtxtHInicio.Size = new System.Drawing.Size(74, 40);
            this.mtxtHInicio.TabIndex = 13;
            this.mtxtHInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoria.DefaultText = "";
            this.txtCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.Location = new System.Drawing.Point(20, 302);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.PlaceholderText = "";
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(286, 60);
            this.txtCategoria.TabIndex = 18;
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2PanelMenu.Controls.Add(this.label2);
            this.guna2PanelMenu.Controls.Add(this.label1);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pictureBox6);
            this.guna2PanelMenu.Controls.Add(this.pictureBox5);
            this.guna2PanelMenu.Location = new System.Drawing.Point(0, -2);
            this.guna2PanelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.Size = new System.Drawing.Size(60, 643);
            this.guna2PanelMenu.TabIndex = 6;
            this.guna2PanelMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensajes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.Image")));
            this.btnToggleMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.InitialImage")));
            this.btnToggleMenu.Location = new System.Drawing.Point(4, 51);
            this.btnToggleMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(48, 43);
            this.btnToggleMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleMenu.TabIndex = 2;
            this.btnToggleMenu.TabStop = false;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ProyectoFinal.Properties.Resources.speech_bubble_8716838;
            this.pictureBox6.Location = new System.Drawing.Point(70, 214);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ProyectoFinal.Properties.Resources.logout_17905742;
            this.pictureBox5.Location = new System.Drawing.Point(70, 98);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 69);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pbInicioAdmin_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(574, 288);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // AgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1118, 642);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "AgregarEvento";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.AgregarEvento_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mtxtFechaEvento;
        private System.Windows.Forms.Label lblHInicio;
        private System.Windows.Forms.Label lblHFin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtHFin;
        private System.Windows.Forms.MaskedTextBox mtxtHInicio;
        private Guna.UI2.WinForms.Guna2TextBox txtCuposDisp;
        private System.Windows.Forms.Label lblCuposDisp;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipoDeEvento;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2ComboBox cmbImagen;
        private System.Windows.Forms.Label lblImagen;
        private Guna.UI2.WinForms.Guna2Button btnGuardarEvento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgregarEvento;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoDeEvento;
        private Guna.UI2.WinForms.Guna2CheckBox chkAccesible;
    }
}