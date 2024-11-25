namespace ProyectoFinal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbUsuario = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAdministrador = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnUsuario = new Guna.UI2.WinForms.Guna2TileButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(360, 54);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 54);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "UAM - UniEventHub";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(417, 9);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(161, 45);
            this.lblSaludo.TabIndex = 3;
            this.lblSaludo.Text = "¡Bienvenido!";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(425, 134);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(153, 16);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Selecciones su cargo:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(299, 335);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.Imagen_de_WhatsApp_2024_11_22_a_las_00_001;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbAdministrador
            // 
            this.pbAdministrador.Image = global::ProyectoFinal.Properties.Resources._16344954;
            this.pbAdministrador.ImageRotate = 0F;
            this.pbAdministrador.Location = new System.Drawing.Point(369, 181);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(96, 81);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrador.TabIndex = 10;
            this.pbAdministrador.TabStop = false;
            this.pbAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::ProyectoFinal.Properties.Resources._67654f6b2a7d10436445455b1458935f;
            this.pbUsuario.ImageRotate = 0F;
            this.pbUsuario.Location = new System.Drawing.Point(545, 181);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(85, 81);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 9;
            this.pbUsuario.TabStop = false;
            this.pbUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Animated = true;
            this.btnAdministrador.AnimatedGIF = true;
            this.btnAdministrador.AutoRoundedCorners = true;
            this.btnAdministrador.BorderRadius = 15;
            this.btnAdministrador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdministrador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdministrador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(359, 268);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(116, 33);
            this.btnAdministrador.TabIndex = 11;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Animated = true;
            this.btnUsuario.AnimatedGIF = true;
            this.btnUsuario.AutoRoundedCorners = true;
            this.btnUsuario.BorderRadius = 15;
            this.btnUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(530, 268);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(113, 33);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // UniEventHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.pbAdministrador);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblCargo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UniEventHub";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblCargo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pbUsuario;
        private Guna.UI2.WinForms.Guna2PictureBox pbAdministrador;
        private Guna.UI2.WinForms.Guna2TileButton btnAdministrador;
        private Guna.UI2.WinForms.Guna2TileButton btnUsuario;
    }
}