namespace ProyectoFinal.Formularios
{
    partial class MensajesUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajesUsuario));
            this.dgvMensajesUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreEventoMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEventoMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvioMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarMensaje = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBandejaDeMensajes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMensajesRegresarUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesUsuario)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMensajesUsuario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvMensajesUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensajesUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMensajesUsuario.ColumnHeadersHeight = 22;
            this.dgvMensajesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMensajesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEventoMensaje,
            this.FechaEventoMensaje,
            this.FechaEnvioMensaje,
            this.EstadoReservacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMensajesUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMensajesUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvMensajesUsuario.Location = new System.Drawing.Point(38, 85);
            this.dgvMensajesUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMensajesUsuario.Name = "dgvMensajesUsuario";
            this.dgvMensajesUsuario.RowHeadersVisible = false;
            this.dgvMensajesUsuario.RowHeadersWidth = 62;
            this.dgvMensajesUsuario.RowTemplate.Height = 28;
            this.dgvMensajesUsuario.Size = new System.Drawing.Size(692, 239);
            this.dgvMensajesUsuario.TabIndex = 8;
            this.dgvMensajesUsuario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvMensajesUsuario.ThemeStyle.ReadOnly = false;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // NombreEventoMensaje
            // 
            this.NombreEventoMensaje.HeaderText = "Nombre del Evento";
            this.NombreEventoMensaje.MinimumWidth = 8;
            this.NombreEventoMensaje.Name = "NombreEventoMensaje";
            this.NombreEventoMensaje.ReadOnly = true;
            // 
            // FechaEventoMensaje
            // 
            this.FechaEventoMensaje.HeaderText = "Fecha del Evento";
            this.FechaEventoMensaje.MinimumWidth = 8;
            this.FechaEventoMensaje.Name = "FechaEventoMensaje";
            this.FechaEventoMensaje.ReadOnly = true;
            // 
            // FechaEnvioMensaje
            // 
            this.FechaEnvioMensaje.HeaderText = "Fecha de Envío del Mensaje";
            this.FechaEnvioMensaje.MinimumWidth = 8;
            this.FechaEnvioMensaje.Name = "FechaEnvioMensaje";
            this.FechaEnvioMensaje.ReadOnly = true;
            // 
            // EstadoReservacion
            // 
            this.EstadoReservacion.HeaderText = "Estado de la Reservación";
            this.EstadoReservacion.MinimumWidth = 8;
            this.EstadoReservacion.Name = "EstadoReservacion";
            this.EstadoReservacion.ReadOnly = true;
            // 
            // btnEliminarMensaje
            // 
            this.btnEliminarMensaje.Animated = true;
            this.btnEliminarMensaje.AutoRoundedCorners = true;
            this.btnEliminarMensaje.BorderRadius = 13;
            this.btnEliminarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMensaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMensaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMensaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMensaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMensaje.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMensaje.Location = new System.Drawing.Point(303, 328);
            this.btnEliminarMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMensaje.Name = "btnEliminarMensaje";
            this.btnEliminarMensaje.Size = new System.Drawing.Size(140, 29);
            this.btnEliminarMensaje.TabIndex = 14;
            this.btnEliminarMensaje.Text = "Eliminar Mensaje";
            this.btnEliminarMensaje.Click += new System.EventHandler(this.btnEliminarMensaje_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.lblBandejaDeMensajes);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(38, 26);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DodgerBlue;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(692, 55);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.speech_bubble_8716838;
            this.pictureBox1.Location = new System.Drawing.Point(639, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBandejaDeMensajes
            // 
            this.lblBandejaDeMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lblBandejaDeMensajes.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandejaDeMensajes.Location = new System.Drawing.Point(4, 2);
            this.lblBandejaDeMensajes.Margin = new System.Windows.Forms.Padding(2);
            this.lblBandejaDeMensajes.Name = "lblBandejaDeMensajes";
            this.lblBandejaDeMensajes.Size = new System.Drawing.Size(271, 39);
            this.lblBandejaDeMensajes.TabIndex = 0;
            this.lblBandejaDeMensajes.Text = "Bandeja de Mensajes";
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2PanelMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2PanelMenu.Controls.Add(this.btnCerrarSesiónAdmin);
            this.guna2PanelMenu.Controls.Add(this.label3);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pbAdministrador);
            this.guna2PanelMenu.Controls.Add(this.pbMensajesRegresarUser);
            this.guna2PanelMenu.Location = new System.Drawing.Point(-1, -2);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.ShadowDecoration.BorderRadius = 10;
            this.guna2PanelMenu.ShadowDecoration.Color = System.Drawing.Color.SandyBrown;
            this.guna2PanelMenu.Size = new System.Drawing.Size(38, 383);
            this.guna2PanelMenu.TabIndex = 21;
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
            this.btnToggleMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleMenu.Image = global::ProyectoFinal.Properties.Resources.settings_13895453;
            this.btnToggleMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.InitialImage")));
            this.btnToggleMenu.Location = new System.Drawing.Point(5, 54);
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
            // pbMensajesRegresarUser
            // 
            this.pbMensajesRegresarUser.BackColor = System.Drawing.Color.Transparent;
            this.pbMensajesRegresarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMensajesRegresarUser.Image = global::ProyectoFinal.Properties.Resources.home_100230672;
            this.pbMensajesRegresarUser.Location = new System.Drawing.Point(85, 65);
            this.pbMensajesRegresarUser.Name = "pbMensajesRegresarUser";
            this.pbMensajesRegresarUser.Size = new System.Drawing.Size(44, 45);
            this.pbMensajesRegresarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajesRegresarUser.TabIndex = 0;
            this.pbMensajesRegresarUser.TabStop = false;
            this.pbMensajesRegresarUser.Click += new System.EventHandler(this.pbMensajesRegresarUser_Click);
            // 
            // MensajesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 381);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.btnEliminarMensaje);
            this.Controls.Add(this.dgvMensajesUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MensajesUsuario";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Mensajes Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MensajesUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesUsuario)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMensajesUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEventoMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEventoMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvioMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoReservacion;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMensaje;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBandejaDeMensajes;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesiónAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox pbMensajesRegresarUser;
    }
}