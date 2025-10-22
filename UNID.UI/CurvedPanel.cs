using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UNID.UI.CustomControls
{
    // Esta clase dibuja un Panel con esquinas redondeadas
    public class CurvedPanel : Panel
    {
        // Propiedad para controlar el radio de la curva
        public int BorderRadius { get; set; } = 15; // 15 píxeles por defecto

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crea un trazado gráfico (GraphicsPath) para definir la forma curva
            GraphicsPath path = new GraphicsPath();

            // Dibuja el rectángulo con el radio en las cuatro esquinas
            path.AddArc(0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90);
            path.AddArc(Width - BorderRadius * 2, 0, BorderRadius * 2, BorderRadius * 2, 270, 90);
            path.AddArc(Width - BorderRadius * 2, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 0, 90);
            path.AddArc(0, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 90, 90);
            path.CloseAllFigures();

            // Asigna la forma curva al Panel
            this.Region = new Region(path);

            // Dibuja el borde con un color sutil (opcional)
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}