﻿namespace ProyectoFinal.Formularios
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarEvent = new System.Windows.Forms.Button();
            this.btnModEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.guna2PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.pbMensajesAdmin = new System.Windows.Forms.PictureBox();
            this.btnToggleMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnCerrarSesiónAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(64, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 165);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarSesiónAdmin
            // 
            this.btnCerrarSesiónAdmin.Animated = true;
            this.btnCerrarSesiónAdmin.AnimatedGIF = true;
            this.btnCerrarSesiónAdmin.AutoRoundedCorners = true;
            this.btnCerrarSesiónAdmin.BorderRadius = 24;
            this.btnCerrarSesiónAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesiónAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesiónAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesiónAdmin.FillColor = System.Drawing.Color.Red;
            this.btnCerrarSesiónAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesiónAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesiónAdmin.Location = new System.Drawing.Point(812, 105);
            this.btnCerrarSesiónAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesiónAdmin.Name = "btnCerrarSesiónAdmin";
            this.btnCerrarSesiónAdmin.Size = new System.Drawing.Size(170, 51);
            this.btnCerrarSesiónAdmin.TabIndex = 18;
            this.btnCerrarSesiónAdmin.Text = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Click += new System.EventHandler(this.btnCerrarSesiónAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnBorrarEvent);
            this.panel2.Controls.Add(this.btnModEvent);
            this.panel2.Controls.Add(this.btnAddEvent);
            this.panel2.Location = new System.Drawing.Point(64, 218);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 292);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBorrarEvent
            // 
            this.btnBorrarEvent.BackColor = System.Drawing.Color.LightBlue;
            this.btnBorrarEvent.Location = new System.Drawing.Point(702, 185);
            this.btnBorrarEvent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBorrarEvent.Name = "btnBorrarEvent";
            this.btnBorrarEvent.Size = new System.Drawing.Size(198, 35);
            this.btnBorrarEvent.TabIndex = 2;
            this.btnBorrarEvent.Text = "Borrar Evento";
            this.btnBorrarEvent.UseVisualStyleBackColor = false;
            // 
            // btnModEvent
            // 
            this.btnModEvent.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModEvent.Location = new System.Drawing.Point(398, 185);
            this.btnModEvent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModEvent.Name = "btnModEvent";
            this.btnModEvent.Size = new System.Drawing.Size(186, 35);
            this.btnModEvent.TabIndex = 1;
            this.btnModEvent.Text = "Modificar Evento";
            this.btnModEvent.UseVisualStyleBackColor = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddEvent.Location = new System.Drawing.Point(60, 185);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(216, 35);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Añadir Evento";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.button1_Click);
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
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(72, 172);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(67, 25);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // guna2PanelMenu
            // 
            this.guna2PanelMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2PanelMenu.Controls.Add(this.pbMensajesAdmin);
            this.guna2PanelMenu.Controls.Add(this.label2);
            this.guna2PanelMenu.Controls.Add(this.lblInicio);
            this.guna2PanelMenu.Controls.Add(this.btnToggleMenu);
            this.guna2PanelMenu.Controls.Add(this.pictureBox6);
            this.guna2PanelMenu.Controls.Add(this.pictureBox5);
            this.guna2PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PanelMenu.Name = "guna2PanelMenu";
            this.guna2PanelMenu.Size = new System.Drawing.Size(60, 511);
            this.guna2PanelMenu.TabIndex = 3;
            // 
            // pbMensajesAdmin
            // 
            this.pbMensajesAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajesAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajesAdmin.Image")));
            this.pbMensajesAdmin.Location = new System.Drawing.Point(4, 115);
            this.pbMensajesAdmin.Name = "pbMensajesAdmin";
            this.pbMensajesAdmin.Size = new System.Drawing.Size(49, 52);
            this.pbMensajesAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajesAdmin.TabIndex = 6;
            this.pbMensajesAdmin.TabStop = false;
            this.pbMensajesAdmin.Click += new System.EventHandler(this.pbMensajesAdmin_Click);
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
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoFinal.Properties.Resources.borrar;
            this.pictureBox4.Location = new System.Drawing.Point(744, 42);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources.modificar;
            this.pictureBox3.Location = new System.Drawing.Point(446, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.boton_agregar;
            this.pictureBox2.Location = new System.Drawing.Point(108, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 508);
            this.Controls.Add(this.guna2PanelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2PanelMenu.ResumeLayout(false);
            this.guna2PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrarEvent;
        private System.Windows.Forms.Button btnModEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInicio;
        private Guna.UI2.WinForms.Guna2TileButton btnCerrarSesiónAdmin;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox btnToggleMenu;
        private System.Windows.Forms.PictureBox pbMensajesAdmin;
    }
}