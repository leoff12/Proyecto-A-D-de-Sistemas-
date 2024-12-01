namespace ProyectoFinal.Formularios
{
    partial class DetalleEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleEventoForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbDetallesEvento = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            this.btnAnularReservacion = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservar = new Guna.UI2.WinForms.Guna2Button();
            this.lblDetallesDescripcion = new System.Windows.Forms.Label();
            this.lblHoraDeFin = new System.Windows.Forms.Label();
            this.lblHoraDeInicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCuposDisp = new System.Windows.Forms.Label();
            this.mtxHoraFinEvento = new System.Windows.Forms.MaskedTextBox();
            this.mtxHoraInicioEvento = new System.Windows.Forms.MaskedTextBox();
            this.txtCategoriaEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.mtxFechaEvento = new System.Windows.Forms.MaskedTextBox();
            this.txtEstadoPagoEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescripcionEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCuposDispEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombreEvento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbDetallesImagenEvento = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.gbDetallesEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetallesImagenEvento)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.gbDetallesEvento);
            this.panel3.Location = new System.Drawing.Point(42, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 370);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gbDetallesEvento
            // 
            this.gbDetallesEvento.BorderRadius = 10;
            this.gbDetallesEvento.Controls.Add(this.pbLogoUAM);
            this.gbDetallesEvento.Controls.Add(this.btnAnularReservacion);
            this.gbDetallesEvento.Controls.Add(this.btnReservar);
            this.gbDetallesEvento.Controls.Add(this.lblDetallesDescripcion);
            this.gbDetallesEvento.Controls.Add(this.lblHoraDeFin);
            this.gbDetallesEvento.Controls.Add(this.lblHoraDeInicio);
            this.gbDetallesEvento.Controls.Add(this.lblFecha);
            this.gbDetallesEvento.Controls.Add(this.lblCuposDisp);
            this.gbDetallesEvento.Controls.Add(this.mtxHoraFinEvento);
            this.gbDetallesEvento.Controls.Add(this.mtxHoraInicioEvento);
            this.gbDetallesEvento.Controls.Add(this.txtCategoriaEvento);
            this.gbDetallesEvento.Controls.Add(this.mtxFechaEvento);
            this.gbDetallesEvento.Controls.Add(this.txtEstadoPagoEvento);
            this.gbDetallesEvento.Controls.Add(this.txtDescripcionEvento);
            this.gbDetallesEvento.Controls.Add(this.txtCuposDispEvento);
            this.gbDetallesEvento.Controls.Add(this.lblNombreEvento);
            this.gbDetallesEvento.Controls.Add(this.pbDetallesImagenEvento);
            this.gbDetallesEvento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetallesEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbDetallesEvento.Location = new System.Drawing.Point(19, 17);
            this.gbDetallesEvento.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetallesEvento.Name = "gbDetallesEvento";
            this.gbDetallesEvento.Size = new System.Drawing.Size(619, 322);
            this.gbDetallesEvento.TabIndex = 1;
            this.gbDetallesEvento.Text = "Información del Evento";
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = global::ProyectoFinal.Properties.Resources.logo_uam_2;
            this.pbLogoUAM.Location = new System.Drawing.Point(511, 0);
            this.pbLogoUAM.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(109, 40);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
            // 
            // btnAnularReservacion
            // 
            this.btnAnularReservacion.BackColor = System.Drawing.Color.Transparent;
            this.btnAnularReservacion.BorderRadius = 15;
            this.btnAnularReservacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnularReservacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnularReservacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnularReservacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnularReservacion.FillColor = System.Drawing.Color.Red;
            this.btnAnularReservacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularReservacion.ForeColor = System.Drawing.Color.White;
            this.btnAnularReservacion.Location = new System.Drawing.Point(387, 258);
            this.btnAnularReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnularReservacion.Name = "btnAnularReservacion";
            this.btnAnularReservacion.Size = new System.Drawing.Size(91, 29);
            this.btnAnularReservacion.TabIndex = 16;
            this.btnAnularReservacion.Text = "Anular";
            this.btnAnularReservacion.Click += new System.EventHandler(this.btnAnularReservacion_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.BorderRadius = 15;
            this.btnReservar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(493, 258);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(119, 29);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblDetallesDescripcion
            // 
            this.lblDetallesDescripcion.AutoSize = true;
            this.lblDetallesDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesDescripcion.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesDescripcion.Location = new System.Drawing.Point(215, 120);
            this.lblDetallesDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetallesDescripcion.Name = "lblDetallesDescripcion";
            this.lblDetallesDescripcion.Size = new System.Drawing.Size(134, 17);
            this.lblDetallesDescripcion.TabIndex = 14;
            this.lblDetallesDescripcion.Text = "Descripción del Evento:";
            this.lblDetallesDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHoraDeFin
            // 
            this.lblHoraDeFin.AutoSize = true;
            this.lblHoraDeFin.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraDeFin.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDeFin.Location = new System.Drawing.Point(426, 161);
            this.lblHoraDeFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraDeFin.Name = "lblHoraDeFin";
            this.lblHoraDeFin.Size = new System.Drawing.Size(73, 17);
            this.lblHoraDeFin.TabIndex = 13;
            this.lblHoraDeFin.Text = "Hora de Fin:";
            this.lblHoraDeFin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHoraDeInicio
            // 
            this.lblHoraDeInicio.AutoSize = true;
            this.lblHoraDeInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraDeInicio.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDeInicio.Location = new System.Drawing.Point(426, 128);
            this.lblHoraDeInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraDeInicio.Name = "lblHoraDeInicio";
            this.lblHoraDeInicio.Size = new System.Drawing.Size(85, 17);
            this.lblHoraDeInicio.TabIndex = 12;
            this.lblHoraDeInicio.Text = "Hora de Inicio:";
            this.lblHoraDeInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(214, 239);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCuposDisp
            // 
            this.lblCuposDisp.AutoSize = true;
            this.lblCuposDisp.BackColor = System.Drawing.Color.Transparent;
            this.lblCuposDisp.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuposDisp.Location = new System.Drawing.Point(426, 97);
            this.lblCuposDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuposDisp.Name = "lblCuposDisp";
            this.lblCuposDisp.Size = new System.Drawing.Size(114, 17);
            this.lblCuposDisp.TabIndex = 10;
            this.lblCuposDisp.Text = "Cupos Disponibles:";
            this.lblCuposDisp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtxHoraFinEvento
            // 
            this.mtxHoraFinEvento.Location = new System.Drawing.Point(555, 153);
            this.mtxHoraFinEvento.Margin = new System.Windows.Forms.Padding(2);
            this.mtxHoraFinEvento.Mask = "00:00";
            this.mtxHoraFinEvento.Name = "mtxHoraFinEvento";
            this.mtxHoraFinEvento.ReadOnly = true;
            this.mtxHoraFinEvento.Size = new System.Drawing.Size(55, 29);
            this.mtxHoraFinEvento.TabIndex = 9;
            this.mtxHoraFinEvento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxHoraInicioEvento
            // 
            this.mtxHoraInicioEvento.Location = new System.Drawing.Point(555, 120);
            this.mtxHoraInicioEvento.Margin = new System.Windows.Forms.Padding(2);
            this.mtxHoraInicioEvento.Mask = "00:00";
            this.mtxHoraInicioEvento.Name = "mtxHoraInicioEvento";
            this.mtxHoraInicioEvento.ReadOnly = true;
            this.mtxHoraInicioEvento.Size = new System.Drawing.Size(55, 29);
            this.mtxHoraInicioEvento.TabIndex = 8;
            this.mtxHoraInicioEvento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCategoriaEvento
            // 
            this.txtCategoriaEvento.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoriaEvento.BorderRadius = 10;
            this.txtCategoriaEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoriaEvento.DefaultText = "";
            this.txtCategoriaEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoriaEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoriaEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoriaEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoriaEvento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCategoriaEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaEvento.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaEvento.ForeColor = System.Drawing.Color.White;
            this.txtCategoriaEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaEvento.Location = new System.Drawing.Point(217, 86);
            this.txtCategoriaEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoriaEvento.Name = "txtCategoriaEvento";
            this.txtCategoriaEvento.PasswordChar = '\0';
            this.txtCategoriaEvento.PlaceholderText = "";
            this.txtCategoriaEvento.ReadOnly = true;
            this.txtCategoriaEvento.SelectedText = "";
            this.txtCategoriaEvento.Size = new System.Drawing.Size(105, 28);
            this.txtCategoriaEvento.TabIndex = 7;
            this.txtCategoriaEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxFechaEvento
            // 
            this.mtxFechaEvento.Location = new System.Drawing.Point(217, 258);
            this.mtxFechaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.mtxFechaEvento.Mask = "00/00/0000";
            this.mtxFechaEvento.Name = "mtxFechaEvento";
            this.mtxFechaEvento.ReadOnly = true;
            this.mtxFechaEvento.Size = new System.Drawing.Size(107, 29);
            this.mtxFechaEvento.TabIndex = 6;
            this.mtxFechaEvento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstadoPagoEvento
            // 
            this.txtEstadoPagoEvento.BackColor = System.Drawing.Color.Transparent;
            this.txtEstadoPagoEvento.BorderRadius = 10;
            this.txtEstadoPagoEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstadoPagoEvento.DefaultText = "";
            this.txtEstadoPagoEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstadoPagoEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstadoPagoEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoPagoEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstadoPagoEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoPagoEvento.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoPagoEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstadoPagoEvento.Location = new System.Drawing.Point(505, 55);
            this.txtEstadoPagoEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstadoPagoEvento.Name = "txtEstadoPagoEvento";
            this.txtEstadoPagoEvento.PasswordChar = '\0';
            this.txtEstadoPagoEvento.PlaceholderText = "";
            this.txtEstadoPagoEvento.ReadOnly = true;
            this.txtEstadoPagoEvento.SelectedText = "";
            this.txtEstadoPagoEvento.Size = new System.Drawing.Size(105, 31);
            this.txtEstadoPagoEvento.TabIndex = 5;
            this.txtEstadoPagoEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionEvento.DefaultText = "";
            this.txtDescripcionEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcionEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcionEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionEvento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionEvento.Location = new System.Drawing.Point(217, 142);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.PasswordChar = '\0';
            this.txtDescripcionEvento.PlaceholderText = "";
            this.txtDescripcionEvento.ReadOnly = true;
            this.txtDescripcionEvento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionEvento.SelectedText = "";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(159, 78);
            this.txtDescripcionEvento.TabIndex = 4;
            // 
            // txtCuposDispEvento
            // 
            this.txtCuposDispEvento.BackColor = System.Drawing.Color.Transparent;
            this.txtCuposDispEvento.BorderRadius = 10;
            this.txtCuposDispEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuposDispEvento.DefaultText = "";
            this.txtCuposDispEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCuposDispEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCuposDispEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuposDispEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCuposDispEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuposDispEvento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCuposDispEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCuposDispEvento.Location = new System.Drawing.Point(557, 94);
            this.txtCuposDispEvento.Name = "txtCuposDispEvento";
            this.txtCuposDispEvento.PasswordChar = '\0';
            this.txtCuposDispEvento.PlaceholderText = "";
            this.txtCuposDispEvento.ReadOnly = true;
            this.txtCuposDispEvento.SelectedText = "";
            this.txtCuposDispEvento.Size = new System.Drawing.Size(53, 21);
            this.txtCuposDispEvento.TabIndex = 3;
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEvento.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(217, 55);
            this.lblNombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(153, 27);
            this.lblNombreEvento.TabIndex = 1;
            this.lblNombreEvento.Text = "Título del Evento";
            // 
            // pbDetallesImagenEvento
            // 
            this.pbDetallesImagenEvento.ImageRotate = 0F;
            this.pbDetallesImagenEvento.Location = new System.Drawing.Point(15, 55);
            this.pbDetallesImagenEvento.Margin = new System.Windows.Forms.Padding(2);
            this.pbDetallesImagenEvento.Name = "pbDetallesImagenEvento";
            this.pbDetallesImagenEvento.Size = new System.Drawing.Size(185, 232);
            this.pbDetallesImagenEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetallesImagenEvento.TabIndex = 0;
            this.pbDetallesImagenEvento.TabStop = false;
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2PanelMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2PanelMenu.Controls.Add(this.btnCerrarSesiónAdmin);
            this.guna2PanelMenu.Controls.Add(this.label2);
            this.guna2PanelMenu.Controls.Add(this.label3);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pbAdministrador);
            this.guna2PanelMenu.Controls.Add(this.pbMensajes);
            this.guna2PanelMenu.Controls.Add(this.pbInicio);
            this.guna2PanelMenu.Location = new System.Drawing.Point(-1, 0);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.ShadowDecoration.BorderRadius = 10;
            this.guna2PanelMenu.ShadowDecoration.Color = System.Drawing.Color.SandyBrown;
            this.guna2PanelMenu.Size = new System.Drawing.Size(48, 411);
            this.guna2PanelMenu.TabIndex = 20;
            // 
            // btnCerrarSesiónAdmin
            // 
            this.btnCerrarSesiónAdmin.Animated = true;
            this.btnCerrarSesiónAdmin.AnimatedGIF = true;
            this.btnCerrarSesiónAdmin.AutoRoundedCorners = true;
            this.btnCerrarSesiónAdmin.BorderRadius = 13;
            this.btnCerrarSesiónAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesiónAdmin.DefaultAutoSize = true;
            this.btnCerrarSesiónAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesiónAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesiónAdmin.FillColor = System.Drawing.Color.Red;
            this.btnCerrarSesiónAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesiónAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesiónAdmin.Location = new System.Drawing.Point(51, 320);
            this.btnCerrarSesiónAdmin.Name = "btnCerrarSesiónAdmin";
            this.btnCerrarSesiónAdmin.Size = new System.Drawing.Size(108, 28);
            this.btnCerrarSesiónAdmin.TabIndex = 18;
            this.btnCerrarSesiónAdmin.Tag = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Text = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Click += new System.EventHandler(this.btnCerrarSesiónAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensajes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inicio";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Image = global::ProyectoFinal.Properties.Resources.settings_13895453;
            this.btnToggleMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.InitialImage")));
            this.btnToggleMenu.Location = new System.Drawing.Point(3, 51);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(30, 29);
            this.btnToggleMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnToggleMenu.TabIndex = 2;
            this.btnToggleMenu.TabStop = false;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // pbAdministrador
            // 
            this.pbAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.pbAdministrador.Image = global::ProyectoFinal.Properties.Resources._67654f6b2a7d10436445455b1458935f1;
            this.pbAdministrador.ImageRotate = 0F;
            this.pbAdministrador.Location = new System.Drawing.Point(3, 3);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(39, 32);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrador.TabIndex = 19;
            this.pbAdministrador.TabStop = false;
            // 
            // pbMensajes
            // 
            this.pbMensajes.BackColor = System.Drawing.Color.Transparent;
            this.pbMensajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMensajes.Image = global::ProyectoFinal.Properties.Resources.chat_4518034;
            this.pbMensajes.Location = new System.Drawing.Point(85, 154);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(44, 42);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 1;
            this.pbMensajes.TabStop = false;
            this.pbMensajes.Click += new System.EventHandler(this.pbMensajes_Click);
            // 
            // pbInicio
            // 
            this.pbInicio.BackColor = System.Drawing.Color.Transparent;
            this.pbInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInicio.Image = global::ProyectoFinal.Properties.Resources.home_100230672;
            this.pbInicio.Location = new System.Drawing.Point(85, 65);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(44, 45);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 0;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbDetallesRegresar_Click);
            // 
            // DetalleEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 409);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetalleEventoForm";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.DetalleEventoForm_Load);
            this.panel3.ResumeLayout(false);
            this.gbDetallesEvento.ResumeLayout(false);
            this.gbDetallesEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetallesImagenEvento)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLogoUAM;
        private Guna.UI2.WinForms.Guna2GroupBox gbDetallesEvento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreEvento;
        private Guna.UI2.WinForms.Guna2PictureBox pbDetallesImagenEvento;
        private Guna.UI2.WinForms.Guna2TextBox txtCuposDispEvento;
        private Guna.UI2.WinForms.Guna2TextBox txtEstadoPagoEvento;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionEvento;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoriaEvento;
        private System.Windows.Forms.MaskedTextBox mtxFechaEvento;
        private System.Windows.Forms.MaskedTextBox mtxHoraInicioEvento;
        private System.Windows.Forms.MaskedTextBox mtxHoraFinEvento;
        private System.Windows.Forms.Label lblCuposDisp;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetallesDescripcion;
        private System.Windows.Forms.Label lblHoraDeFin;
        private System.Windows.Forms.Label lblHoraDeInicio;
        private Guna.UI2.WinForms.Guna2Button btnReservar;
        private Guna.UI2.WinForms.Guna2Button btnAnularReservacion;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesiónAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.PictureBox pbInicio;
    }
}