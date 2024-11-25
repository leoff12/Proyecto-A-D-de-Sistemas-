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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mtxtFechaEvento = new System.Windows.Forms.MaskedTextBox();
            this.lblHInicio = new System.Windows.Forms.Label();
            this.lblHFin = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGuardarEvento = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbImagen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtTipoPublico = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTipoPublico = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCuposDisp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCuposDisp = new System.Windows.Forms.Label();
            this.mtxtHFin = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHInicio = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbInicio);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 406);
            this.panel2.TabIndex = 4;
            // 
            // pbInicio
            // 
            this.pbInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(7, 59);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(2);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(29, 25);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // pbMas
            // 
            this.pbMas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(7, 9);
            this.pbMas.Margin = new System.Windows.Forms.Padding(2);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(29, 25);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(-4, 86);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(42, 19);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreEvento.Location = new System.Drawing.Point(13, 67);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(195, 29);
            this.txtNombreEvento.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(11, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 17);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título del Evento";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 95);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 17);
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
            this.txtDescripcion.Location = new System.Drawing.Point(13, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(194, 63);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(523, 88);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(112, 17);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha del Evento";
            // 
            // mtxtFechaEvento
            // 
            this.mtxtFechaEvento.Location = new System.Drawing.Point(660, 81);
            this.mtxtFechaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtFechaEvento.Mask = "00/00/0000";
            this.mtxtFechaEvento.Name = "mtxtFechaEvento";
            this.mtxtFechaEvento.Size = new System.Drawing.Size(68, 29);
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
            this.lblHInicio.Location = new System.Drawing.Point(523, 118);
            this.lblHInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHInicio.Name = "lblHInicio";
            this.lblHInicio.Size = new System.Drawing.Size(77, 17);
            this.lblHInicio.TabIndex = 12;
            this.lblHInicio.Text = "Hora Inicio";
            // 
            // lblHFin
            // 
            this.lblHFin.AutoSize = true;
            this.lblHFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHFin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFin.ForeColor = System.Drawing.Color.Black;
            this.lblHFin.Location = new System.Drawing.Point(523, 150);
            this.lblHFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHFin.Name = "lblHFin";
            this.lblHFin.Size = new System.Drawing.Size(62, 17);
            this.lblHFin.TabIndex = 14;
            this.lblHFin.Text = "Hora Fin";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 24;
            this.guna2GroupBox1.Controls.Add(this.btnGuardarEvento);
            this.guna2GroupBox1.Controls.Add(this.pictureBox);
            this.guna2GroupBox1.Controls.Add(this.cmbImagen);
            this.guna2GroupBox1.Controls.Add(this.lblImagen);
            this.guna2GroupBox1.Controls.Add(this.txtTipoPublico);
            this.guna2GroupBox1.Controls.Add(this.lblTipoPublico);
            this.guna2GroupBox1.Controls.Add(this.lblCategoria);
            this.guna2GroupBox1.Controls.Add(this.txtCategoria);
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
            this.guna2GroupBox1.Location = new System.Drawing.Point(57, 8);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(755, 377);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Información del Evento";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btnGuardarEvento
            // 
            this.btnGuardarEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEvento.BorderRadius = 24;
            this.btnGuardarEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarEvento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEvento.ForeColor = System.Drawing.Color.Pink;
            this.btnGuardarEvento.Location = new System.Drawing.Point(304, 329);
            this.btnGuardarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarEvento.Name = "btnGuardarEvento";
            this.btnGuardarEvento.Size = new System.Drawing.Size(141, 29);
            this.btnGuardarEvento.TabIndex = 25;
            this.btnGuardarEvento.Text = "Guardar Evento";
            this.btnGuardarEvento.Click += new System.EventHandler(this.btnGuardarEvento_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(525, 194);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 130);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
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
            this.cmbImagen.Location = new System.Drawing.Point(13, 315);
            this.cmbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.Size = new System.Drawing.Size(95, 36);
            this.cmbImagen.TabIndex = 23;
            this.cmbImagen.SelectedIndexChanged += new System.EventHandler(this.cmbImagen_SelectedIndexChanged);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Black;
            this.lblImagen.Location = new System.Drawing.Point(10, 298);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(123, 17);
            this.lblImagen.TabIndex = 22;
            this.lblImagen.Text = "Imagen del Evento";
            // 
            // txtTipoPublico
            // 
            this.txtTipoPublico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoPublico.DefaultText = "";
            this.txtTipoPublico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipoPublico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipoPublico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipoPublico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipoPublico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoPublico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipoPublico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipoPublico.Location = new System.Drawing.Point(13, 256);
            this.txtTipoPublico.Name = "txtTipoPublico";
            this.txtTipoPublico.PasswordChar = '\0';
            this.txtTipoPublico.PlaceholderText = "";
            this.txtTipoPublico.SelectedText = "";
            this.txtTipoPublico.Size = new System.Drawing.Size(191, 39);
            this.txtTipoPublico.TabIndex = 21;
            // 
            // lblTipoPublico
            // 
            this.lblTipoPublico.AutoSize = true;
            this.lblTipoPublico.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPublico.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPublico.ForeColor = System.Drawing.Color.Black;
            this.lblTipoPublico.Location = new System.Drawing.Point(11, 238);
            this.lblTipoPublico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPublico.Name = "lblTipoPublico";
            this.lblTipoPublico.Size = new System.Drawing.Size(100, 17);
            this.lblTipoPublico.TabIndex = 20;
            this.lblTipoPublico.Text = "Tipo de Público";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(10, 177);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 17);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoría";
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
            this.txtCategoria.Location = new System.Drawing.Point(13, 196);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.PlaceholderText = "";
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(191, 39);
            this.txtCategoria.TabIndex = 18;
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
            this.txtCuposDisp.Location = new System.Drawing.Point(661, 50);
            this.txtCuposDisp.Name = "txtCuposDisp";
            this.txtCuposDisp.PasswordChar = '\0';
            this.txtCuposDisp.PlaceholderText = "";
            this.txtCuposDisp.SelectedText = "";
            this.txtCuposDisp.Size = new System.Drawing.Size(67, 26);
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
            this.lblCuposDisp.Location = new System.Drawing.Point(523, 57);
            this.lblCuposDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuposDisp.Name = "lblCuposDisp";
            this.lblCuposDisp.Size = new System.Drawing.Size(120, 17);
            this.lblCuposDisp.TabIndex = 16;
            this.lblCuposDisp.Text = "Cupos Disponibles";
            // 
            // mtxtHFin
            // 
            this.mtxtHFin.Location = new System.Drawing.Point(661, 142);
            this.mtxtHFin.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHFin.Mask = "00:00";
            this.mtxtHFin.Name = "mtxtHFin";
            this.mtxtHFin.Size = new System.Drawing.Size(51, 29);
            this.mtxtHFin.TabIndex = 15;
            this.mtxtHFin.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHInicio
            // 
            this.mtxtHInicio.Location = new System.Drawing.Point(660, 111);
            this.mtxtHInicio.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtHInicio.Mask = "00:00";
            this.mtxtHInicio.Name = "mtxtHInicio";
            this.mtxtHInicio.Size = new System.Drawing.Size(51, 29);
            this.mtxtHInicio.TabIndex = 13;
            this.mtxtHInicio.ValidatingType = typeof(System.DateTime);
            // 
            // AgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 403);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarEvento";
            this.Text = "AgregarEvento";
            this.Load += new System.EventHandler(this.AgregarEvento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private System.Windows.Forms.Label lblInicio;
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
        private Guna.UI2.WinForms.Guna2TextBox txtTipoPublico;
        private System.Windows.Forms.Label lblTipoPublico;
        private System.Windows.Forms.Label lblCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoria;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2ComboBox cmbImagen;
        private System.Windows.Forms.Label lblImagen;
        private Guna.UI2.WinForms.Guna2Button btnGuardarEvento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgregarEvento;
    }
}