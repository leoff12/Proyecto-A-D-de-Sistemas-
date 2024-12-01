namespace ProyectoFinal.Formularios
{
    partial class MensajesUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajesUsuario));
            this.dgvMensajesUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreEventoMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEventoMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvioMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblBandejaDeMensajes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMensajesRegresarUser = new System.Windows.Forms.PictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.btnEliminarMensaje = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesUsuario)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMensajesUsuario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensajesUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMensajesUsuario.ColumnHeadersHeight = 22;
            this.dgvMensajesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMensajesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEventoMensaje,
            this.FechaEventoMensaje,
            this.FechaEnvioMensaje,
            this.EstadoReservacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMensajesUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMensajesUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesUsuario.Location = new System.Drawing.Point(119, 106);
            this.dgvMensajesUsuario.Name = "dgvMensajesUsuario";
            this.dgvMensajesUsuario.RowHeadersVisible = false;
            this.dgvMensajesUsuario.RowHeadersWidth = 62;
            this.dgvMensajesUsuario.RowTemplate.Height = 28;
            this.dgvMensajesUsuario.Size = new System.Drawing.Size(976, 380);
            this.dgvMensajesUsuario.TabIndex = 8;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMensajesUsuario.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvMensajesUsuario.ThemeStyle.ReadOnly = false;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // NombreEventoMensaje
            // 
            this.NombreEventoMensaje.HeaderText = "Nombre del Evento";
            this.NombreEventoMensaje.MinimumWidth = 8;
            this.NombreEventoMensaje.Name = "NombreEventoMensaje";
            this.NombreEventoMensaje.ReadOnly = true;
            // 
            // FechaEventoMensaje
            // 
            this.FechaEventoMensaje.HeaderText = "Fecha del Evento";
            this.FechaEventoMensaje.MinimumWidth = 8;
            this.FechaEventoMensaje.Name = "FechaEventoMensaje";
            this.FechaEventoMensaje.ReadOnly = true;
            // 
            // FechaEnvioMensaje
            // 
            this.FechaEnvioMensaje.HeaderText = "Fecha de Envío del Mensaje";
            this.FechaEnvioMensaje.MinimumWidth = 8;
            this.FechaEnvioMensaje.Name = "FechaEnvioMensaje";
            this.FechaEnvioMensaje.ReadOnly = true;
            // 
            // EstadoReservacion
            // 
            this.EstadoReservacion.HeaderText = "Estado de la Reservación";
            this.EstadoReservacion.MinimumWidth = 8;
            this.EstadoReservacion.Name = "EstadoReservacion";
            this.EstadoReservacion.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblBandejaDeMensajes);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(119, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Brown;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(976, 100);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // lblBandejaDeMensajes
            // 
            this.lblBandejaDeMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lblBandejaDeMensajes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandejaDeMensajes.Location = new System.Drawing.Point(18, 33);
            this.lblBandejaDeMensajes.Name = "lblBandejaDeMensajes";
            this.lblBandejaDeMensajes.Size = new System.Drawing.Size(417, 48);
            this.lblBandejaDeMensajes.TabIndex = 0;
            this.lblBandejaDeMensajes.Text = "Bandeja de Mensajes";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbMensajesRegresarUser);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 592);
            this.panel2.TabIndex = 6;
            // 
            // pbMensajesRegresarUser
            // 
            this.pbMensajesRegresarUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajesRegresarUser.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajesRegresarUser.Image")));
            this.pbMensajesRegresarUser.Location = new System.Drawing.Point(32, 88);
            this.pbMensajesRegresarUser.Name = "pbMensajesRegresarUser";
            this.pbMensajesRegresarUser.Size = new System.Drawing.Size(46, 52);
            this.pbMensajesRegresarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajesRegresarUser.TabIndex = 3;
            this.pbMensajesRegresarUser.TabStop = false;
            this.pbMensajesRegresarUser.Click += new System.EventHandler(this.pbMensajesRegresarUser_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(13, 143);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(97, 27);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Regresar";
            // 
            // pbMas
            // 
            this.pbMas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(32, 12);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(46, 49);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // btnEliminarMensaje
            // 
            this.btnEliminarMensaje.BorderRadius = 24;
            this.btnEliminarMensaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMensaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarMensaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarMensaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarMensaje.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMensaje.Location = new System.Drawing.Point(874, 514);
            this.btnEliminarMensaje.Name = "btnEliminarMensaje";
            this.btnEliminarMensaje.Size = new System.Drawing.Size(210, 45);
            this.btnEliminarMensaje.TabIndex = 14;
            this.btnEliminarMensaje.Text = "Eliminar Mensaje";
            this.btnEliminarMensaje.Click += new System.EventHandler(this.btnEliminarMensaje_Click);
            // 
            // MensajesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 586);
            this.Controls.Add(this.btnEliminarMensaje);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.dgvMensajesUsuario);
            this.Name = "MensajesUsuario";
            this.Text = "MensajesUsuario";
            this.Load += new System.EventHandler(this.MensajesUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesUsuario)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMensajesUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEventoMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEventoMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvioMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoReservacion;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBandejaDeMensajes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMensajesRegresarUser;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private Guna.UI2.WinForms.Guna2Button btnEliminarMensaje;
    }
}