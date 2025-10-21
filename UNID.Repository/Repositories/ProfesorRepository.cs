using UNID.Data;
using UNID.Data.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace UNID.Repository.Repositories
{
    // Clase encargada de todas las operaciones CRUD para la tabla Profesores
    public class ProfesorRepository
    {
        // Instancia para obtener la cadena de conexión segura
        private readonly DBContext _dbContext = new DBContext();

        // ----------------------------------------------------
        // C - CREATE: Agregar un nuevo profesor a la BD
        // ----------------------------------------------------
        public void Add(Profesor nuevoProfesor)
        {
            string sql = @"
                INSERT INTO Profesores (
                    Nombre_Completo, Correo_Electronico, ID_Lector_Biometrico, Color_Display_Hex, Activo)
                VALUES (@nombre, @correo, @idlector, @color, @activo);";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    // Asignación segura de parámetros
                    cmd.Parameters.AddWithValue("@nombre", nuevoProfesor.NombreCompleto);
                    cmd.Parameters.AddWithValue("@correo", nuevoProfesor.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@idlector", nuevoProfesor.IdLectorBiometrico);
                    cmd.Parameters.AddWithValue("@color", nuevoProfesor.ColorDisplayHex);
                    cmd.Parameters.AddWithValue("@activo", nuevoProfesor.Activo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------
        // R - READ: Obtener todos los profesores activos
        // ----------------------------------------------------
        public List<Profesor> GetAll()
        {
            var profesores = new List<Profesor>();
            string sql = @"
                SELECT ID_Profesor, Nombre_Completo, Correo_Electronico, 
                       ID_Lector_Biometrico, Color_Display_Hex, Activo 
                FROM Profesores 
                WHERE Activo = TRUE;"; // Solo muestra los activos para la UI

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        profesores.Add(new Profesor
                        {
                            IdProfesor = reader.GetInt32("ID_Profesor"),
                            NombreCompleto = reader.GetString("Nombre_Completo"),
                            CorreoElectronico = reader.GetString("Correo_Electronico"),
                            IdLectorBiometrico = reader.GetString("ID_Lector_Biometrico"),
                            // Manejo de valores que pueden ser nulos si no se asignó color
                            ColorDisplayHex = reader.IsDBNull(reader.GetOrdinal("Color_Display_Hex")) ? null : reader.GetString("Color_Display_Hex"),
                            Activo = reader.GetBoolean("Activo")
                        });
                    }
                }
            }
            return profesores;
        }

        // ----------------------------------------------------
        // U - UPDATE: Actualizar la información del profesor
        // ----------------------------------------------------
        public void Update(Profesor profesorAActualizar)
        {
            string sql = @"
                UPDATE Profesores SET
                    Nombre_Completo = @nombre,
                    Correo_Electronico = @correo,
                    ID_Lector_Biometrico = @idlector,
                    Color_Display_Hex = @color,
                    Activo = @activo
                WHERE ID_Profesor = @id;";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", profesorAActualizar.NombreCompleto);
                    cmd.Parameters.AddWithValue("@correo", profesorAActualizar.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@idlector", profesorAActualizar.IdLectorBiometrico);
                    cmd.Parameters.AddWithValue("@color", profesorAActualizar.ColorDisplayHex);
                    cmd.Parameters.AddWithValue("@activo", profesorAActualizar.Activo);

                    cmd.Parameters.AddWithValue("@id", profesorAActualizar.IdProfesor); // Clave para WHERE

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------
        // D - DELETE LÓGICO: Desactivar (mantener historial)
        // ----------------------------------------------------
        public void Desactivar(int idProfesor)
        {
            // La actualización lógica es cambiar el campo 'Activo' a FALSE
            string sql = "UPDATE Profesores SET Activo = FALSE WHERE ID_Profesor = @id;";

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}