using UNID.Data.Models;
using System;

namespace UNID.Repository // <--- NOTA: Este es el namespace que debe usar
{
    public class CalculadorAsistencia
    {
        // Este método se ejecutará en tu Servicio de Windows 24/7.
        // Se encarga de comparar el horario oficial de la BD con la hora real del checador.

        public AsistenciaCalculada ProcesarEntrada(HorarioClase horarioOficial, DateTime horaChecada)
        {
            // 1. Convertir la hora oficial de inicio de clase a un objeto DateTime completo para la comparación.
            DateTime horaLimite = new DateTime(
                horaChecada.Year,
                horaChecada.Month,
                horaChecada.Day,
                horarioOficial.HoraEntradaOficial.Hours,
                horarioOficial.HoraEntradaOficial.Minutes,
                horarioOficial.HoraEntradaOficial.Seconds);

            // 2. Calcular la diferencia entre la hora checada y la hora límite
            TimeSpan diferencia = horaChecada.TimeOfDay - horaLimite.TimeOfDay;
            int minutosRetardo = 0;
            string estatus = "A tiempo";

            // 3. Aplicar la Lógica de Negocio: Si la diferencia es positiva, hay retardo.
            if (diferencia.TotalMinutes > 0)
            {
                // Hubo tardanza. Math.Ceiling asegura que 0.1 minutos de tardanza cuenten como 1 minuto.
                minutosRetardo = (int)Math.Ceiling(diferencia.TotalMinutes);
                estatus = "Tardanza";
            }
            else
            {
                // Llegó a tiempo o antes
                minutosRetardo = 0;
                estatus = "A tiempo";
            }

            // 4. Devolver el objeto de resultado final para ser guardado en la BD
            return new AsistenciaCalculada
            {
                IdHorario = horarioOficial.IdHorario,
                IdProfesor = horarioOficial.IdProfesor,
                FechaClase = horaChecada.Date,
                HoraEntradaReal = horaChecada.TimeOfDay,
                MinutosRetardo = minutosRetardo,
                Estatus = estatus
            };
        }
    }
}