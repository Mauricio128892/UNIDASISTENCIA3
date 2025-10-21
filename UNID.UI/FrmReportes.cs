using UNID.Repository.Repositories;
using UNID.Data.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;

// Librerías de iTextSharp
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UNID.UI
{
    public partial class FrmReportes : Form
    {
        // Instancias de los repositorios
        private ProfesorRepository _profesorRepo = new ProfesorRepository();
        private AsistenciaRepository _asistenciaRepo = new AsistenciaRepository();

        // 🛑 DECLARACIONES AÑADIDAS PARA RESOLVER EL ERROR CS0103 (FALLO DEL DISEÑADOR) 🛑
        // Esto asegura que el compilador sepa que existen estos controles en el formulario.
        
        


        public FrmReportes()
        {
            InitializeComponent();

            CargarFiltros();
        }



        // Método para llenar el ComboBox de Profesores
        private void CargarFiltros()
        {
            try
            {
                var profesores = _profesorRepo.GetAll();
                List<Profesor> listaFiltro = new List<Profesor>();

                // Opción para seleccionar TODOS (ID=0)
                listaFiltro.Add(new Profesor { IdProfesor = 0, NombreCompleto = "[TODOS LOS PROFESORES]" });
                listaFiltro.AddRange(profesores);

                // 🛑 SOLUCIÓN CRÍTICA: Desactivar y Forzar Enlace 🛑
                // Esto ayuda al control a refrescar y mostrar los datos.
                cmbProfesorFiltro.DataSource = null;

                // 1. Asignar la lista al ComboBox
                cmbProfesorFiltro.DataSource = listaFiltro;

                // 2. Forzar la reasignación de las propiedades de enlace
                cmbProfesorFiltro.DisplayMember = "NombreCompleto";
                cmbProfesorFiltro.ValueMember = "IdProfesor";

                // 3. Establecer el valor por defecto (para evitar el NullReferenceException al iniciar)
                cmbProfesorFiltro.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar filtros: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // FUNCIÓN: GENERACIÓN DEL PDF (CORRECCIÓN FINAL DE FUENTES)
        // ----------------------------------------------------
        private void GenerarPDF(DataTable datos, DateTime inicio, DateTime fin, string filtroProfesor)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento PDF (*.pdf)|*.pdf";
            sfd.FileName = $"Reporte_Tardanzas_{filtroProfesor}_{inicio.ToShortDateString().Replace("/", "-")}.pdf";
            sfd.Title = "Guardar Reporte PDF de Tardanzas";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Definir la fuente base (Usando la sintaxis completa para evitar errores CS01061)
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                    // 🛑 CORRECCIÓN: Usar la sintaxis completa iTextSharp.text.Font
                    iTextSharp.text.Font fontTitulo = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontEncabezado = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);


                    // 2. Crear el documento PDF
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();

                    // 3. Título y Metadata del Reporte
                    document.Add(new Paragraph("UNIVERSIDAD INTERAMERICANA PARA EL DESARROLLO (UNID)", fontTitulo));
                    document.Add(new Paragraph("REPORTE DE ASISTENCIA Y RETARDOS", fontEncabezado));
                    document.Add(new Paragraph($"Período: {inicio.ToShortDateString()} al {fin.ToShortDateString()}", fontNormal));
                    document.Add(new Paragraph($"Profesor Filtrado: {filtroProfesor}", fontNormal));
                    document.Add(new Paragraph("\n"));

                    // 4. Crear la tabla PDF y llenarla con el DataTable
                    PdfPTable pdfTable = new PdfPTable(datos.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    // Headers
                    foreach (DataColumn column in datos.Columns)
                    {
                        pdfTable.AddCell(new Phrase(column.ColumnName, fontEncabezado));
                    }

                    // Filas de Datos
                    foreach (DataRow row in datos.Rows)
                    {
                        foreach (DataColumn column in datos.Columns)
                        {
                            pdfTable.AddCell(new Phrase(row[column].ToString(), fontNormal));
                        }
                    }

                    // 5. Agregar tabla al documento y cerrarlo
                    document.Add(pdfTable);
                    document.Close();

                    MessageBox.Show("Reporte PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el PDF: " + ex.Message, "Error de PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ----------------------------------------------------
        // EVENTO CLICK DEL BOTÓN GENERAR PDF
        // ----------------------------------------------------
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener los valores de los filtros
                DateTime inicio = dtpFechaInicio.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;

                // Obtiene el ID del ComboBox (0 = TODOS). 
                // Esto funciona si cmbProfesorFiltro se cargó y SelectedValue tiene un valor (0 por defecto).
                int idProfesor = (int)cmbProfesorFiltro.SelectedValue;

                // 2. Obtener los datos filtrados del Repositorio
                DataTable datosReporte = _asistenciaRepo.GetAsistenciaReporte(inicio, fin, idProfesor);

                if (datosReporte.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros de tardanza para el rango seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3. Mostrar la previsualización (opcional)
                dgvReporte.DataSource = datosReporte;

                // 4. GENERAR EL PDF
                GenerarPDF(datosReporte, inicio, fin, cmbProfesorFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}