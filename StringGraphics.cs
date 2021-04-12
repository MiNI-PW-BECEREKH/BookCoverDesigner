using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsLab
{
    public class StringGraphics : IGraphics
    {
        public string Text { get; set; }
        public Point Position { get; set; } // position here passed relative to the book cover

        [XmlIgnore()]
        public Font Font
        {
            get;
            set;
        }

        [Browsable(false)]
        public string FontSerialize
        {
            get { return TypeDescriptor.GetConverter(typeof(Font)).ConvertToInvariantString(Font); }
            set { Font = TypeDescriptor.GetConverter(typeof(Font)).ConvertFromInvariantString(value) as Font; }
        }
        [XmlIgnore()] public Color Color { get; set; }
        [XmlElement("Color")]
        public int ColorAsRgb
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }

        public StringAlignment Alignment { get; set; }
        public void Draw(Graphics g, object Canvas)
        {
            BookCoverGraphics c = (BookCoverGraphics) Canvas;
            SolidBrush drawBrush = new System.Drawing.SolidBrush(Color);
            StringFormat sf = new StringFormat();
            sf.Alignment = Alignment;
            g.DrawString(Text, Font, drawBrush, new PointF(c.Position.X + Position.X , c.Position.Y + Position.Y),sf);
            g.DrawEllipse(new Pen(Color),c.Position.X + Position.X -1, c.Position.Y + Position.Y -1 ,1,1);
        }

        //let's do event handling whenever position is set it is set in such a way that string is oriented
    }
}