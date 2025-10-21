using UNID.Data;
using UNID.Data.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace UNID.Repository.Repositories
{
    public class AsignaturaRepository
    {
        private readonly DBContext _dbContext = new DBContext();

        // ----------------------------------------------------
        // R - READ: Obtener todas las asignaturas
        // ----------------------------------------------------
        public List<Asignatura> GetAll()
        {
            var asignaturas = new List<Asignatura>();
            string sql = "SELECT ID_Asignatura, Nombre_Clase, Licenciatura FROM Asignaturas;";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asignaturas.Add(new Asignatura
                        {
                            IdAsignatura = reader.GetInt32("ID_Asignatura"),
                            NombreClase = reader.GetString("Nombre_Clase"),
                            Licenciatura = reader.GetString("Licenciatura")
                        });
                    }
                }
            }
            return asignaturas;
        }

        // ----------------------------------------------------
        // C - CREATE: Agregar una nueva asignatura
        // ----------------------------------------------------
        public void Add(Asignatura nuevaAsignatura)
        {
            string sql = @"
                INSERT INTO Asignaturas (Nombre_Clase, Licenciatura)
                VALUES (@nombre, @licenciatura);";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nuevaAsignatura.NombreClase);
                    cmd.Parameters.AddWithValue("@licenciatura", nuevaAsignatura.Licenciatura);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Faltaría el código para Update y Delete, pero con Add y GetAll ya puedes probar la interfaz.
    }
}