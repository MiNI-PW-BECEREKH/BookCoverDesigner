using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLab
{
    public class StringGraphics : IGraphics
    {
        public string Text { get; set; }
        public Point Position { get; set; } // position here passed relative to the book cover
        public Font Font { get; set; }
        public Color Color { get; set; }

        public StringAlignment Alignment { get; set; }
        public void Draw(Graphics g, object Canvas)
        {
            BookCoverGraphics c = (BookCoverGraphics) Canvas;
            SolidBrush drawBrush = new System.Drawing.SolidBrush(Color);
            StringFormat sf = new StringFormat();
            sf.Alignment = Alignment;
            g.DrawString(Text, Font, drawBrush, new PointF(c.Position.X + Position.X , c.Position.Y + Position.Y),sf);
        }

        //let's do event handling whenever position is set it is set in such a way that string is oriented
    }
}