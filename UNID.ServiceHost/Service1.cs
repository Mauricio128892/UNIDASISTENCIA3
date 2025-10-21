using System.ServiceProcess;
using System.Timers; // Necesario para el temporizador
using System.Diagnostics;

namespace UNID.ServiceHost
{
    // NO USAMOS 'partial' porque eliminamos el archivo Designer.cs
    public class Service1 : ServiceBase
    {
        // El temporizador que definirá la frecuencia de ejecución (ej. cada 5 minutos)
        private Timer _timer;

        public Service1()
        {
            // Ya no llamamos a InitializeComponent() porque eliminamos el archivo Designer
        }

        protected override void OnStart(string[] args)
        {
            // Inicializa el temporizador
            // 60000 milisegundos = 1 minuto (usaremos esto para la prueba rápida)
            // Para producción, sería 300000 (5 minutos)
            _timer = new Timer(60000);
            _timer.Elapsed += OnTimerElapsed; // Asigna el método a ejecutar
            _timer.AutoReset = true;
            _timer.Enabled = true;

            // En un servicio real, se usaría un log para confirmar el inicio.
        }

        protected override void OnStop()
        {
            // Detiene el temporizador y libera recursos cuando el servicio se detiene
            _timer.Enabled = false;
            _timer.Dispose();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Detiene el temporizador temporalmente para evitar ejecuciones simultáneas
            _timer.Enabled = false;

            // ¡Aquí es donde ocurre la magia! Llamamos a la clase principal de automatización.
            ProcesadorDeChecadas.EjecutarCiclo();

            _timer.Enabled = true; // Habilita el temporizador de nuevo para el siguiente ciclo
        }

        private void InitializeComponent()
        {
            // 
            // Service1
            // 
            this.ServiceName = "UNID_AsistenciaDocente";

        }
    }
}