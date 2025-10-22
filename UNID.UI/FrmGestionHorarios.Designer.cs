namespace UNID.UI
{
    partial class FrmGestionHorarios
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabAsignaturas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarAsignatura = new System.Windows.Forms.Button();
            this.btnGuardarAsignatura = new System.Windows.Forms.Button();
            this.txtLicenciatura = new System.Windows.Forms.TextBox();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.TabHorarios = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.cmbAsignatura = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.btnGuardarHorario = new System.Windows.Forms.Button();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabAsignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.TabHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabAsignaturas);
            this.tabControl1.Controls.Add(this.TabHorarios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // TabAsignaturas
            // 
            this.TabAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.TabAsignaturas.Controls.Add(this.label2);
            this.TabAsignaturas.Controls.Add(this.label1);
            this.TabAsignaturas.Controls.Add(this.btnCargarAsignatura);
            this.TabAsignaturas.Controls.Add(this.btnGuardarAsignatura);
            this.TabAsignaturas.Controls.Add(this.txtLicenciatura);
            this.TabAsignaturas.Controls.Add(this.txtNombreClase);
            this.TabAsignaturas.Controls.Add(this.dgvAsignaturas);
            this.TabAsignaturas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TabAsignaturas.Location = new System.Drawing.Point(4, 22);
            this.TabAsignaturas.Name = "TabAsignaturas";
            this.TabAsignaturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabAsignaturas.Size = new System.Drawing.Size(768, 410);
            this.TabAsignaturas.TabIndex = 0;
            this.TabAsignaturas.Text = "ASIGNATURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Licenciatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de Clase";
            // 
            // btnCargarAsignatura
            // 
            this.btnCargarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnCargarAsignatura.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAsignatura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarAsignatura.Location = new System.Drawing.Point(623, 25);
            this.btnCargarAsignatura.Name = "btnCargarAsignatura";
            this.btnCargarAsignatura.Size = new System.Drawing.Size(100, 44);
            this.btnCargarAsignatura.TabIndex = 4;
            this.btnCargarAsignatura.Text = "Cargar";
            this.btnCargarAsignatura.UseVisualStyleBackColor = false;
            this.btnCargarAsignatura.Click += new System.EventHandler(this.btnCargarAsignatura_Click);
            // 
            // btnGuardarAsignatura
            // 
            this.btnGuardarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnGuardarAsignatura.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsignatura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarAsignatura.Location = new System.Drawing.Point(517, 25);
            this.btnGuardarAsignatura.Name = "btnGuardarAsignatura";
            this.btnGuardarAsignatura.Size = new System.Drawing.Size(100, 44);
            this.btnGuardarAsignatura.TabIndex = 3;
            this.btnGuardarAsignatura.Text = "Guardar";
            this.btnGuardarAsignatura.UseVisualStyleBackColor = false;
            this.btnGuardarAsignatura.Click += new System.EventHandler(this.btnGuardarAsignatura_Click);
            // 
            // txtLicenciatura
            // 
            this.txtLicenciatura.Location = new System.Drawing.Point(256, 39);
            this.txtLicenciatura.Name = "txtLicenciatura";
            this.txtLicenciatura.Size = new System.Drawing.Size(207, 20);
            this.txtLicenciatura.TabIndex = 2;
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(24, 39);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(191, 20);
            this.txtNombreClase.TabIndex = 1;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Location = new System.Drawing.Point(24, 77);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.Size = new System.Drawing.Size(699, 315);
            this.dgvAsignaturas.TabIndex = 0;
            // 
            // TabHorarios
            // 
            this.TabHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.TabHorarios.Controls.Add(this.label8);
            this.TabHorarios.Controls.Add(this.label7);
            this.TabHorarios.Controls.Add(this.label6);
            this.TabHorarios.Controls.Add(this.label5);
            this.TabHorarios.Controls.Add(this.label4);
            this.TabHorarios.Controls.Add(this.label3);
            this.TabHorarios.Controls.Add(this.txtHoraSalida);
            this.TabHorarios.Controls.Add(this.txtHoraEntrada);
            this.TabHorarios.Controls.Add(this.cmbAsignatura);
            this.TabHorarios.Controls.Add(this.cmbProfesor);
            this.TabHorarios.Controls.Add(this.btnGuardarHorario);
            this.TabHorarios.Controls.Add(this.txtSalon);
            this.TabHorarios.Controls.Add(this.txtDiaSemana);
            this.TabHorarios.Controls.Add(this.dgvHorarios);
            this.TabHorarios.Location = new System.Drawing.Point(4, 22);
            this.TabHorarios.Name = "TabHorarios";
            this.TabHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.TabHorarios.Size = new System.Drawing.Size(768, 410);
            this.TabHorarios.TabIndex = 1;
            this.TabHorarios.Text = "HORARIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Licenciatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesor";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(421, 96);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(146, 20);
            this.txtHoraSalida.TabIndex = 7;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(250, 96);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(146, 20);
            this.txtHoraEntrada.TabIndex = 6;
            // 
            // cmbAsignatura
            // 
            this.cmbAsignatura.FormattingEnabled = true;
            this.cmbAsignatura.Location = new System.Drawing.Point(38, 96);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.Size = new System.Drawing.Size(185, 21);
            this.cmbAsignatura.TabIndex = 5;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(38, 42);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(185, 21);
            this.cmbProfesor.TabIndex = 4;
            // 
            // btnGuardarHorario
            // 
            this.btnGuardarHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnGuardarHorario.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHorario.Location = new System.Drawing.Point(611, 42);
            this.btnGuardarHorario.Name = "btnGuardarHorario";
            this.btnGuardarHorario.Size = new System.Drawing.Size(119, 75);
            this.btnGuardarHorario.TabIndex = 3;
            this.btnGuardarHorario.Text = "Guardar";
            this.btnGuardarHorario.UseVisualStyleBackColor = false;
            this.btnGuardarHorario.Click += new System.EventHandler(this.btnGuardarHorario_Click);
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(421, 43);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(146, 20);
            this.txtSalon.TabIndex = 2;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(250, 42);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(146, 20);
            this.txtDiaSemana.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(25, 132);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(723, 259);
            this.dgvHorarios.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(246, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dia de la Semana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(417, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salón";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(246, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora de Entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(417, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hora de Salida";
            // 
            // FrmGestionHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGestionHorarios";
            this.Text = "FrmGestionHorarios";
            this.tabControl1.ResumeLayout(false);
            this.TabAsignaturas.ResumeLayout(false);
            this.TabAsignaturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.TabHorarios.ResumeLayout(false);
            this.TabHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAsignaturas;
        private System.Windows.Forms.TabPage TabHorarios;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.Button btnGuardarAsignatura;
        private System.Windows.Forms.TextBox txtLicenciatura;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.ComboBox cmbAsignatura;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Button btnGuardarHorario;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.Button btnCargarAsignatura;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}