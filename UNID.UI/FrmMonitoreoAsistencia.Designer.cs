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
            this.label1 = new System.Windows.Forms.Label();
            this.curvedPanel1 = new UNID.UI.CustomControls.CurvedPanel();
            this.curvedPanel2 = new UNID.UI.CustomControls.CurvedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoreo)).BeginInit();
            this.curvedPanel1.SuspendLayout();
            this.curvedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonitoreo
            // 
            this.dgvMonitoreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitoreo.Location = new System.Drawing.Point(20, 105);
            this.dgvMonitoreo.Name = "dgvMonitoreo";
            this.dgvMonitoreo.Size = new System.Drawing.Size(704, 291);
            this.dgvMonitoreo.TabIndex = 0;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnRecargar.FlatAppearance.BorderSize = 4;
            this.btnRecargar.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(606, 18);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(118, 76);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFecha.Location = new System.Drawing.Point(16, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(207, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione la Fecha Deseada";
            // 
            // curvedPanel1
            // 
            this.curvedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.curvedPanel1.BorderRadius = 15;
            this.curvedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.curvedPanel1.Controls.Add(this.label1);
            this.curvedPanel1.Controls.Add(this.btnRecargar);
            this.curvedPanel1.Controls.Add(this.curvedPanel2);
            this.curvedPanel1.Controls.Add(this.dgvMonitoreo);
            this.curvedPanel1.Location = new System.Drawing.Point(24, 12);
            this.curvedPanel1.Name = "curvedPanel1";
            this.curvedPanel1.Size = new System.Drawing.Size(740, 415);
            this.curvedPanel1.TabIndex = 5;
            // 
            // curvedPanel2
            // 
            this.curvedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.curvedPanel2.BorderRadius = 15;
            this.curvedPanel2.Controls.Add(this.dtpFecha);
            this.curvedPanel2.Location = new System.Drawing.Point(20, 51);
            this.curvedPanel2.Name = "curvedPanel2";
            this.curvedPanel2.Size = new System.Drawing.Size(236, 43);
            this.curvedPanel2.TabIndex = 4;
            // 
            // FrmMonitoreoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.curvedPanel1);
            this.Name = "FrmMonitoreoAsistencia";
            this.Text = "FrmMonitoreoAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitoreo)).EndInit();
            this.curvedPanel1.ResumeLayout(false);
            this.curvedPanel1.PerformLayout();
            this.curvedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonitoreo;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private CustomControls.CurvedPanel curvedPanel1;
        private CustomControls.CurvedPanel curvedPanel2;
    }
}