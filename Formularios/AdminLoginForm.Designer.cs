namespace ProyectoFinal.Formularios
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccAdm = new System.Windows.Forms.Button();
            this.btnRegreAdm = new System.Windows.Forms.Button();
            this.txtUserAdm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContraseñaAdm = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 333);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(46, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "UniEventHub";
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
            this.label2.Location = new System.Drawing.Point(297, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor, Ingrese sus credenciales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // btnAccAdm
            // 
            this.btnAccAdm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccAdm.Location = new System.Drawing.Point(301, 291);
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
            this.btnRegreAdm.Location = new System.Drawing.Point(619, 291);
            this.btnRegreAdm.Name = "btnRegreAdm";
            this.btnRegreAdm.Size = new System.Drawing.Size(75, 23);
            this.btnRegreAdm.TabIndex = 11;
            this.btnRegreAdm.Text = "Regresar";
            this.btnRegreAdm.UseVisualStyleBackColor = false;
            this.btnRegreAdm.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtUserAdm
            // 
            this.txtUserAdm.Animated = true;
            this.txtUserAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtUserAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserAdm.DefaultText = "INGRESE NOMBRE DE ADMINISTRADOR";
            this.txtUserAdm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserAdm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserAdm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAdm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAdm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserAdm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAdm.Location = new System.Drawing.Point(290, 79);
            this.txtUserAdm.Name = "txtUserAdm";
            this.txtUserAdm.PasswordChar = '\0';
            this.txtUserAdm.PlaceholderText = "";
            this.txtUserAdm.SelectedText = "";
            this.txtUserAdm.Size = new System.Drawing.Size(375, 30);
            this.txtUserAdm.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserAdm.TabIndex = 13;
            // 
            // txtContraseñaAdm
            // 
            this.txtContraseñaAdm.Animated = true;
            this.txtContraseñaAdm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtContraseñaAdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseñaAdm.DefaultText = "INGRESE SU CONTRASEÑA";
            this.txtContraseñaAdm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseñaAdm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseñaAdm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaAdm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaAdm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaAdm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContraseñaAdm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaAdm.Location = new System.Drawing.Point(290, 165);
            this.txtContraseñaAdm.Name = "txtContraseñaAdm";
            this.txtContraseñaAdm.PasswordChar = '\0';
            this.txtContraseñaAdm.PlaceholderText = "";
            this.txtContraseñaAdm.SelectedText = "";
            this.txtContraseñaAdm.Size = new System.Drawing.Size(375, 30);
            this.txtContraseñaAdm.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtContraseñaAdm.TabIndex = 15;
            // 
            // AdminLoginForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.Controls.Add(this.txtContraseñaAdm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegreAdm);
            this.Controls.Add(this.btnAccAdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserAdm);
            this.HelpButton = true;
            this.Name = "AdminLoginForm";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccAdm;
        private System.Windows.Forms.Button btnRegreAdm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserAdm;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseñaAdm;
    }
}