﻿namespace ProyectoFinal.Formularios
{
    partial class ModificarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEvento));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEventos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.lblNotaMod = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.cmbEventos);
            this.panel3.Location = new System.Drawing.Point(58, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 78);
            this.panel3.TabIndex = 12;
            // 
            // cmbEventos
            // 
            this.cmbEventos.BackColor = System.Drawing.Color.Transparent;
            this.cmbEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEventos.ItemHeight = 30;
            this.cmbEventos.Location = new System.Drawing.Point(8, 5);
            this.cmbEventos.Name = "cmbEventos";
            this.cmbEventos.Size = new System.Drawing.Size(228, 36);
            this.cmbEventos.TabIndex = 5;
            this.cmbEventos.Click += new System.EventHandler(this.cmbEventos_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
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
            this.txtBuscar.Location = new System.Drawing.Point(317, 286);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar Evento";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(317, 40);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscar.Image = global::ProyectoFinal.Properties.Resources.magnify_glass_149876321;
            this.pbBuscar.Location = new System.Drawing.Point(670, 284);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(38, 42);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pbLogoUAM);
            this.panel1.Location = new System.Drawing.Point(56, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 85);
            this.panel1.TabIndex = 10;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(868, 3);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(138, 68);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2PanelMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2PanelMenu.Controls.Add(this.guna2TileButton1);
            this.guna2PanelMenu.Controls.Add(this.pbMensajes);
            this.guna2PanelMenu.Controls.Add(this.btnCerrarSesiónAdmin);
            this.guna2PanelMenu.Controls.Add(this.label3);
            this.guna2PanelMenu.Controls.Add(this.label2);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pbAdministrador);
            this.guna2PanelMenu.Controls.Add(this.pbInicio);
            this.guna2PanelMenu.Location = new System.Drawing.Point(-2, -2);
            this.guna2PanelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.ShadowDecoration.BorderRadius = 10;
            this.guna2PanelMenu.ShadowDecoration.Color = System.Drawing.Color.SandyBrown;
            this.guna2PanelMenu.Size = new System.Drawing.Size(60, 568);
            this.guna2PanelMenu.TabIndex = 15;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Animated = true;
            this.guna2TileButton1.AnimatedGIF = true;
            this.guna2TileButton1.AutoRoundedCorners = true;
            this.guna2TileButton1.BorderRadius = 18;
            this.guna2TileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton1.DefaultAutoSize = true;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.Red;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Location = new System.Drawing.Point(82, 509);
            this.guna2TileButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(149, 38);
            this.guna2TileButton1.TabIndex = 21;
            this.guna2TileButton1.Tag = "Cerrar Sesión";
            this.guna2TileButton1.Text = "Cerrar Sesión";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // pbMensajes
            // 
            this.pbMensajes.Image = global::ProyectoFinal.Properties.Resources.chat_45180341;
            this.pbMensajes.Location = new System.Drawing.Point(128, 232);
            this.pbMensajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(72, 69);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 20;
            this.pbMensajes.TabStop = false;
            this.pbMensajes.Click += new System.EventHandler(this.pbMensajes_Click);
            // 
            // btnCerrarSesiónAdmin
            // 
            this.btnCerrarSesiónAdmin.Animated = true;
            this.btnCerrarSesiónAdmin.AnimatedGIF = true;
            this.btnCerrarSesiónAdmin.AutoRoundedCorners = true;
            this.btnCerrarSesiónAdmin.BorderRadius = 18;
            this.btnCerrarSesiónAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesiónAdmin.DefaultAutoSize = true;
            this.btnCerrarSesiónAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesiónAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesiónAdmin.FillColor = System.Drawing.Color.Red;
            this.btnCerrarSesiónAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesiónAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesiónAdmin.Location = new System.Drawing.Point(69, 605);
            this.btnCerrarSesiónAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesiónAdmin.Name = "btnCerrarSesiónAdmin";
            this.btnCerrarSesiónAdmin.Size = new System.Drawing.Size(149, 38);
            this.btnCerrarSesiónAdmin.TabIndex = 18;
            this.btnCerrarSesiónAdmin.Tag = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Text = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Click += new System.EventHandler(this.btnCerrarSesiónAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inicio";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Image = global::ProyectoFinal.Properties.Resources.settings_13895453;
            this.btnToggleMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.InitialImage")));
            this.btnToggleMenu.Location = new System.Drawing.Point(4, 78);
            this.btnToggleMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(45, 45);
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
            this.pbAdministrador.Location = new System.Drawing.Point(-3, 5);
            this.pbAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(58, 49);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrador.TabIndex = 19;
            this.pbAdministrador.TabStop = false;
            // 
            // pbInicio
            // 
            this.pbInicio.BackColor = System.Drawing.Color.Transparent;
            this.pbInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInicio.Image = global::ProyectoFinal.Properties.Resources.home_100230672;
            this.pbInicio.Location = new System.Drawing.Point(128, 100);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(66, 69);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 0;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // lblNotaMod
            // 
            this.lblNotaMod.AutoSize = true;
            this.lblNotaMod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaMod.ForeColor = System.Drawing.Color.Black;
            this.lblNotaMod.Location = new System.Drawing.Point(311, 356);
            this.lblNotaMod.Name = "lblNotaMod";
            this.lblNotaMod.Size = new System.Drawing.Size(396, 32);
            this.lblNotaMod.TabIndex = 16;
            this.lblNotaMod.Text = "Busca tu evento para Editar";
            // 
            // ModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 563);
            this.Controls.Add(this.lblNotaMod);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarEvento";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Modificar Evento";
            this.Load += new System.EventHandler(this.ModificarEvento_Load_1);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoUAM;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEventos;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private System.Windows.Forms.PictureBox pbMensajes;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesiónAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox pbInicio;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private System.Windows.Forms.Label lblNotaMod;
    }
}