using System;
using UNID.Data.Models;
using UNID.Repository.Repositories; // <-- Esta ya la tienes (para ProfesorRepository)
using UNID.Repository;              // <-- Verifica que esta esté ahí

namespace UNID.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Prueba de LÓGICA: Calculador de Retardos ---");

            // --- Configuración de Horario Base (Simulación de la BD) ---
            var horarioBase = new HorarioClase
            {
                IdHorario = 1,
                IdProfesor = 1,
                HoraEntradaOficial = new TimeSpan(8, 0, 0) // 08:00:00 AM
            };

            // --- Simulación de Checadas del Lector ---
            // Prueba 1: Tardanza de 15 minutos (08:15:00)
            DateTime checadaTarde = new DateTime(2025, 10, 1, 8, 15, 0);

            // Prueba 2: Llegó a tiempo (07:55:00)
            DateTime checadaTemprano = new DateTime(2025, 10, 1, 7, 55, 0);

            var calculador = new UNID.Repository.CalculadorAsistencia(); // O UNID.Repository.Repositories.CalculadorAsistencia()

            // EJECUTAR PRUEBA 1: TARDE
            var resultadoTarde = calculador.ProcesarEntrada(horarioBase, checadaTarde);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nPrueba 1 (Tarde - 08:15): Estatus: {resultadoTarde.Estatus} | Retardo: {resultadoTarde.MinutosRetardo} minutos.");

            // EJECUTAR PRUEBA 2: TEMPRANO
            var resultadoTemprano = calculador.ProcesarEntrada(horarioBase, checadaTemprano);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nPrueba 2 (Temprano - 07:55): Estatus: {resultadoTemprano.Estatus} | Retardo: {resultadoTemprano.MinutosRetardo} minutos.");

            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}