namespace UNID.UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnGestionProfesores = new System.Windows.Forms.Button();
            this.btnGestionHorarios = new System.Windows.Forms.Button();
            this.btnMonitoreo = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.curvedPanel1 = new UNID.UI.CustomControls.CurvedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.curvedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionProfesores
            // 
            this.btnGestionProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnGestionProfesores.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProfesores.Location = new System.Drawing.Point(22, 18);
            this.btnGestionProfesores.Name = "btnGestionProfesores";
            this.btnGestionProfesores.Size = new System.Drawing.Size(325, 72);
            this.btnGestionProfesores.TabIndex = 0;
            this.btnGestionProfesores.Text = "Gestor de Profesores";
            this.btnGestionProfesores.UseVisualStyleBackColor = false;
            this.btnGestionProfesores.Click += new System.EventHandler(this.btnGestionProfesores_Click);
            // 
            // btnGestionHorarios
            // 
            this.btnGestionHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnGestionHorarios.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionHorarios.Location = new System.Drawing.Point(392, 119);
            this.btnGestionHorarios.Name = "btnGestionHorarios";
            this.btnGestionHorarios.Size = new System.Drawing.Size(325, 72);
            this.btnGestionHorarios.TabIndex = 1;
            this.btnGestionHorarios.Text = "Gestor de Horarios";
            this.btnGestionHorarios.UseVisualStyleBackColor = false;
            this.btnGestionHorarios.Click += new System.EventHandler(this.btnGestionHorarios_Click);
            // 
            // btnMonitoreo
            // 
            this.btnMonitoreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnMonitoreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoreo.Location = new System.Drawing.Point(22, 119);
            this.btnMonitoreo.Name = "btnMonitoreo";
            this.btnMonitoreo.Size = new System.Drawing.Size(325, 72);
            this.btnMonitoreo.TabIndex = 2;
            this.btnMonitoreo.Text = "Monitoreo de Asistencia";
            this.btnMonitoreo.UseVisualStyleBackColor = false;
            this.btnMonitoreo.Click += new System.EventHandler(this.btnMonitoreo_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(392, 18);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(325, 72);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Exportar PDF";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // curvedPanel1
            // 
            this.curvedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.curvedPanel1.BorderRadius = 15;
            this.curvedPanel1.Controls.Add(this.btnGestionProfesores);
            this.curvedPanel1.Controls.Add(this.btnReportes);
            this.curvedPanel1.Controls.Add(this.btnGestionHorarios);
            this.curvedPanel1.Controls.Add(this.btnMonitoreo);
            this.curvedPanel1.Location = new System.Drawing.Point(29, 219);
            this.curvedPanel1.Name = "curvedPanel1";
            this.curvedPanel1.Size = new System.Drawing.Size(740, 219);
            this.curvedPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lector De Huella Digital UNID";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.curvedPanel1);
            this.Name = "FrmPrincipal";
            this.Text = " ";
            this.curvedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionProfesores;
        private System.Windows.Forms.Button btnGestionHorarios;
        private System.Windows.Forms.Button btnMonitoreo;
        private System.Windows.Forms.Button btnReportes;
        private CustomControls.CurvedPanel curvedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}