using System;

namespace UNID.Data.Models
{
    public class HorarioClase
    {
        public int IdHorario { get; set; }
        public int IdProfesor { get; set; }
        public int IdAsignatura { get; set; }
        public string DiaSemana { get; set; }
        public string SalonAsignado { get; set; }
        public TimeSpan HoraEntradaOficial { get; set; } // TIME de MySQL
        public TimeSpan HoraSalidaOficial { get; set; } // TIME de MySQL
    }
}