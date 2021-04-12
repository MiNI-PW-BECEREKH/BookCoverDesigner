using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WinFormsLab.Annotations;

namespace WinFormsLab
{
    public class BookCoverGraphics : IGraphics, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public List<StringGraphics> TextList = new List<StringGraphics>();

        private Point position;

        public Point Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }


        public Rectangle FrontCover { get; set; }
        public Rectangle BackCover { get; set; }
        public Rectangle Spine { get; set; }
        public Size Size { get; set; }
        public int SpineWidth { get; set; }

        [XmlIgnore()]
        public Color Color { get; set; }
        [XmlElement("Color")]
        public int ColorAsRgb
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }
        public SpineTitleGraphics SpineTitle { get; set; }
        public SpineAuthorGraphics SpineAuthor { get; set; }

        public FrontCoverAuthorGraphics FrontCoverAuthor { get; set; }
        public FrontCoverTitleGraphics FrontCoverTitle { get; set; }

        //we could have 2 different classes for drawing on the spine and drawing on the frontcover



        public BookCoverGraphics()
        {
            PropertyChanged += OnPropertyChanged;
            //INitialize author with necessary things
            FrontCoverTitle = new FrontCoverTitleGraphics();
            FrontCoverAuthor = new FrontCoverAuthorGraphics();
            SpineTitle = new SpineTitleGraphics();
            SpineAuthor = new SpineAuthorGraphics();
            Color = Color.LightPink;
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Position":
                {
                    Spine =
                        new Rectangle(new Point(Position.X + Size.Width / 2 - SpineWidth / 2, Position.Y),
                            new Size(SpineWidth, Size.Height));
                    BackCover = new Rectangle(new Point(Position.X, Position.Y),
                        new Size(Size.Width / 2 - Spine.Width / 2, Size.Height));
                    FrontCover =
                        new Rectangle(
                            new Point(Position.X + BackCover.Width + Spine.Width,
                                Position.Y), new Size(Size.Width / 2 - Spine.Width / 2, Size.Height));
                }
                    break;
            }
        }

        public void Draw(Graphics g, Object _Canvas)
        {
            PictureBox Canvas = (PictureBox)_Canvas;

            Pen pen = new Pen(Color.DarkGray);
            pen.Width = 2;


            //g.DrawRectangle(pen, Position.X, Position.Y, Size.Width, Size.Height);
            //g.DrawRectangle(pen, Canvas.Width / 2 - 25, Canvas.Height / 2 - Size.Width / 2, Spine.Width, Spine.Height);

            g.DrawRectangle(pen, BackCover);
            g.FillRectangle(new SolidBrush(Color),BackCover);
            g.DrawRectangle(pen, Spine);
            g.FillRectangle(new SolidBrush(Color), Spine);
            g.DrawRectangle(pen, FrontCover);
            g.FillRectangle(new SolidBrush(Color), FrontCover);
            foreach (var item in TextList)
            {
                item.Draw(g,this);
            }
            FrontCoverTitle.Draw(g,FrontCover);
            FrontCoverAuthor.Draw(g,FrontCover);
            SpineTitle.Draw(g,Spine);
            SpineAuthor.Draw(g,Spine);


        }

    }
}
