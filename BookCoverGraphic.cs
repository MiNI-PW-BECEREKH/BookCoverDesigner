using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLab.Annotations;

namespace WinFormsLab
{
    class BookCoverGraphics : IGraphics, INotifyPropertyChanged
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


        public BookCoverGraphics()
        {
            PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Position":
                {
                    Spine =
                        new Rectangle(new Point(Position.X + Size.Width / 2 - 50 / 2, Position.Y),
                            new Size(50, Size.Height));
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
            g.DrawRectangle(pen, Spine);
            g.DrawRectangle(pen, FrontCover);
            foreach (var item in TextList)
            {
                item.Draw(g,this);
            }
        }

    }
}
