namespace ProyectoFinal.Formularios
{
    partial class VistaGeneralUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaGeneralUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBienvenidoUsuario = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.txtBuscarEvento = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pbLogoUAM);
            this.panel1.Location = new System.Drawing.Point(49, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 85);
            this.panel1.TabIndex = 0;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(612, 12);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(138, 67);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbMensajes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbInicio);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 451);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.btnCerrarSesion);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.txtBuscarEvento);
            this.panel3.Controls.Add(this.lblBienvenidoUsuario);
            this.panel3.Location = new System.Drawing.Point(49, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 42);
            this.panel3.TabIndex = 2;
            // 
            // lblBienvenidoUsuario
            // 
            this.lblBienvenidoUsuario.AutoSize = true;
            this.lblBienvenidoUsuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoUsuario.Location = new System.Drawing.Point(8, 11);
            this.lblBienvenidoUsuario.Name = "lblBienvenidoUsuario";
            this.lblBienvenidoUsuario.Size = new System.Drawing.Size(410, 22);
            this.lblBienvenidoUsuario.TabIndex = 0;
            this.lblBienvenidoUsuario.Text = "¡Bienvenido! Conoce nuestros eventos disponibles";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(11, 97);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 15);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // pbMas
            // 
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(14, 13);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(28, 27);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // pbInicio
            // 
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(14, 66);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(26, 28);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensajes";
            // 
            // pbMensajes
            // 
            this.pbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajes.Image")));
            this.pbMensajes.Location = new System.Drawing.Point(14, 123);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(26, 28);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 5;
            this.pbMensajes.TabStop = false;
            // 
            // txtBuscarEvento
            // 
            this.txtBuscarEvento.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEvento.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBuscarEvento.Location = new System.Drawing.Point(578, 6);
            this.txtBuscarEvento.Name = "txtBuscarEvento";
            this.txtBuscarEvento.Size = new System.Drawing.Size(128, 30);
            this.txtBuscarEvento.TabIndex = 1;
            this.txtBuscarEvento.Text = "Buscar Evento";
            this.txtBuscarEvento.TextChanged += new System.EventHandler(this.txtBuscarEvento_TextChanged);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(712, 8);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(27, 26);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(458, 6);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 30);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // VistaGeneralUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VistaGeneralUsuario";
            this.Text = "x";
            this.Load += new System.EventHandler(this.VistaGeneralUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoUAM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBienvenidoUsuario;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.TextBox txtBuscarEvento;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}