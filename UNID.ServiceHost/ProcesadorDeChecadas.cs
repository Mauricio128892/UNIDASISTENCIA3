using UNID.Repository.Repositories;
using UNID.Repository;
using UNID.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics; // Para fines de log/prueba

namespace UNID.ServiceHost
{
    public static class ProcesadorDeChecadas
    {
        public static void EjecutarCiclo()
        {
            // Esta función simula el trabajo que se realiza cada 5 minutos

            // NOTA: En el proyecto final, aquí se integraría el SDK/API del ZKTeco

            try
            {
                // 1. OBTENER LOS HORARIOS OFICIALES PARA HOY
                var horarioRepo = new HorarioClaseRepository();

                // Obtenemos el día de la semana actual en español (ej. "Martes")
                string diaSemanaActual = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));
                diaSemanaActual = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(diaSemanaActual.ToLower());

                List<HorarioClase> horariosDeHoy = horarioRepo.GetHorariosDelDia(diaSemanaActual);

                // Si no hay clases hoy, el ciclo termina.
                if (horariosDeHoy.Count == 0)
                {
                    Debug.WriteLine($"[{DateTime.Now}] Sin clases programadas para el {diaSemanaActual}.");
                    return;
                }

                Debug.WriteLine($"[{DateTime.Now}] Horarios encontrados para hoy: {horariosDeHoy.Count}");

                // 2. SIMULAR LECTURA DEL CHECADOR (En el proyecto real se usa el API)
                SimuladorDeChecadas();

                // 3. APLICAR LÓGICA DE RETARDO
                AplicarLogicaDeRetardo(horariosDeHoy);
            }
            catch (Exception ex)
            {
                // Si el servicio falla, registramos el error para depuración
                Debug.WriteLine($"[{DateTime.Now}] ERROR CRÍTICO EN EL SERVICIO: {ex.Message}");
                // En un servicio de producción, aquí se usaría un log de Windows
            }
        }

        // ***************************************************************
        //  SIMULACIÓN: En el proyecto real, esta función usaría el SDK.
        // ***************************************************************
        private static void SimuladorDeChecadas()
        {
            // Este método en el mundo real:
            // 1. Se conecta al lector ZKTeco usando su IP y SDK.
            // 2. Descarga todos los registros nuevos (ID_Lector_Biometrico y Timestamp_Checada).
            // 3. Llama a un Repositorio para guardar esos datos en la tabla Registros_Lector_Bruto.

            // Debug.WriteLine("Simulación: Datos brutos descargados y guardados en la BD.");
        }

        // ***************************************************************
        //  LÓGICA: Calcula y guarda la asistencia
        // ***************************************************************
        private static void AplicarLogicaDeRetardo(List<HorarioClase> horariosDeHoy)
        {
            var calculador = new CalculadorAsistencia();
            var asistenciaRepo = new AsistenciaRepository(); // NECESITAS CREAR ESTE REPOSITORIO

            // Itera sobre cada clase programada para hoy.
            foreach (var horario in horariosDeHoy)
            {
                // SIMULACIÓN: Asumimos que el profesor checó tarde (hora de clase + 10 minutos)
                DateTime horaSimuladaChecada = DateTime.Now.Date.Add(horario.HoraEntradaOficial).AddMinutes(10);

                // 1. Aplica la lógica de cálculo
                AsistenciaCalculada resultado = calculador.ProcesarEntrada(horario, horaSimuladaChecada);

                // 2. Determina si debe enviar notificación
                if (resultado.Estatus == "Tardanza")
                {
                    // Módulo que debe ser implementado
                    EnviarNotificacionTardanza(resultado.IdProfesor, resultado.MinutosRetardo);
                }

                // 3. Guarda el resultado en la tabla Asistencia_Calculada
                // asistenciaRepo.Add(resultado); // Se necesita el repositorio.

                Debug.WriteLine($"Profesor {horario.IdProfesor}: Checada {resultado.HoraEntradaReal}. Estatus: {resultado.Estatus}.");
            }
        }

        // ***************************************************************
        //  MÓDULO DE NOTIFICACIONES
        // ***************************************************************
        private static void EnviarNotificacionTardanza(int idProfesor, int minutosRetardo)
        {
            // Aquí irá la lógica de System.Net.Mail para enviar el correo a la Coordinación.
            Debug.WriteLine($"--- Alerta Enviada: Profesor {idProfesor} llegó tarde por {minutosRetardo} minutos.");
        }
    }
}