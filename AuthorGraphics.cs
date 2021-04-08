using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsLab.Annotations;

namespace WinFormsLab
{
    interface AuthorGraphics : IGraphics
    {
        public void Draw(Graphics g, object c)
        {
            throw new NotImplementedException();
        }

        public Point Position { get; set; }

        public String Text { get; set; }

        public Font Font { get; set;
        }
    }

    class SpineAuthorGraphics : AuthorGraphics
    {
        public void Draw(Graphics g, object canvas)
        {
            Rectangle c = (Rectangle)canvas;
            if ((int)g.MeasureString(Text, Font).Width > TextSize.Width && (int)g.MeasureString(Text, Font).Width > c.Height / 2)
            {
                //something erased
                var fsize = Font.Size;
                Font = new Font("Arial", fsize - (g.MeasureString(Text, Font).Width - c.Height / 2) / Text.Length);
            }
            else if ((int)g.MeasureString(Text, Font).Width < TextSize.Width && (int)g.MeasureString(Text, Font).Width < c.Width && Text != "")
            {
                //something added
                var fsize = Font.Size;
                var newsize = fsize + Math.Abs(g.MeasureString(Text, Font).Width - c.Width) / Text.Length > 24 ? 24
                    : fsize + Math.Abs(g.MeasureString(Text, Font).Width - c.Width) / Text.Length;
                Font = new Font("Arial", newsize);
            }

            TextSize = new Size((int)g.MeasureString(Text, Font).Width, (int)g.MeasureString(Text, Font).Height);

            g.TranslateTransform(c.Left + c.Width / 2 - (int)g.MeasureString(Text, Font).Height / 2, c.Top + c.Height / 4 + (int)g.MeasureString(Text, Font).Width / 2);
            g.RotateTransform(270);
            g.DrawString(Text, Font, new SolidBrush(Color), new Point(0, 0));
            g.ResetTransform();
        }

        public Point Position { get; set; }
        public SpineAuthorGraphics()
        {
            PropertyChanged += OnPropertyChanged;
        }

        private string text = String.Empty;

        public String Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Text":
                {
                    if (Text == "")
                    {
                        Font = new Font("Arial", 24);
                    }
                }
                    break;
            }
        }
        public Font Font { get; set; } = new Font("Arial", 24);
        public Color Color { get; set; } = Color.Black;
        public Size TextSize { get; set; } = new Size(24, 24);
    }

    class FrontCoverAuthorGraphics : AuthorGraphics, INotifyPropertyChanged
    {
        public void Draw(Graphics g, object canvas)
        {
            Rectangle c = (Rectangle)canvas;
            if ((int)g.MeasureString(Text, Font).Width > TextSize.Width && (int)g.MeasureString(Text, Font).Width > c.Width)
            {
                //something erased
                var fsize = Font.Size;
                Font = new Font("Arial", Math.Abs(fsize - (g.MeasureString(Text, Font).Width - c.Width) / Text.Length));
            }
            else if ((int)g.MeasureString(Text, Font).Width < TextSize.Width && (int)g.MeasureString(Text, Font).Width < c.Width && Text != "")
            {
                //something added
                var fsize = Font.Size;
                var newsize = fsize + Math.Abs(g.MeasureString(Text, Font).Width - c.Width) / Text.Length > 24 ? 24
                    : fsize + Math.Abs(g.MeasureString(Text, Font).Width - c.Width) / Text.Length;
                Font = new Font("Arial", newsize);
            }

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            TextSize = new Size((int)g.MeasureString(Text, Font).Width, (int)g.MeasureString(Text, Font).Height);
            g.DrawString(Text, Font, new SolidBrush(Color), new PointF(c.Left + c.Width / 2 + g.MeasureString(Text, Font).Width / 2, c.Top + c.Height / 3 - g.MeasureString(Text, Font).Height / 2), stringFormat);
        }

        public Point Position { get; set; }

        public Font Font { get; set; } = new Font("Arial", 24);
        public Color Color { get; set; } = Color.Black;
        public Size TextSize { get; set; } = new Size(24, 24);

        public FrontCoverAuthorGraphics()
        {
            PropertyChanged += OnPropertyChanged;
        }

        private string text = String.Empty;

        public String Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Text":
                {
                    if (Text == "")
                    {
                        Font = new Font("Arial", 24);
                    }
                }
                    break;
            }
        }
    }

}
