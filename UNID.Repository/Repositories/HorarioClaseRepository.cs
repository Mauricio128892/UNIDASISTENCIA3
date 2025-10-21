using UNID.Data;
using UNID.Data.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace UNID.Repository.Repositories
{
    public class HorarioClaseRepository
    {
        private readonly DBContext _dbContext = new DBContext();

        // ----------------------------------------------------
        // C - CREATE: Agregar una nueva asignación de horario
        // ----------------------------------------------------
        public void Add(HorarioClase nuevoHorario)
        {
            string sql = @"
                INSERT INTO Horarios_Clases (
                    ID_Profesor, ID_Asignatura, Dia_Semana, Salon_Asignado, Hora_Entrada_Oficial, Hora_Salida_Oficial)
                VALUES (@idprofesor, @idasignatura, @dia, @salon, @entrada, @salida);";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@idprofesor", nuevoHorario.IdProfesor);
                    cmd.Parameters.AddWithValue("@idasignatura", nuevoHorario.IdAsignatura);
                    cmd.Parameters.AddWithValue("@dia", nuevoHorario.DiaSemana);
                    cmd.Parameters.AddWithValue("@salon", nuevoHorario.SalonAsignado);
                    cmd.Parameters.AddWithValue("@entrada", nuevoHorario.HoraEntradaOficial);
                    cmd.Parameters.AddWithValue("@salida", nuevoHorario.HoraSalidaOficial);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------
        // R - READ: Obtener horarios para un día específico (Lógica del Servicio 24/7)
        // ----------------------------------------------------
        public List<HorarioClase> GetHorariosDelDia(string diaSemana)
        {
            var horarios = new List<HorarioClase>();
            string sql = @"
                SELECT ID_Horario, ID_Profesor, ID_Asignatura, Dia_Semana, Salon_Asignado, 
                       Hora_Entrada_Oficial, Hora_Salida_Oficial
                FROM Horarios_Clases 
                WHERE Dia_Semana = @dia;"; // ✅ CORRECCIÓN: Usa el placeholder SQL @dia

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    // Asigna la variable C# 'diaSemana' al placeholder SQL '@dia'
                    cmd.Parameters.AddWithValue("@dia", diaSemana);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horarios.Add(new HorarioClase
                            {
                                IdHorario = reader.GetInt32("ID_Horario"),
                                IdProfesor = reader.GetInt32("ID_Profesor"),
                                IdAsignatura = reader.GetInt32("ID_Asignatura"),
                                DiaSemana = reader.GetString("Dia_Semana"),
                                SalonAsignado = reader.IsDBNull(reader.GetOrdinal("Salon_Asignado")) ? null : reader.GetString("Salon_Asignado"),
                                HoraEntradaOficial = reader.GetTimeSpan("Hora_Entrada_Oficial"),
                                HoraSalidaOficial = reader.GetTimeSpan("Hora_Salida_Oficial")
                            });
                        }
                    }
                }
            }
            return horarios;
        }

        // ----------------------------------------------------
        // R - READ: Obtener TODOS los horarios (Para la interfaz de gestión)
        // ----------------------------------------------------
        public List<HorarioClase> GetAll()
        {
            var horarios = new List<HorarioClase>();
            string sql = @"
                SELECT ID_Horario, ID_Profesor, ID_Asignatura, Dia_Semana, Salon_Asignado, 
                       Hora_Entrada_Oficial, Hora_Salida_Oficial
                FROM Horarios_Clases;";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        horarios.Add(new HorarioClase
                        {
                            IdHorario = reader.GetInt32("ID_Horario"),
                            IdProfesor = reader.GetInt32("ID_Profesor"),
                            IdAsignatura = reader.GetInt32("ID_Asignatura"),
                            DiaSemana = reader.GetString("Dia_Semana"),
                            SalonAsignado = reader.IsDBNull(reader.GetOrdinal("Salon_Asignado")) ? null : reader.GetString("Salon_Asignado"),
                            HoraEntradaOficial = reader.GetTimeSpan("Hora_Entrada_Oficial"),
                            HoraSalidaOficial = reader.GetTimeSpan("Hora_Salida_Oficial")
                        });
                    }
                }
            }
            return horarios;
        }

        // Faltaría el código para Update y Delete, pero con Add y GetAll ya puedes probar la interfaz.
    }
}