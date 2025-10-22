using System.Drawing;
using System.Windows.Forms;

namespace UNID.UI.CustomControls
{
    // Esta clase dibuja el GroupBox con un color de borde personalizado
    public class ColoredGroupBox : GroupBox
    {
        // Propiedad para definir el color que queremos (Color Azul Marino de la UNID)
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#1A237E");

        protected override void OnPaint(PaintEventArgs e)
        {
            // Obtener las herramientas de dibujo
            Graphics g = e.Graphics;
            Brush textBrush = new SolidBrush(this.ForeColor);
            Brush borderBrush = new SolidBrush(this.BorderColor);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = g.MeasureString(this.Text, this.Font);
            Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                           this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           this.ClientRectangle.Width - 1,
                                           this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Dibuja el borde del GroupBox
            g.Clear(this.BackColor);
            g.DrawString(this.Text, this.Font, textBrush, this.Padding.Left, 0);

            // 1. Esquina superior izquierda
            g.DrawLine(borderPen, rect.X, rect.Y + (int)(strSize.Height / 2), rect.X, rect.Y + rect.Height);

            // 2. Esquina inferior
            g.DrawLine(borderPen, rect.X, rect.Y + rect.Height, rect.X + rect.Width, rect.Y + rect.Height);

            // 3. Esquina derecha
            g.DrawLine(borderPen, rect.X + rect.Width, rect.Y + rect.Height, rect.X + rect.Width, rect.Y + (int)(strSize.Height / 2));

            // 4. Linea superior (omite el espacio del texto)
            g.DrawLine(borderPen, rect.X, rect.Y + (int)(strSize.Height / 2), rect.X + this.Padding.Left, rect.Y + (int)(strSize.Height / 2));
            g.DrawLine(borderPen, rect.X + this.Padding.Left + (int)strSize.Width, rect.Y + (int)(strSize.Height / 2), rect.X + rect.Width, rect.Y + (int)(strSize.Height / 2));
        }
    }
}