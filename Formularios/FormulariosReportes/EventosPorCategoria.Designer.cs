namespace ProyectoFinal.Formularios.FormulariosReportes
{
    partial class EventosPorCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosPorCategoria));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbRegresarReporteCategoria = new System.Windows.Forms.PictureBox();
            this.lblRegresarToReportes = new System.Windows.Forms.Label();
            this.pbMas = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresarReporteCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(117, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1211, 617);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pbRegresarReporteCategoria);
            this.panel2.Controls.Add(this.lblRegresarToReportes);
            this.panel2.Controls.Add(this.pbMas);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 664);
            this.panel2.TabIndex = 8;
            // 
            // pbRegresarReporteCategoria
            // 
            this.pbRegresarReporteCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRegresarReporteCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pbRegresarReporteCategoria.Image")));
            this.pbRegresarReporteCategoria.Location = new System.Drawing.Point(32, 88);
            this.pbRegresarReporteCategoria.Name = "pbRegresarReporteCategoria";
            this.pbRegresarReporteCategoria.Size = new System.Drawing.Size(46, 52);
            this.pbRegresarReporteCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegresarReporteCategoria.TabIndex = 3;
            this.pbRegresarReporteCategoria.TabStop = false;
            this.pbRegresarReporteCategoria.Click += new System.EventHandler(this.pbRegresarReporteCategoria_Click);
            // 
            // lblRegresarToReportes
            // 
            this.lblRegresarToReportes.AutoSize = true;
            this.lblRegresarToReportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresarToReportes.Location = new System.Drawing.Point(13, 143);
            this.lblRegresarToReportes.Name = "lblRegresarToReportes";
            this.lblRegresarToReportes.Size = new System.Drawing.Size(97, 27);
            this.lblRegresarToReportes.TabIndex = 3;
            this.lblRegresarToReportes.Text = "Regresar";
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
            // EventosPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EventosPorCategoria";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "EventosPorCategoria";
            this.Load += new System.EventHandler(this.EventosPorCategoria_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresarReporteCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbRegresarReporteCategoria;
        private System.Windows.Forms.Label lblRegresarToReportes;
        private System.Windows.Forms.PictureBox pbMas;
    }
}