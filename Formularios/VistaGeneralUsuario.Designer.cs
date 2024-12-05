namespace ProyectoFinal.Formularios
{
    partial class VistaGeneralUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaGeneralUsuario));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscarEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.lblBienvenidoUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2TileButton();
            this.dgvEventos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExaminar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.txtBuscarEvento);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.lblBienvenidoUsuario);
            this.panel3.Location = new System.Drawing.Point(47, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 42);
            this.panel3.TabIndex = 2;
            // 
            // txtBuscarEvento
            // 
            this.txtBuscarEvento.BorderRadius = 5;
            this.txtBuscarEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEvento.DefaultText = "";
            this.txtBuscarEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEvento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEvento.Location = new System.Drawing.Point(465, 9);
            this.txtBuscarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarEvento.Name = "txtBuscarEvento";
            this.txtBuscarEvento.PasswordChar = '\0';
            this.txtBuscarEvento.PlaceholderText = "Buscar Evento";
            this.txtBuscarEvento.SelectedText = "";
            this.txtBuscarEvento.Size = new System.Drawing.Size(152, 26);
            this.txtBuscarEvento.TabIndex = 4;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::ProyectoFinal.Properties.Resources.magnify_glass_14987632;
            this.pbBuscar.Location = new System.Drawing.Point(623, 7);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(25, 27);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // lblBienvenidoUsuario
            // 
            this.lblBienvenidoUsuario.AutoSize = true;
            this.lblBienvenidoUsuario.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBienvenidoUsuario.Location = new System.Drawing.Point(5, 7);
            this.lblBienvenidoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenidoUsuario.Name = "lblBienvenidoUsuario";
            this.lblBienvenidoUsuario.Size = new System.Drawing.Size(393, 21);
            this.lblBienvenidoUsuario.TabIndex = 0;
            this.lblBienvenidoUsuario.Text = "¡Bienvenido! Conoce nuestros eventos disponibles";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Animated = true;
            this.btnCerrarSesion.AnimatedGIF = true;
            this.btnCerrarSesion.AutoRoundedCorners = true;
            this.btnCerrarSesion.BorderRadius = 14;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.FillColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(47, 323);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(122, 30);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Tag = "Cerrar Sesión";
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // dgvEventos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventos.ColumnHeadersHeight = 22;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombreEvento,
            this.dgvDescripcion,
            this.dgvFecha});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvEventos.Location = new System.Drawing.Point(47, 123);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowHeadersWidth = 62;
            this.dgvEventos.RowTemplate.Height = 28;
            this.dgvEventos.Size = new System.Drawing.Size(663, 195);
            this.dgvEventos.TabIndex = 9;
            this.dgvEventos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEventos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvEventos.ThemeStyle.ReadOnly = false;
            this.dgvEventos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvEventos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEventos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEventos.ThemeStyle.RowsStyle.Height = 28;
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick_1);
            // 
            // dgvNombreEvento
            // 
            this.dgvNombreEvento.HeaderText = "Nombre del Evento";
            this.dgvNombreEvento.MinimumWidth = 8;
            this.dgvNombreEvento.Name = "dgvNombreEvento";
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.HeaderText = "Descripción del Evento";
            this.dgvDescripcion.MinimumWidth = 8;
            this.dgvDescripcion.Name = "dgvDescripcion";
            // 
            // dgvFecha
            // 
            this.dgvFecha.HeaderText = "Fecha del Evento";
            this.dgvFecha.MinimumWidth = 8;
            this.dgvFecha.Name = "dgvFecha";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Animated = true;
            this.btnExaminar.AnimatedGIF = true;
            this.btnExaminar.AutoRoundedCorners = true;
            this.btnExaminar.BorderRadius = 13;
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExaminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExaminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExaminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExaminar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(290, 322);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(181, 29);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar Evento";
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(47, 19);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(663, 63);
            this.guna2GradientPanel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2PanelMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2PanelMenu.Controls.Add(this.btnCerrarSesion);
            this.guna2PanelMenu.Controls.Add(this.label2);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pbAdministrador);
            this.guna2PanelMenu.Controls.Add(this.pbMensajes);
            this.guna2PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.ShadowDecoration.BorderRadius = 10;
            this.guna2PanelMenu.ShadowDecoration.Color = System.Drawing.Color.SandyBrown;
            this.guna2PanelMenu.Size = new System.Drawing.Size(47, 368);
            this.guna2PanelMenu.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensajes";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pbMensajes.Location = new System.Drawing.Point(79, 96);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(44, 42);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 1;
            this.pbMensajes.TabStop = false;
            this.pbMensajes.Click += new System.EventHandler(this.pbMensajes_Click);
            // 
            // VistaGeneralUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panel3);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaGeneralUsuario";
            this.Padding = new System.Windows.Forms.Padding(13, 30, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.VistaGeneralUsuario_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBienvenidoUsuario;
        private System.Windows.Forms.PictureBox pbBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarEvento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEventos;
        private Guna.UI2.WinForms.Guna2Button btnExaminar;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}