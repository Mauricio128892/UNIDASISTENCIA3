using System;

namespace UNID.Data.Models
{
    public class RegistroLectorBruto
    {
        public int IdRegistroBruto { get; set; }
        public string IdLectorBiometrico { get; set; }
        public DateTime TimestampChecada { get; set; } // DATETIME de MySQL
        public string TipoMovimiento { get; set; }
    }
}