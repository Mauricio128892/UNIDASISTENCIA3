using UNID.Repository.Repositories;
using UNID.Data.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace UNID.UI
{
    // Asegúrate de que esta clase sea public partial class FrmGestionProfesores : Form
    public partial class FrmGestionProfesores : Form
    {
        // Instancia del repositorio que hace el trabajo CRUD en MySQL
        private ProfesorRepository _profesorRepo = new ProfesorRepository();

        public FrmGestionProfesores()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------
        // UTILIDAD: Limpia las cajas de texto después de guardar
        // ----------------------------------------------------
        private void LimpiarCampos()
        {
            // Asumiendo que los nombres son txtNombre, txtCorreo, txtIdLector, txtColorHex
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtIdLector.Text = string.Empty;
            txtColorHex.Text = string.Empty;
        }

        // ----------------------------------------------------
        // READ: Lógica para cargar los datos de MySQL
        // ----------------------------------------------------
        private void CargarProfesores()
        {
            try
            {
                List<Profesor> lista = _profesorRepo.GetAll();
                dataGridView1.DataSource = lista;

                // **VERIFICACIÓN CLAVE DE DATOS VACÍOS**
                if (lista.Count == 0)
                {
                    // Si la lista está vacía, muestra una advertencia de que la conexión es buena, pero no hay datos.
                    MessageBox.Show("Conexión exitosa, pero la tabla de profesores está vacía. Agrega un nuevo registro.", "Advertencia de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Configuración de la UI (para que el usuario lo entienda mejor)
                dataGridView1.Columns["IdLectorBiometrico"].HeaderText = "ID Lector";
                dataGridView1.Columns["ColorDisplayHex"].HeaderText = "Color HEX";
            }
            catch (Exception ex)
            {
                // Si la conexión falla (contraseña o servidor caído), el error aparece aquí.
                MessageBox.Show("ERROR DE CONEXIÓN A MYSQL: " + ex.Message, "Fallo Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // EVENTOS DE LA INTERFAZ
        // ----------------------------------------------------

        // 1. Evento Load (Carga Inicial al abrir el formulario)
        private void FrmGestionProfesores_Load(object sender, EventArgs e)
        {
            CargarProfesores();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarProfesores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdLector.Text))
            {
                MessageBox.Show("Los campos Nombre y ID Lector son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nuevoProfesor = new Profesor
                {
                    NombreCompleto = txtNombre.Text,
                    CorreoElectronico = txtCorreo.Text,
                    IdLectorBiometrico = txtIdLector.Text, // Corregido el error tipográfico
                    ColorDisplayHex = txtColorHex.Text,
                    Activo = true
                };

                _profesorRepo.Add(nuevoProfesor);

                MessageBox.Show("¡Profesor guardado con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProfesores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar. Causa: Revise el ID de Lector (debe ser único). Detalle: " + ex.Message, "Error de Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Evento Click del botón Cargar (btnCargar)




        // ***************************************************************
        // MÉTODOS DE EVENTO ADICIONALES (DEJADOS AQUÍ PARA SINCORNIZACIÓN)
        // ***************************************************************

        // Si el diseñador creó otros métodos de click o change, como:
        // private void txtNombre_TextChanged(object sender, EventArgs e) { }
        // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        // déjalos vacíos o bórralos del diseñador si te causan conflicto.
    }
}