namespace ProyectoFinal.Formularios
{
    partial class MensajesAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajesAdministrador));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblBandejaDeMensajes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMensajesAdmin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBorrarMensaje = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMensajesRegresarAdmin = new System.Windows.Forms.PictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRechazar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblBandejaDeMensajes);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(116, 1);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Brown;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(977, 100);
            this.guna2ShadowPanel1.TabIndex = 12;
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
            // dgvMensajesAdmin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMensajesAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensajesAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMensajesAdmin.ColumnHeadersHeight = 22;
            this.dgvMensajesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMensajesAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMensajesAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesAdmin.Location = new System.Drawing.Point(116, 107);
            this.dgvMensajesAdmin.Name = "dgvMensajesAdmin";
            this.dgvMensajesAdmin.RowHeadersVisible = false;
            this.dgvMensajesAdmin.RowHeadersWidth = 62;
            this.dgvMensajesAdmin.RowTemplate.Height = 28;
            this.dgvMensajesAdmin.Size = new System.Drawing.Size(977, 365);
            this.dgvMensajesAdmin.TabIndex = 11;
            this.dgvMensajesAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesAdmin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMensajesAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMensajesAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMensajesAdmin.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesAdmin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMensajesAdmin.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvMensajesAdmin.ThemeStyle.ReadOnly = false;
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMensajesAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBorrarMensaje
            // 
            this.btnBorrarMensaje.BorderRadius = 24;
            this.btnBorrarMensaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarMensaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrarMensaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrarMensaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrarMensaje.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMensaje.ForeColor = System.Drawing.Color.White;
            this.btnBorrarMensaje.Location = new System.Drawing.Point(180, 492);
            this.btnBorrarMensaje.Name = "btnBorrarMensaje";
            this.btnBorrarMensaje.Size = new System.Drawing.Size(210, 45);
            this.btnBorrarMensaje.TabIndex = 13;
            this.btnBorrarMensaje.Text = "Eliminar Mensaje";
            this.btnBorrarMensaje.Click += new System.EventHandler(this.btnEliminarMensaje_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbMensajesRegresarAdmin);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 592);
            this.panel2.TabIndex = 14;
            // 
            // pbMensajesRegresarAdmin
            // 
            this.pbMensajesRegresarAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajesRegresarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajesRegresarAdmin.Image")));
            this.pbMensajesRegresarAdmin.Location = new System.Drawing.Point(32, 88);
            this.pbMensajesRegresarAdmin.Name = "pbMensajesRegresarAdmin";
            this.pbMensajesRegresarAdmin.Size = new System.Drawing.Size(46, 52);
            this.pbMensajesRegresarAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajesRegresarAdmin.TabIndex = 3;
            this.pbMensajesRegresarAdmin.TabStop = false;
            this.pbMensajesRegresarAdmin.Click += new System.EventHandler(this.pbMensajesRegresarAdmin_Click);
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
            // btnAceptar
            // 
            this.btnAceptar.BorderRadius = 24;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(868, 492);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(210, 45);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.BorderRadius = 24;
            this.btnRechazar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRechazar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRechazar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRechazar.FillColor = System.Drawing.Color.Red;
            this.btnRechazar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.White;
            this.btnRechazar.Location = new System.Drawing.Point(639, 492);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(210, 45);
            this.btnRechazar.TabIndex = 16;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 24;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(410, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(210, 45);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MensajesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 586);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBorrarMensaje);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.dgvMensajesAdmin);
            this.Name = "MensajesAdministrador";
            this.Text = "MensajesAdministrador";
            this.Load += new System.EventHandler(this.MensajesAdministrador_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajesRegresarAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBandejaDeMensajes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMensajesAdmin;
        private Guna.UI2.WinForms.Guna2Button btnBorrarMensaje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMensajesRegresarAdmin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnRechazar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}