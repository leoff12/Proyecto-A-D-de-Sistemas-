﻿namespace ProyectoFinal
{
    partial class UniEventHub
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniEventHub));
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdministrador.Location = new System.Drawing.Point(464, 303);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(123, 32);
            this.btnAdministrador.TabIndex = 0;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUsuario.Location = new System.Drawing.Point(156, 303);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(123, 32);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(147, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(477, 60);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "UAM - UniEventHub";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(270, 69);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(222, 46);
            this.lblSaludo.TabIndex = 3;
            this.lblSaludo.Text = "¡Bienvenido!";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(285, 132);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(182, 22);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Selecciones su cargo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 18);
            this.panel1.TabIndex = 5;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(135, 208);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(164, 95);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 6;
            this.pbUsuario.TabStop = false;
            // 
            // pbAdministrador
            // 
            this.pbAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("pbAdministrador.Image")));
            this.pbAdministrador.Location = new System.Drawing.Point(440, 206);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(164, 95);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrador.TabIndex = 7;
            this.pbAdministrador.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.lblSaludo);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 117);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(-2, 417);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 26);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(12, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 18);
            this.panel4.TabIndex = 10;
            // 
            // UniEventHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(783, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbAdministrador);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAdministrador);
            this.Name = "UniEventHub";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbAdministrador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

