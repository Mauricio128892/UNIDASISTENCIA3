using System;

namespace UNID.Data.Models
{
    public class Profesor
    {
        public string RutaFotoPerfil { get; set; } // ¡Esta es la propiedad que faltaba!
        public int IdProfesor { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string IdLectorBiometrico { get; set; }
        public string ColorDisplayHex { get; set; }
        public bool Activo { get; set; } = true;
    }
}