using UNID.Data;
using UNID.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data; // Necesario para usar DataTable

namespace UNID.Repository.Repositories
{
    public class AsistenciaRepository
    {
        private readonly DBContext _dbContext = new DBContext();

        // ----------------------------------------------------
        // C - CREATE: Guardar el registro de asistencia calculado (Usado por el Servicio 24/7)
        // ----------------------------------------------------
        public void Add(AsistenciaCalculada resultado)
        {
            string sql = @"
                INSERT INTO Asistencia_Calculada (
                    ID_Horario, ID_Profesor, Fecha_Clase, Hora_Entrada_Real, 
                    Hora_Salida_Real, Minutos_Retardo, Estatus)
                VALUES (@idhorario, @idprofesor, @fecha, @entrada, 
                        @salida, @retardo, @estatus);";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@idhorario", resultado.IdHorario);
                    cmd.Parameters.AddWithValue("@idprofesor", resultado.IdProfesor);
                    cmd.Parameters.AddWithValue("@fecha", resultado.FechaClase);

                    // Manejo de valores nulos para las horas
                    cmd.Parameters.AddWithValue("@entrada", resultado.HoraEntradaReal.HasValue ? (object)resultado.HoraEntradaReal : DBNull.Value);
                    cmd.Parameters.AddWithValue("@salida", resultado.HoraSalidaReal.HasValue ? (object)resultado.HoraSalidaReal : DBNull.Value);

                    cmd.Parameters.AddWithValue("@retardo", resultado.MinutosRetardo);
                    cmd.Parameters.AddWithValue("@estatus", resultado.Estatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------
        // R - READ: Obtener asistencia detallada para el Monitoreo/Reporte
        // ----------------------------------------------------
        public DataTable GetAsistenciaReporte(DateTime fechaInicio, DateTime fechaFin, int idProfesor)
        {
            DataTable dt = new DataTable();

            // 1. CONSTRUCCIÓN DEL SQL Y FILTROS
            string sql = @"
        SELECT 
            P.Nombre_Completo AS Profesor, 
            A.Nombre_Clase AS Materia, 
            HC.Salon_Asignado AS Salon,
            DATE_FORMAT(HC.Hora_Entrada_Oficial, '%H:%i') AS H_Oficial,
            DATE_FORMAT(AC.Hora_Entrada_Real, '%H:%i') AS H_Checada,
            AC.Minutos_Retardo AS Retardo_Min,
            AC.Estatus
        FROM Asistencia_Calculada AS AC
        JOIN Profesores AS P ON AC.ID_Profesor = P.ID_Profesor
        JOIN Horarios_Clases AS HC ON AC.ID_Horario = HC.ID_Horario
        JOIN Asignaturas AS A ON HC.ID_Asignatura = A.ID_Asignatura
        
        -- INICIO DE FILTRADO DINÁMICO
        WHERE AC.Fecha_Clase BETWEEN @fechaInicio AND @fechaFin";

            // 2. Lógica para el filtro individual (si se selecciona un profesor específico)
            if (idProfesor > 0)
            {
                sql += " AND AC.ID_Profesor = @idProfesor";
            }

            sql += " ORDER BY HC.Hora_Entrada_Oficial;";
            // FIN DE FILTRADO DINÁMICO

            // 3. EJECUCIÓN DEL COMANDO
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    // Parámetros de fecha
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Date);

                    // Parámetro condicional para el profesor
                    if (idProfesor > 0)
                    {
                        cmd.Parameters.AddWithValue("@idProfesor", idProfesor);
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}