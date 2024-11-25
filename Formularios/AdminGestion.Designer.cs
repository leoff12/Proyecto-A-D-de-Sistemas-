namespace ProyectoFinal.Formularios
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
            this.btnCerrarSesiónAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBorrarEvent = new System.Windows.Forms.Button();
            this.btnModEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnCerrarSesiónAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(98, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 141);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarSesiónAdmin
            // 
            this.btnCerrarSesiónAdmin.BorderRadius = 24;
            this.btnCerrarSesiónAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesiónAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesiónAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesiónAdmin.FillColor = System.Drawing.Color.Red;
            this.btnCerrarSesiónAdmin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesiónAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesiónAdmin.Location = new System.Drawing.Point(754, 90);
            this.btnCerrarSesiónAdmin.Name = "btnCerrarSesiónAdmin";
            this.btnCerrarSesiónAdmin.Size = new System.Drawing.Size(180, 45);
            this.btnCerrarSesiónAdmin.TabIndex = 2;
            this.btnCerrarSesiónAdmin.Text = "Cerrar Sesión";
            this.btnCerrarSesiónAdmin.Click += new System.EventHandler(this.btnCerrarSesiónAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 77);
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
            this.label1.Location = new System.Drawing.Point(7, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnBorrarEvent);
            this.panel2.Controls.Add(this.btnModEvent);
            this.panel2.Controls.Add(this.btnAddEvent);
            this.panel2.Location = new System.Drawing.Point(98, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 366);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::ProyectoFinal.Properties.Resources.borrar;
            this.pictureBox4.Location = new System.Drawing.Point(465, 217);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources.modificar;
            this.pictureBox3.Location = new System.Drawing.Point(691, 60);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.boton_agregar;
            this.pictureBox2.Location = new System.Drawing.Point(213, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBorrarEvent
            // 
            this.btnBorrarEvent.BackColor = System.Drawing.Color.LightBlue;
            this.btnBorrarEvent.Location = new System.Drawing.Point(404, 295);
            this.btnBorrarEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.btnModEvent.Location = new System.Drawing.Point(639, 152);
            this.btnModEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModEvent.Name = "btnModEvent";
            this.btnModEvent.Size = new System.Drawing.Size(186, 35);
            this.btnModEvent.TabIndex = 1;
            this.btnModEvent.Text = "Modificar Evento";
            this.btnModEvent.UseVisualStyleBackColor = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddEvent.Location = new System.Drawing.Point(142, 152);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(216, 35);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Añadir Evento";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.pbMensajes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbInicio);
            this.panel3.Controls.Add(this.pbMas);
            this.panel3.Controls.Add(this.lblInicio);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 524);
            this.panel3.TabIndex = 3;
            // 
            // pbMensajes
            // 
            this.pbMensajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajes.Image")));
            this.pbMensajes.Location = new System.Drawing.Point(26, 169);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(46, 47);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 5;
            this.pbMensajes.TabStop = false;
            this.pbMensajes.Click += new System.EventHandler(this.pbMensajes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensajes";
            // 
            // pbInicio
            // 
            this.pbInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(29, 76);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(43, 43);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            // 
            // pbMas
            // 
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(29, 19);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(43, 41);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(19, 122);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(56, 22);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "AdminGestion";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private System.Windows.Forms.Label lblInicio;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesiónAdmin;
    }
}