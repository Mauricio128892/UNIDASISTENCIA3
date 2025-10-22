using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UNID.UI.CustomControls
{
    // Esta clase dibuja un botón con bordes redondeados
    public class RoundedButton : Button
    {
        // Propiedad para controlar el radio de la curva
        public int BorderRadius { get; set; } = 15; // 15 píxeles de radio por defecto

        protected override void OnPaint(PaintEventArgs e)
        {
            // Crea un trazado gráfico (GraphicsPath) para definir la forma curva
            GraphicsPath path = new GraphicsPath();

            // Dibuja el rectángulo con el radio en las cuatro esquinas
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseAllFigures();

            // Asigna la forma curva al botón
            this.Region = new Region(path);

            // Llama al método original para que el botón se dibuje con su texto y color normal
            base.OnPaint(e);
        }
    }
}