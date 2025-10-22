using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNID.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionProfesores_Click(object sender, EventArgs e)
        {
            // Cierra el menú y abre la ventana de gestión
            this.Hide();
            FrmGestionProfesores form = new FrmGestionProfesores();
            form.ShowDialog();
            this.Show(); // Muestra el menú de nuevo al cerrar el formulario hijo
        }

        private void btnGestionHorarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGestionHorarios form = new FrmGestionHorarios();
            form.ShowDialog();
            this.Show();
        }

        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMonitoreoAsistencia form = new FrmMonitoreoAsistencia();
            form.ShowDialog();
            this.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReportes form = new FrmReportes();
            form.ShowDialog();
            this.Show();
        }
    }
}
