using UNID.Repository.Repositories;
using UNID.Data.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing; // Necesario para la clase Image
using System.IO;     // Necesario para File.Exists y manejo de archivos
using System.Linq;

namespace UNID.UI
{
    public partial class FrmGestionProfesores : Form
    {
        // Instancia del repositorio que hace el trabajo CRUD en MySQL
        private ProfesorRepository _profesorRepo = new ProfesorRepository();

        // Variable de clase para almacenar la ruta temporal de la nueva foto seleccionada (global)
        private string _rutaFotoSeleccionada = null;

        // Variable para guardar el ID del profesor seleccionado/editado (global)
        private int _idProfesorSeleccionado = 0;

        public FrmGestionProfesores()
        {
            InitializeComponent();
            // Bloquea la escritura en el campo de ID Interno
            txtIdProfesor.ReadOnly = true;
        }

        // ----------------------------------------------------
        // UTILIDADES Y CARGA DE DATOS
        // ----------------------------------------------------
        private void LimpiarCampos()
        {
            txtIdProfesor.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtIdLector.Text = string.Empty;
            txtColorHex.Text = string.Empty;

            // Limpia variables y PictureBox
            _rutaFotoSeleccionada = null;
            _idProfesorSeleccionado = 0;
            pbFotoPerfil.Image = null; // Limpia la imagen del PictureBox
        }

        // Dentro de FrmGestionProfesores.cs

        private void CargarProfesores()
        {
            try
            {
                // 1. CARGA DE DATOS: (Esto crea todas las columnas de texto)
                List<Profesor> lista = _profesorRepo.GetAll();
                dataGridView1.DataSource = lista;

                // 🛑 CORRECCIÓN CRÍTICA: ELIMINAR LA COLUMNA DE IMAGEN SI YA EXISTE 🛑
                if (dataGridView1.Columns.Contains("FotoPerfil"))
                {
                    dataGridView1.Columns.Remove("FotoPerfil");
                }

                // 2. CREAR LA COLUMNA DE IMAGEN Y CONFIGURAR
                DataGridViewImageColumn imgColumna = new DataGridViewImageColumn();
                imgColumna.Name = "FotoPerfil";
                imgColumna.HeaderText = "Foto";
                imgColumna.ImageLayout = DataGridViewImageCellLayout.Zoom;

                // Insertar la nueva columna de imagen al inicio
                dataGridView1.Columns.Insert(1, imgColumna);

                // 3. Ocultar la columna de texto de la ruta (Ya no la necesitamos)
                if (dataGridView1.Columns.Contains("RutaFotoPerfil"))
                {
                    dataGridView1.Columns["RutaFotoPerfil"].Visible = false;
                }

                // 4. LLENAR LA COLUMNA DE IMAGEN Y AJUSTAR FILAS
                dataGridView1.RowTemplate.Height = 70;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Obtener la ruta guardada desde la lista de objetos
                    // La lista ya está cargada con la propiedad RutaFotoPerfil
                    string ruta = lista[row.Index].RutaFotoPerfil;

                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                    {
                        // 🛑 SOLUCIÓN CRÍTICA: Copiar el stream de bytes para evitar bloqueo 🛑

                        // 1. Abrir un FileStream para leer el archivo
                        using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                        {
                            // 2. Usar un MemoryStream para crear una copia que C# pueda usar libremente
                            using (MemoryStream ms = new MemoryStream())
                            {
                                fs.CopyTo(ms);
                                // 3. Crear la imagen a partir de la copia en memoria
                                row.Cells["FotoPerfil"].Value = Image.FromStream(ms);
                            }
                        }
                    }
                }

                // ... (El resto de la configuración de UI)
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR: " + ex.Message, "Fallo Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // EVENTOS DE LA INTERFAZ
        // ----------------------------------------------------

        private void FrmGestionProfesores_Load(object sender, EventArgs e)
        {
            CargarProfesores();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarProfesores();
        }

        // 🛑 NUEVO EVENTO: Seleccionar Foto 🛑
        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guarda la ruta temporal y muestra la previsualización
                _rutaFotoSeleccionada = openFileDialog.FileName;

                // Muestra la imagen en el PictureBox
                pbFotoPerfil.Image = Image.FromFile(_rutaFotoSeleccionada);
            }
        }

        // ----------------------------------------------------
        // MÉTODOS CRUD - CREATE Y UPDATE (INSERTA Y EDITA)
        // ----------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdLector.Text))
            {
                MessageBox.Show("Los campos Nombre y ID Lector son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mapear los datos de los TextBoxes a un objeto Profesor
                var profesor = new Profesor
                {
                    IdProfesor = _idProfesorSeleccionado, // Usado para UPDATE (si > 0)
                    NombreCompleto = txtNombre.Text,
                    CorreoElectronico = txtCorreo.Text,
                    IdLectorBiometrico = txtIdLector.Text,
                    ColorDisplayHex = txtColorHex.Text,
                    Activo = true
                };

                // LÓGICA DE LA FOTO: Si la ruta temporal existe, se asigna al objeto
                if (!string.IsNullOrEmpty(_rutaFotoSeleccionada))
                {
                    profesor.RutaFotoPerfil = _rutaFotoSeleccionada;
                }

                // CRUCIAL: Necesitas el valor de RutaFotoPerfil si es una actualización
                else if (_idProfesorSeleccionado > 0)
                {
                    // Lógica para mantener la ruta de la foto si no se seleccionó una nueva
                    // Esto requiere una lectura del perfil antes de actualizar, o 
                    // simplemente dejar que la DB actualice el resto de los campos.
                    // Para simplificar, asumimos que el repositorio UPDATE maneja el campo NULL si es vacío.
                }


                if (_idProfesorSeleccionado == 0)
                {
                    // CREATE: Insertar un nuevo profesor
                    _profesorRepo.Add(profesor);
                    MessageBox.Show("¡Profesor guardado con éxito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE: Actualizar el profesor existente
                    _profesorRepo.Update(profesor); // Asume que ya implementaste el método Update
                    MessageBox.Show("¡Profesor actualizado con éxito!", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarProfesores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // MÉTODOS CRUD - READ AL CLIC (Carga de datos a TextBoxes)
        // ----------------------------------------------------
        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 1. Guardar el ID interno y la ruta para la edición/baja
                _idProfesorSeleccionado = int.Parse(row.Cells["IdProfesor"].Value.ToString());
                txtIdProfesor.Text = _idProfesorSeleccionado.ToString();

                // **Ajuste:** Usamos 'object' para manejar el valor DBNull si la ruta es nula
                object rutaObj = row.Cells["RutaFotoPerfil"].Value;
                string rutaFoto = rutaObj?.ToString();

                // 2. Mapear los datos de la fila a los TextBoxes
                txtNombre.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtCorreo.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txtIdLector.Text = row.Cells["IdLectorBiometrico"].Value.ToString();
                txtColorHex.Text = row.Cells["ColorDisplayHex"].Value.ToString();

                // 3. Cargar la imagen si la ruta existe (Lógica que resuelve el bloqueo)
                pbFotoPerfil.Image = null; // Limpiar PictureBox primero

                if (!string.IsNullOrEmpty(rutaFoto) && File.Exists(rutaFoto))
                {
                    // Creamos una copia del archivo en memoria para evitar el bloqueo del archivo original
                    try
                    {
                        using (FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read))
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            // IMPORTANTE: Asignar una copia de la imagen en memoria
                            pbFotoPerfil.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar la imagen del perfil. Motivo: " + ex.Message, "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbFotoPerfil.Image = null;
                    }
                }
                // Si no hay ruta o el archivo no existe, el PictureBox se queda vacío (null)
            }
        }

        // ----------------------------------------------------
        // MÉTODOS CRUD - DELETE LÓGICO
        // ----------------------------------------------------
        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (_idProfesorSeleccionado <= 0)
            {
                MessageBox.Show("Debe seleccionar un profesor de la lista para desactivar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Está seguro de desactivar al profesor con ID {_idProfesorSeleccionado}?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _profesorRepo.Desactivar(_idProfesorSeleccionado);
                MessageBox.Show("Profesor desactivado con éxito.", "Baja Exitosa");
                CargarProfesores();
                LimpiarCampos();
            }
        }

        // El resto de los métodos generados por el diseñador (si existen, déjalos vacíos)
    }
}