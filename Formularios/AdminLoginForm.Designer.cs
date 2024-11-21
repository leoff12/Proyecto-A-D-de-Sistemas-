﻿namespace ProyectoFinal.Formularios
{
    partial class AdminLoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserAdm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseñaAdm = new System.Windows.Forms.TextBox();
            this.btnAccAdm = new System.Windows.Forms.Button();
            this.btnRegreAdm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 333);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(415, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UniEventHub - Inicio de Sesión Administrado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor, Ingrese sus credenciales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario";
            // 
            // txtUserAdm
            // 
            this.txtUserAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserAdm.Location = new System.Drawing.Point(412, 115);
            this.txtUserAdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserAdm.Name = "txtUserAdm";
            this.txtUserAdm.Size = new System.Drawing.Size(191, 20);
            this.txtUserAdm.TabIndex = 7;
            this.txtUserAdm.Text = "Ingrese el nombre de administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // txtContraseñaAdm
            // 
            this.txtContraseñaAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAdm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContraseñaAdm.Location = new System.Drawing.Point(402, 176);
            this.txtContraseñaAdm.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaAdm.Name = "txtContraseñaAdm";
            this.txtContraseñaAdm.Size = new System.Drawing.Size(201, 20);
            this.txtContraseñaAdm.TabIndex = 9;
            this.txtContraseñaAdm.Text = "Ingrese su contraseña";
            this.txtContraseñaAdm.TextChanged += new System.EventHandler(this.txtContraseñaAdm_TextChanged);
            // 
            // btnAccAdm
            // 
            this.btnAccAdm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccAdm.Location = new System.Drawing.Point(328, 235);
            this.btnAccAdm.Name = "btnAccAdm";
            this.btnAccAdm.Size = new System.Drawing.Size(75, 23);
            this.btnAccAdm.TabIndex = 10;
            this.btnAccAdm.Text = "Aceder";
            this.btnAccAdm.UseVisualStyleBackColor = false;
            this.btnAccAdm.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnRegreAdm
            // 
            this.btnRegreAdm.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegreAdm.Location = new System.Drawing.Point(601, 235);
            this.btnRegreAdm.Name = "btnRegreAdm";
            this.btnRegreAdm.Size = new System.Drawing.Size(75, 23);
            this.btnRegreAdm.TabIndex = 11;
            this.btnRegreAdm.Text = "Regresar";
            this.btnRegreAdm.UseVisualStyleBackColor = false;
            this.btnRegreAdm.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // AdminLoginForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.Controls.Add(this.btnRegreAdm);
            this.Controls.Add(this.btnAccAdm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseñaAdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserAdm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "AdminLoginForm";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserAdm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseñaAdm;
        private System.Windows.Forms.Button btnAccAdm;
        private System.Windows.Forms.Button btnRegreAdm;
    }
}