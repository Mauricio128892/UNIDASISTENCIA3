using UNID.Repository.Repositories;
using UNID.Data.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace UNID.UI
{
    public partial class FrmGestionHorarios : Form
    {
        // Instancias de los repositorios que hacen el trabajo CRUD en MySQL
        private AsignaturaRepository _asignaturaRepo = new AsignaturaRepository();
        private ProfesorRepository _profesorRepo = new ProfesorRepository(); // NECESARIO para ComboBox de Profesor
        private HorarioClaseRepository _horarioRepo = new HorarioClaseRepository(); // NECESARIO para dgvHorarios

        public FrmGestionHorarios()
        {
            InitializeComponent();

            // LLAMADA CORRECTA: Llama al método que carga todos los ComboBoxes
            CargarCatalogosHorarios();

            // Llama a la carga inicial del DataGridView de horarios
            CargarHorariosAsignados();

            CargarAsignaturas();
        }
        // ----------------------------------------------------
        // UTILIDADES Y CARGA DE DATOS PRINCIPAL
        // ----------------------------------------------------

        // Carga la lista de Asignaturas (para el DGV de la pestaña ASIG)
        private void CargarAsignaturas()
        {
            try
            {
                dgvAsignaturas.DataSource = _asignaturaRepo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaturas: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga la lista de Horarios asignados (para el DGV de la pestaña HORAR)
        private void CargarHorariosAsignados()
        {
            try
            {
                dgvHorarios.DataSource = _horarioRepo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar horarios: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los ComboBoxes (para la pestaña HORAR)
        private void CargarCatalogosHorarios()
        {
            try
            {
                // 1. Cargar Profesores al ComboBox
                var profesores = _profesorRepo.GetAll();
                cmbProfesor.DataSource = profesores;
                cmbProfesor.DisplayMember = "NombreCompleto";
                cmbProfesor.ValueMember = "IdProfesor";

                // 2. Cargar Asignaturas al ComboBox
                var asignaturas = _asignaturaRepo.GetAll();
                cmbAsignatura.DataSource = asignaturas;
                cmbAsignatura.DisplayMember = "NombreClase";
                cmbAsignatura.ValueMember = "IdAsignatura";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar catálogos: " + ex.Message, "Error de Catálogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // EVENTO LOAD (INICIO DEL FORMULARIO)
        // ----------------------------------------------------
        private void FrmGestionHorarios_Load(object sender, EventArgs e)
        {
            // Solo llama a la función principal de carga de datos para el Form_Load
            CargarTodo(); // <-- Creamos una nueva función maestra
            tabControl1.SelectedIndex = 0;
        }

        private void CargarTodo()
        {
            CargarAsignaturas(); // Carga DGV de Asignaturas
            CargarHorariosAsignados(); // Carga DGV de Horarios
            CargarCatalogosHorarios(); // Carga ComboBoxes (¡La clave!)
        }

        // ----------------------------------------------------
        // EVENTOS DE LA PESTAÑA ASIGNATURAS (FUNCIONALIDAD)
        // ----------------------------------------------------

        // Botón Guardar Asignatura (CREATE)
        private void btnGuardarAsignatura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreClase.Text) || string.IsNullOrWhiteSpace(txtLicenciatura.Text))
            {
                MessageBox.Show("Ambos campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nuevaAsignatura = new Asignatura
                {
                    NombreClase = txtNombreClase.Text,
                    Licenciatura = txtLicenciatura.Text,
                };

                _asignaturaRepo.Add(nuevaAsignatura);
                MessageBox.Show("¡Asignatura guardada con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar todo (incluidos los ComboBoxes de la otra pestaña)
                CargarAsignaturas();
                CargarCatalogosHorarios();
                txtNombreClase.Text = string.Empty;
                txtLicenciatura.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la asignatura: " + ex.Message, "Error en BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Cargar Asignatura (READ)
        private void btnCargarAsignatura_Click(object sender, EventArgs e)
        {
            CargarAsignaturas();
        }

        // ----------------------------------------------------
        // EVENTOS DE LA PESTAÑA HORARIOS (NUEVA LÓGICA)
        // ----------------------------------------------------

        // Botón Guardar Horario (CREATE)
        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            // 1. Validaciones: ComboBoxes seleccionados y formato de hora
            if (cmbProfesor.SelectedValue == null || cmbAsignatura.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtDiaSemana.Text) ||
                !TimeSpan.TryParse(txtHoraEntrada.Text, out TimeSpan horaEntrada) ||
                !TimeSpan.TryParse(txtHoraSalida.Text, out TimeSpan horaSalida))
            {
                MessageBox.Show("Debe seleccionar Profesor/Asignatura y el formato de hora debe ser válido (Ej: 08:00:00).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Crear el objeto HorarioClase
                var nuevoHorario = new HorarioClase
                {
                    // Convertir los valores seleccionados de los ComboBoxes a int (ID's)
                    IdProfesor = (int)cmbProfesor.SelectedValue,
                    IdAsignatura = (int)cmbAsignatura.SelectedValue,
                    DiaSemana = txtDiaSemana.Text,
                    SalonAsignado = txtSalon.Text,
                    HoraEntradaOficial = horaEntrada,
                    HoraSalidaOficial = horaSalida
                };

                // 3. Ejecutar el método ADD del Repositorio
                _horarioRepo.Add(nuevoHorario);

                MessageBox.Show("¡Horario asignado con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Recargar la lista de horarios y limpiar
                CargarHorariosAsignados();
                txtDiaSemana.Text = string.Empty;
                txtSalon.Text = string.Empty;
                txtHoraEntrada.Text = string.Empty;
                txtHoraSalida.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el horario: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}