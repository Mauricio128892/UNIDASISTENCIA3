using System;

namespace UNID.Data.Models
{
    public class AsistenciaCalculada
    {
        public int IdAsistencia { get; set; }
        public int IdHorario { get; set; }
        public int IdProfesor { get; set; }
        public DateTime FechaClase { get; set; }

        // El signo de pregunta (?) indica que el valor puede ser nulo en la BD
        public TimeSpan? HoraEntradaReal { get; set; }
        public TimeSpan? HoraSalidaReal { get; set; }

        public int MinutosRetardo { get; set; }
        public string Estatus { get; set; }
    }
}