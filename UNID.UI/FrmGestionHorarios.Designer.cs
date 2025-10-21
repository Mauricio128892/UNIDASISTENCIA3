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
            this.btnCargarAsignatura = new System.Windows.Forms.Button();
            this.btnGuardarAsignatura = new System.Windows.Forms.Button();
            this.txtLicenciatura = new System.Windows.Forms.TextBox();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.TabHorarios = new System.Windows.Forms.TabPage();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.cmbAsignatura = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.btnGuardarHorario = new System.Windows.Forms.Button();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.TabAsignaturas.Controls.Add(this.btnCargarAsignatura);
            this.TabAsignaturas.Controls.Add(this.btnGuardarAsignatura);
            this.TabAsignaturas.Controls.Add(this.txtLicenciatura);
            this.TabAsignaturas.Controls.Add(this.txtNombreClase);
            this.TabAsignaturas.Controls.Add(this.dgvAsignaturas);
            this.TabAsignaturas.Location = new System.Drawing.Point(4, 22);
            this.TabAsignaturas.Name = "TabAsignaturas";
            this.TabAsignaturas.Padding = new System.Windows.Forms.Padding(3);
            this.TabAsignaturas.Size = new System.Drawing.Size(768, 410);
            this.TabAsignaturas.TabIndex = 0;
            this.TabAsignaturas.Text = "ASIG";
            this.TabAsignaturas.UseVisualStyleBackColor = true;
            // 
            // btnCargarAsignatura
            // 
            this.btnCargarAsignatura.Location = new System.Drawing.Point(623, 25);
            this.btnCargarAsignatura.Name = "btnCargarAsignatura";
            this.btnCargarAsignatura.Size = new System.Drawing.Size(100, 44);
            this.btnCargarAsignatura.TabIndex = 4;
            this.btnCargarAsignatura.Text = "Cargar";
            this.btnCargarAsignatura.UseVisualStyleBackColor = true;
            this.btnCargarAsignatura.Click += new System.EventHandler(this.btnCargarAsignatura_Click);
            // 
            // btnGuardarAsignatura
            // 
            this.btnGuardarAsignatura.Location = new System.Drawing.Point(517, 25);
            this.btnGuardarAsignatura.Name = "btnGuardarAsignatura";
            this.btnGuardarAsignatura.Size = new System.Drawing.Size(100, 46);
            this.btnGuardarAsignatura.TabIndex = 3;
            this.btnGuardarAsignatura.Text = "Guardar";
            this.btnGuardarAsignatura.UseVisualStyleBackColor = true;
            this.btnGuardarAsignatura.Click += new System.EventHandler(this.btnGuardarAsignatura_Click);
            // 
            // txtLicenciatura
            // 
            this.txtLicenciatura.Location = new System.Drawing.Point(146, 39);
            this.txtLicenciatura.Name = "txtLicenciatura";
            this.txtLicenciatura.Size = new System.Drawing.Size(100, 20);
            this.txtLicenciatura.TabIndex = 2;
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(24, 39);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(100, 20);
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
            this.TabHorarios.Size = new System.Drawing.Size(648, 327);
            this.TabHorarios.TabIndex = 1;
            this.TabHorarios.Text = "HORAR";
            this.TabHorarios.UseVisualStyleBackColor = true;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(356, 97);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSalida.TabIndex = 7;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(250, 97);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEntrada.TabIndex = 6;
            // 
            // cmbAsignatura
            // 
            this.cmbAsignatura.FormattingEnabled = true;
            this.cmbAsignatura.Location = new System.Drawing.Point(193, 42);
            this.cmbAsignatura.Name = "cmbAsignatura";
            this.cmbAsignatura.Size = new System.Drawing.Size(121, 21);
            this.cmbAsignatura.TabIndex = 5;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(38, 42);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesor.TabIndex = 4;
            // 
            // btnGuardarHorario
            // 
            this.btnGuardarHorario.Location = new System.Drawing.Point(554, 119);
            this.btnGuardarHorario.Name = "btnGuardarHorario";
            this.btnGuardarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarHorario.TabIndex = 3;
            this.btnGuardarHorario.Text = "button1";
            this.btnGuardarHorario.UseVisualStyleBackColor = true;
            this.btnGuardarHorario.Click += new System.EventHandler(this.btnGuardarHorario_Click);
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(144, 97);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(100, 20);
            this.txtSalon.TabIndex = 2;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(38, 97);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(100, 20);
            this.txtDiaSemana.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(38, 148);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.Size = new System.Drawing.Size(591, 150);
            this.dgvHorarios.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmGestionHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}