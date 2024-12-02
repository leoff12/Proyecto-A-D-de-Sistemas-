﻿namespace ProyectoFinal.Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEliminar));
            this.dgvEventos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvNumeroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEventos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventos.ColumnHeadersHeight = 22;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNumeroEvento,
            this.dgvNombreEvento,
            this.dgvDescripcion,
            this.dgvFecha});
            this.dgvEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvEventos.Location = new System.Drawing.Point(33, 118);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowHeadersWidth = 62;
            this.dgvEventos.RowTemplate.Height = 28;
            this.dgvEventos.Size = new System.Drawing.Size(679, 247);
            this.dgvEventos.TabIndex = 18;
            this.dgvEventos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dgvEventos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEventos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvEventos.ThemeStyle.ReadOnly = false;
            this.dgvEventos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvEventos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEventos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEventos.ThemeStyle.RowsStyle.Height = 28;
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dgvNumeroEvento
            // 
            this.dgvNumeroEvento.HeaderText = "Número del Evento";
            this.dgvNumeroEvento.MinimumWidth = 8;
            this.dgvNumeroEvento.Name = "dgvNumeroEvento";
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.cmbEventos);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.pbBuscar);
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
            this.cmbEventos.Location = new System.Drawing.Point(5, 2);
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
            this.txtBuscar.Location = new System.Drawing.Point(465, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar Evento";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(158, 30);
            this.txtBuscar.TabIndex = 4;
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pbBuscar.Image = global::ProyectoFinal.Properties.Resources.magnify_glass_14987632;
            this.pbBuscar.Location = new System.Drawing.Point(628, 8);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 30);
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
            this.panel1.Location = new System.Drawing.Point(33, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 55);
            this.panel1.TabIndex = 15;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(547, 4);
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
            // BuscarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarEliminar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.BuscarEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
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
    }
}