namespace ProyectoFinal.Formularios
{
    partial class BuscarEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEliminar));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEventos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.lblNotaElim = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.cmbEventos);
            this.panel3.Location = new System.Drawing.Point(35, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 42);
            this.panel3.TabIndex = 17;
            // 
            // cmbEventos
            // 
            this.cmbEventos.BackColor = System.Drawing.Color.Transparent;
            this.cmbEventos.BorderRadius = 5;
            this.cmbEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEventos.ItemHeight = 30;
            this.cmbEventos.Location = new System.Drawing.Point(5, 4);
            this.cmbEventos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEventos.Name = "cmbEventos";
            this.cmbEventos.Size = new System.Drawing.Size(153, 36);
            this.cmbEventos.TabIndex = 5;
            this.cmbEventos.Click += new System.EventHandler(this.cmbEventos_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Animated = true;
            this.txtBuscar.BorderRadius = 5;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(206, 198);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar Evento";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(215, 30);
            this.txtBuscar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pbLogoUAM);
            this.panel1.Location = new System.Drawing.Point(33, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 49);
            this.panel1.TabIndex = 15;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(560, 0);
            this.pbLogoUAM.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(119, 49);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
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
            this.guna2PanelMenu.Location = new System.Drawing.Point(0, -1);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.ShadowDecoration.BorderRadius = 10;
            this.guna2PanelMenu.ShadowDecoration.Color = System.Drawing.Color.SandyBrown;
            this.guna2PanelMenu.Size = new System.Drawing.Size(35, 366);
            this.guna2PanelMenu.TabIndex = 19;
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
            this.pbAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("pbAdministrador.Image")));
            this.pbAdministrador.ImageRotate = 0F;
            this.pbAdministrador.Location = new System.Drawing.Point(-2, 3);
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
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // lblNotaElim
            // 
            this.lblNotaElim.AutoSize = true;
            this.lblNotaElim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaElim.ForeColor = System.Drawing.Color.Black;
            this.lblNotaElim.Location = new System.Drawing.Point(202, 242);
            this.lblNotaElim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotaElim.Name = "lblNotaElim";
            this.lblNotaElim.Size = new System.Drawing.Size(283, 22);
            this.lblNotaElim.TabIndex = 20;
            this.lblNotaElim.Text = "Busca tu evento para Eliminar";
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::ProyectoFinal.Properties.Resources.magnify_glass_14987632;
            this.pbBuscar.Location = new System.Drawing.Point(445, 198);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 30);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.lblNotaElim);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarEliminar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Buscar Eliminar";
            this.Load += new System.EventHandler(this.BuscarEliminar_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEventos;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoUAM;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesiónAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.Label lblNotaElim;
    }
}