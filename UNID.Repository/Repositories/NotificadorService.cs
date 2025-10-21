using System.Net.Mail;
using System.Net;
using System;
using System.Diagnostics;

namespace UNID.Repository.Repositories
{
    // Clase encargada de enviar correos electrónicos a la Coordinación Académica.
    public class NotificadorService
    {
        // Este método en el proyecto final usará la configuración SMTP de la UNID.
        public void EnviarAlertaTardanza(string correoDestino, string nombreProfesor, int minutosRetardo)
        {
            try
            {
                // NOTA: Para propósitos de la estadía y por seguridad, esto será una SIMULACIÓN.

                string asunto = $"ALERTA DE RETARDO UNID: {nombreProfesor} - {minutosRetardo} min";
                string cuerpo = $"El profesor {nombreProfesor} checó su entrada con un retardo de {minutosRetardo} minutos. Por favor, verificar el registro.";

                // En el proyecto real: Aquí iría la lógica SmtpClient y Smtp.Send()

                // Simulación de éxito
                Debug.WriteLine($"[NOTIFICADOR] OK: Alerta enviada a {correoDestino} sobre el retardo de {nombreProfesor}.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[NOTIFICADOR] ERROR al enviar correo: {ex.Message}");
                // En un servicio 24/7, es vital registrar si la notificación falla.
            }
        }
    }
}