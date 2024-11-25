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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscarEvento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.lblBienvenidoUsuario = new System.Windows.Forms.Label();
            this.dgvEventos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvNumeroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExaminar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pbLogoUAM);
            this.panel1.Location = new System.Drawing.Point(116, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 85);
            this.panel1.TabIndex = 0;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(1037, 10);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(138, 68);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbMensajes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbInicio);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 728);
            this.panel2.TabIndex = 1;
            // 
            // pbMensajes
            // 
            this.pbMensajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajes.Image")));
            this.pbMensajes.Location = new System.Drawing.Point(32, 189);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(46, 52);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 5;
            this.pbMensajes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensajes";
            // 
            // pbInicio
            // 
            this.pbInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(32, 87);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(46, 52);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(23, 142);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(67, 27);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // pbMas
            // 
            this.pbMas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(32, 12);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(46, 48);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.txtBuscarEvento);
            this.panel3.Controls.Add(this.btnCerrarSesion);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Controls.Add(this.lblBienvenidoUsuario);
            this.panel3.Location = new System.Drawing.Point(118, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1199, 64);
            this.panel3.TabIndex = 2;
            // 
            // txtBuscarEvento
            // 
            this.txtBuscarEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEvento.DefaultText = "Buscar Evento";
            this.txtBuscarEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEvento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEvento.Location = new System.Drawing.Point(1006, 12);
            this.txtBuscarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarEvento.Name = "txtBuscarEvento";
            this.txtBuscarEvento.PasswordChar = '\0';
            this.txtBuscarEvento.PlaceholderText = "";
            this.txtBuscarEvento.SelectedText = "";
            this.txtBuscarEvento.Size = new System.Drawing.Size(128, 40);
            this.txtBuscarEvento.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(863, 11);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(136, 41);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(1141, 13);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(36, 39);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
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
            // dgvEventos
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEventos.ColumnHeadersHeight = 22;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNumeroEvento,
            this.dgvNombreEvento,
            this.dgvDescripcion,
            this.dgvFecha});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEventos.Location = new System.Drawing.Point(121, 194);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowHeadersWidth = 62;
            this.dgvEventos.RowTemplate.Height = 28;
            this.dgvEventos.Size = new System.Drawing.Size(1129, 465);
            this.dgvEventos.TabIndex = 9;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEventos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEventos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEventos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvEventos.ThemeStyle.ReadOnly = false;
            this.dgvEventos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEventos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEventos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEventos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEventos.ThemeStyle.RowsStyle.Height = 28;
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEventos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick_1);
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
            // btnExaminar
            // 
            this.btnExaminar.BorderRadius = 24;
            this.btnExaminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExaminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExaminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExaminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExaminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExaminar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(981, 665);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(271, 45);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar Evento";
            // 
            // VistaGeneralUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 765);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VistaGeneralUsuario";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "x";
            this.Load += new System.EventHandler(this.VistaGeneralUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
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
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarEvento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private Guna.UI2.WinForms.Guna2Button btnExaminar;
    }
}