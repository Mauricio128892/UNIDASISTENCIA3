namespace UNID.UI
{
    partial class FrmMonitoreoAsistencia
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
            this.dgvMonitoreo = new System.Windows.Forms.DataGridView();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoreo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonitoreo
            // 
            this.dgvMonitoreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoreo.Location = new System.Drawing.Point(57, 86);
            this.dgvMonitoreo.Name = "dgvMonitoreo";
            this.dgvMonitoreo.Size = new System.Drawing.Size(680, 331);
            this.dgvMonitoreo.TabIndex = 0;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(619, 36);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(118, 44);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(57, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(207, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // FrmMonitoreoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dgvMonitoreo);
            this.Name = "FrmMonitoreoAsistencia";
            this.Text = "FrmMonitoreoAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoreo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitoreo;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}