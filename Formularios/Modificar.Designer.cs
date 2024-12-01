namespace ProyectoFinal.Formularios
{
    partial class ModificarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEvento));
            this.dgvEventos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvNumeroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEventos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbMensajes = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.pbLogoUAM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventos.ColumnHeadersHeight = 22;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNumeroEvento,
            this.dgvNombreEvento,
            this.dgvDescripcion,
            this.dgvFecha});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEventos.Location = new System.Drawing.Point(89, 97);
            this.dgvEventos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.RowHeadersWidth = 62;
            this.dgvEventos.RowTemplate.Height = 28;
            this.dgvEventos.Size = new System.Drawing.Size(601, 245);
            this.dgvEventos.TabIndex = 14;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.cmbEventos);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Controls.Add(this.pbBuscar);
            this.panel3.Location = new System.Drawing.Point(84, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 42);
            this.panel3.TabIndex = 12;
            // 
            // cmbEventos
            // 
            this.cmbEventos.BackColor = System.Drawing.Color.Transparent;
            this.cmbEventos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEventos.ItemHeight = 30;
            this.cmbEventos.Location = new System.Drawing.Point(5, 3);
            this.cmbEventos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEventos.Name = "cmbEventos";
            this.cmbEventos.Size = new System.Drawing.Size(153, 36);
            this.cmbEventos.TabIndex = 5;
            this.cmbEventos.Click += new System.EventHandler(this.cmbEventos_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "Buscar Evento";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(455, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(138, 26);
            this.txtBuscar.TabIndex = 4;
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
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 384);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensajes";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(15, 92);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(42, 19);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Inicio";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pbLogoUAM);
            this.panel1.Location = new System.Drawing.Point(84, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 55);
            this.panel1.TabIndex = 10;
            // 
            // pbBuscar
            // 
            this.pbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(598, 10);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(25, 27);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbMensajes
            // 
            this.pbMensajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("pbMensajes.Image")));
            this.pbMensajes.Location = new System.Drawing.Point(21, 123);
            this.pbMensajes.Margin = new System.Windows.Forms.Padding(2);
            this.pbMensajes.Name = "pbMensajes";
            this.pbMensajes.Size = new System.Drawing.Size(32, 35);
            this.pbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMensajes.TabIndex = 5;
            this.pbMensajes.TabStop = false;
            // 
            // pbInicio
            // 
            this.pbInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInicio.Image = ((System.Drawing.Image)(resources.GetObject("pbInicio.Image")));
            this.pbInicio.Location = new System.Drawing.Point(21, 57);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(2);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(32, 35);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 3;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // pbMas
            // 
            this.pbMas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMas.Image = ((System.Drawing.Image)(resources.GetObject("pbMas.Image")));
            this.pbMas.Location = new System.Drawing.Point(21, 8);
            this.pbMas.Margin = new System.Windows.Forms.Padding(2);
            this.pbMas.Name = "pbMas";
            this.pbMas.Size = new System.Drawing.Size(32, 33);
            this.pbMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMas.TabIndex = 3;
            this.pbMas.TabStop = false;
            // 
            // pbLogoUAM
            // 
            this.pbLogoUAM.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoUAM.Image")));
            this.pbLogoUAM.Location = new System.Drawing.Point(416, 2);
            this.pbLogoUAM.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoUAM.Name = "pbLogoUAM";
            this.pbLogoUAM.Size = new System.Drawing.Size(92, 44);
            this.pbLogoUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoUAM.TabIndex = 2;
            this.pbLogoUAM.TabStop = false;
            // 
            // ModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 364);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarEvento";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Modificar Evento";
            this.Load += new System.EventHandler(this.ModificarEvento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNumeroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFecha;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox pbMas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoUAM;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEventos;
    }
}