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
            this.lblTitulo.Location = new System.Drawing.Point(540, 83);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 81);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "UAM - UniEventHub";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(626, 14);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(241, 69);
            this.lblSaludo.TabIndex = 3;
            this.lblSaludo.Text = "¡Bienvenido!";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(638, 206);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(230, 25);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Selecciones su cargo:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 15;
            this.metroPanel1.Location = new System.Drawing.Point(0, -3);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(448, 515);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.Imagen_de_WhatsApp_2024_11_22_a_las_00_001;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbAdministrador
            // 
            this.pbAdministrador.Image = global::ProyectoFinal.Properties.Resources._16344954;
            this.pbAdministrador.ImageRotate = 0F;
            this.pbAdministrador.Location = new System.Drawing.Point(554, 278);
            this.pbAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(144, 125);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrador.TabIndex = 10;
            this.pbAdministrador.TabStop = false;
            this.pbAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::ProyectoFinal.Properties.Resources._67654f6b2a7d10436445455b1458935f;
            this.pbUsuario.ImageRotate = 0F;
            this.pbUsuario.Location = new System.Drawing.Point(818, 278);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(128, 125);
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
            this.btnAdministrador.BorderRadius = 24;
            this.btnAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdministrador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdministrador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdministrador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(538, 412);
            this.btnAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(174, 51);
            this.btnAdministrador.TabIndex = 11;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Animated = true;
            this.btnUsuario.AnimatedGIF = true;
            this.btnUsuario.AutoRoundedCorners = true;
            this.btnUsuario.BorderRadius = 24;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(795, 412);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(170, 51);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // UniEventHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1065, 508);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.pbAdministrador);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblCargo);
            this.Name = "UniEventHub";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Página Principal";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.Load += new System.EventHandler(this.UniEventHub_Load_1);
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