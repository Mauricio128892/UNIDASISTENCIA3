using UNID.Repository.Repositories;
using System;
using System.Windows.Forms;
using System.Data;

namespace UNID.UI
{
    public partial class FrmMonitoreoAsistencia : Form
    {
        private AsistenciaRepository _asistenciaRepo = new AsistenciaRepository();

        public FrmMonitoreoAsistencia()
        {
            InitializeComponent();

            // 🛑 LLAMADA CORREGIDA: Llama a la carga directamente aquí
            CargarMonitoreo(DateTime.Today);
        }

        private void CargarMonitoreo(DateTime fechaSeleccionada)
        {
            try
            {
                // Llama al repositorio para obtener la asistencia del día (JOIN)
                DataTable resultados = _asistenciaRepo.GetAsistenciaReporte(
     fechaSeleccionada.Date, // Fecha de inicio
     fechaSeleccionada.Date, // Fecha de fin (para un solo día)
     0                       // ID del profesor: 0 para indicar que queremos TODOS los profesores
 );

                // Asigna la fuente de datos al DataGridView (dgvMonitoreo)
                dgvMonitoreo.DataSource = resultados;

                if (resultados.Rows.Count == 0)
                {
                    MessageBox.Show($"No se encontraron registros de asistencia para el día: {fechaSeleccionada.ToShortDateString()}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar monitoreo: " + ex.Message, "Error Crítico de Monitoreo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Load: Carga la asistencia de hoy por defecto
        private void FrmMonitoreoAsistencia_Load(object sender, EventArgs e)
        {
            // Deja este método vacío o solo con la configuración visual, 
            // ya que la carga de datos ya se hizo en el constructor.
            // dtpFecha.Value = DateTime.Today; // Si quieres mantener la fecha
        }

        // Evento Click del botón Recargar (o cambio de fecha)
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            // Asume que tienes un botón btnRecargar y un DateTimePicker dtpFecha
            CargarMonitoreo(dtpFecha.Value);
        }
    }
}