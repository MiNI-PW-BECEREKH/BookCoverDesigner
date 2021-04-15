using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsLab
{ 
    public partial class MainWindow : Form
    {
        BookCoverGraphics BookCover = new BookCoverGraphics() ;
        public AddTextDialogData TextContext = new AddTextDialogData();
        private Rectangle ContextRectangle = new Rectangle();
        private StringGraphics toModify = (StringGraphics)null;
        private Size MouseFirstClickOffset{ get; set; }

        private Color currentTextColor = new Color();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void splitContainer_Panel1_ClientSizeChanged(object sender, EventArgs e)
        {
            pictureBox.Width = splitContainer.Panel1.Width;
            pictureBox.Height = splitContainer.Panel1.Height;

            pictureBox.Refresh();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += OnKeyUp;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                , true);
            //Magic Numbers are going to be passed from dialogs
            //800,600,50 is the default 
            BookCover.SpineWidth = 50;
            BookCover.Size = new Size(800, 600);
            BookCover.Position = new Point(pictureBox.Width/2 - BookCover.Size.Width / 2, pictureBox.Height/2 - BookCover.Size.Height / 2);
            currentTextColor = Color.Black;

            englishToolStripMenuItem.Checked = true;
            ChangeLanguage("en");

            

        }

        private void OnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && toModify != null)
            {
                BookCover.TextList.Remove(toModify);
                ContextRectangle = new Rectangle();
                pictureBox.Refresh();
            }
        }


        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            BookCover.Draw(e.Graphics, pictureBox);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 255 - BookCover.Color.R, 255 - BookCover.Color.G, 255 - BookCover.Color.B)), ContextRectangle);
            System.GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (additionalTextTextBox.Text == String.Empty)
            //    return;
            //else
            //{
            //    pictureBox.Cursor = Cursors.Cross;
            //    selectedtext = additionalTextTextBox.Text;
            //}
            using (AddTextDialog textDialog = new AddTextDialog())
            {
                textDialog.ShowDialog(this);
                if (textDialog.DialogResult == DialogResult.OK)
                {
                    TextContext = textDialog.DialogData;
                    pictureBox.Cursor = Cursors.Cross;
                }
            }
        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Middle) != 0 && toModify != null && ContextRectangle.Contains(e.Location))
            {
                MouseFirstClickOffset = new Size(e.X - ContextRectangle.X, e.Y - ContextRectangle.Y);
            }
            if (pictureBox.Cursor == Cursors.Cross)
            {
                pictureBox.Cursor = Cursors.Default;
                
                using (Graphics g = pictureBox.CreateGraphics())
                {
                    Font fn = new Font("Arial", TextContext.FontSize, FontStyle.Bold);
                    switch (TextContext.TextAlignment)
                    {
                        case StringAlignment.Center:
                            BookCover.TextList.Add(new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point(e.X /*- (int)(g.MeasureString(TextContext.Text, fn).Width / 2)*/ - BookCover.Position.X, e.Y - (int)(g.MeasureString(TextContext.Text, fn).Height / 2) - BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment });
                            break;
                        case StringAlignment.Near:
                            BookCover.TextList.Add(new StringGraphics {Font =fn ,Text = TextContext.Text, Position = new Point(e.X - (int)(g.MeasureString(TextContext.Text,fn).Width / 2) - BookCover.Position.X, e.Y - (int)(g.MeasureString(TextContext.Text, fn).Height / 2) - BookCover.Position.Y),Color = currentTextColor,Alignment = TextContext.TextAlignment});
                            break;
                        case StringAlignment.Far:
                            var stringMeasures = (g.MeasureString(TextContext.Text, fn));
                            BookCover.TextList.Add(new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point(e.X + (int)(g.MeasureString(TextContext.Text, fn).Width/2) - BookCover.Position.X, e.Y - (int)stringMeasures.Height / 2 - BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment });
                            break;
                    }
                    pictureBox.Refresh();
                    
                }
                //additionalTextTextBox.Text = String.Empty;
            }
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            BookCover.Position = new Point(pictureBox.Width / 2 - BookCover.Size.Width / 2, pictureBox.Height / 2 - BookCover.Size.Height / 2);
            pictureBox.Refresh();
        }

        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uncheck all check polish
            ChangeLanguage("tr");
            englishToolStripMenuItem.Checked = false;
            turkishToolStripMenuItem.Checked = true;

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
            turkishToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop new dialog here 
            using (NewDialog form = new NewDialog())
            {
                form.ShowDialog(this);
                Debug.WriteLine(form.DialogResult);
                if (form.DialogResult == DialogResult.OK)
                {
                    BookCover.Size = new Size(form.DialogData.Width, form.DialogData.Height);
                    BookCover.SpineWidth = form.DialogData.SpineWidth;
                    BookCover.Position = new Point(pictureBox.Width / 2 - BookCover.Size.Width / 2, pictureBox.Height / 2 - BookCover.Size.Height / 2);
                    BookCover.TextList.Clear();
                    BookCover.Color = Color.LightPink;
                    BookCover.SpineAuthor.Text = String.Empty;
                    BookCover.SpineTitle.Text = String.Empty;
                    BookCover.FrontCoverAuthor.Text = String.Empty;
                    BookCover.FrontCoverTitle.Text = String.Empty;

                }
            }
            ContextRectangle = Rectangle.Empty;
            toModify = (StringGraphics) null;
            pictureBox.Refresh();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            BookCover.SpineTitle.Text = titleTextBox.Text;
            BookCover.FrontCoverTitle.Text = titleTextBox.Text;
            pictureBox.Refresh();
        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            BookCover.SpineAuthor.Text = authorTextBox.Text;
            BookCover.FrontCoverAuthor.Text = authorTextBox.Text;
            pictureBox.Refresh();

        }

        private void changeBackgroundColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            { 
                var Result = colorDialog.ShowDialog(this);
                if(Result == DialogResult.OK)
                    BookCover.Color = colorDialog.Color;

            }
            pictureBox.Refresh();
        }

        private void ChangeTextColorButton_Click(object sender, EventArgs e)
        {
            using(ColorDialog colorDialog = new ColorDialog())
            {
                var Result = colorDialog.ShowDialog(this);
                if (Result == DialogResult.OK)
                {
                    BookCover.FrontCoverAuthor.Color = colorDialog.Color;
                    BookCover.FrontCoverTitle.Color = colorDialog.Color;
                    BookCover.SpineAuthor.Color = colorDialog.Color;
                    BookCover.SpineTitle.Color = colorDialog.Color;
                    foreach (var item in BookCover.TextList)
                    {
                        item.Color = colorDialog.Color;
                    }

                    currentTextColor = colorDialog.Color;
                }
            }
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                DialogResult result = DialogResult.Cancel;
                StringGraphics toadd = new StringGraphics();
                StringGraphics toremove = new StringGraphics();
                foreach (var item in BookCover.TextList)
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        Rectangle stringRect = new Rectangle();
                        switch (item.Alignment)
                        {
                            case StringAlignment.Center:
                                stringRect = new Rectangle
                                {
                                    Height = (int)g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int)g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X - (int)g.MeasureString(item.Text, item.Font).Width / 2,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                            case StringAlignment.Near:
                                stringRect = new Rectangle
                                {
                                    Height = (int)g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int)g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                            case StringAlignment.Far:
                                stringRect = new Rectangle
                                {
                                    Height = (int)g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int)g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X - (int)g.MeasureString(item.Text, item.Font).Width,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                        }


                        if (stringRect.Contains(e.Location)) //check if mouse point is inside the rectangle
                        {
                            
                            //g.DrawRectangle(new Pen(Color.FromArgb(255, 255 - BookCover.Color.R, 255 - BookCover.Color.G, 255 - BookCover.Color.B)), stringRect);
                            toremove = item;
                            using (AddTextDialog textDialog = new AddTextDialog())
                            {
                                textDialog.DialogData = new AddTextDialogData
                                { FontSize = (int)item.Font.Size, Text = item.Text, TextAlignment = item.Alignment };
                                textDialog.ShowDialog(this);
                                if (textDialog.DialogResult == DialogResult.OK)
                                {
                                    result = textDialog.DialogResult;
                                    TextContext = textDialog.DialogData;
                                    Font fn = new Font("Arial", TextContext.FontSize, FontStyle.Bold);
                                    switch (TextContext.TextAlignment)
                                    {
                                        //when text is changed it is a little of off center
                                        case StringAlignment.Center:
                                            var stringMeasuresC = (g.MeasureString(toremove.Text, fn));
                                            //could be better
                                            toadd = new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point(stringRect.X + (int)stringMeasuresC.Width / 2 - BookCover.Position.X, stringRect.Y + stringRect.Height / 2 - (int)(g.MeasureString(TextContext.Text, fn).Height) / 2 - BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment };
                                            break;
                                        case StringAlignment.Near:
                                            toadd = new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point((stringRect.X + stringRect.Width/2 - (int)(g.MeasureString(TextContext.Text, fn).Width)/2) - BookCover.Position.X, stringRect.Y + stringRect.Height / 2 - (int)(g.MeasureString(TextContext.Text, fn).Height) / 2 - BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment }; break;
                                        case StringAlignment.Far:

                                            toadd = new StringGraphics
                                            {
                                                Font = fn,
                                                Text = TextContext.Text,

                                                Position = new Point(
                                                    stringRect.X + stringRect.Width / 2 + g.MeasureString(TextContext.Text, fn).ToSize().Width / 2 -
                                                    BookCover.Position.X, stringRect.Y + stringRect.Height / 2 - (int)(g.MeasureString(TextContext.Text, fn).Height) / 2 - BookCover.Position.Y),
                                                Color = currentTextColor,
                                                Alignment = TextContext.TextAlignment
                                            };
                                            break;
                                    }
                                    //BookCover.TextList.Remove(item);

                                }
                            }
                        }
                    }
                }

                if (result == DialogResult.OK)
                {
                    BookCover.TextList.Remove(toremove);
                    BookCover.TextList.Add(toadd);
                    if (ContextRectangle != Rectangle.Empty)
                    {
                        ContextRectangle = GetStringRectangle(toadd);
                        toModify = toadd;
                    }
                    
                    pictureBox.Refresh();

                }
            }
        }

        protected Rectangle GetStringRectangle(StringGraphics item)
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                Rectangle stringRect = new Rectangle();
                switch (item.Alignment)
                {
                    case StringAlignment.Center:
                        stringRect = new Rectangle
                        {
                            Height = (int) g.MeasureString(item.Text, item.Font).Height,
                            Width = (int) g.MeasureString(item.Text, item.Font).Width,
                            X = item.Position.X + BookCover.Position.X -
                                (int) g.MeasureString(item.Text, item.Font).Width / 2,
                            Y = item.Position.Y + BookCover.Position.Y
                        };
                        break;
                    case StringAlignment.Near:
                        stringRect = new Rectangle
                        {
                            Height = (int) g.MeasureString(item.Text, item.Font).Height,
                            Width = (int) g.MeasureString(item.Text, item.Font).Width,
                            X = item.Position.X + BookCover.Position.X,
                            Y = item.Position.Y + BookCover.Position.Y
                        };
                        break;
                    case StringAlignment.Far:
                        stringRect = new Rectangle
                        {
                            Height = (int) g.MeasureString(item.Text, item.Font).Height,
                            Width = (int) g.MeasureString(item.Text, item.Font).Width,
                            X = item.Position.X + BookCover.Position.X -
                                (int) g.MeasureString(item.Text, item.Font).Width,
                            Y = item.Position.Y + BookCover.Position.Y
                        };
                        break;
                }

                return stringRect;
            }
        }


        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Right) != 0)
            {
                foreach (var item in BookCover.TextList)
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        Rectangle stringRect = new Rectangle();
                        switch (item.Alignment)
                        {
                            case StringAlignment.Center:
                                stringRect = new Rectangle
                                {
                                    Height = (int) g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int) g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X -
                                        (int) g.MeasureString(item.Text, item.Font).Width / 2,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                            case StringAlignment.Near:
                                stringRect = new Rectangle
                                {
                                    Height = (int) g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int) g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                            case StringAlignment.Far:
                                stringRect = new Rectangle
                                {
                                    Height = (int) g.MeasureString(item.Text, item.Font).Height,
                                    Width = (int) g.MeasureString(item.Text, item.Font).Width,
                                    X = item.Position.X + BookCover.Position.X -
                                        (int) g.MeasureString(item.Text, item.Font).Width,
                                    Y = item.Position.Y + BookCover.Position.Y
                                };
                                break;
                        }


                        if (stringRect.Contains(e.Location)) //check if mouse point is inside the rectangle
                        {
                            
                            ContextRectangle = stringRect;
                            toModify = item;
                            pictureBox.Refresh();
                            return;

                        }
                        else
                        {
                            ContextRectangle = new Rectangle();
                            toModify = (StringGraphics) null;
                            pictureBox.Refresh();
                            
                        }
                    }
                }
            }

        }

        private Point prevPoint;
        
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Middle) != 0 && toModify != null   )
            {
                using (Graphics g = pictureBox.CreateGraphics())
                {

                    //item is not translated it is moved to the E.Location
                    switch (toModify.Alignment)
                    {
                        case StringAlignment.Center:
                            toModify.Position = new Point(( e.X  - BookCover.Position.X) + ContextRectangle.Width / 2 - MouseFirstClickOffset.Width, ( e.Y  - BookCover.Position.Y) - MouseFirstClickOffset.Height);
                            ContextRectangle = new Rectangle
                            {
                                Height = (int)g.MeasureString(toModify.Text, toModify.Font).Height,
                                Width = (int)g.MeasureString(toModify.Text, toModify.Font).Width,
                                X = toModify.Position.X + BookCover.Position.X -
                                    (int)g.MeasureString(toModify.Text, toModify.Font).Width / 2,
                                Y = toModify.Position.Y + BookCover.Position.Y
                            };

                            break;
                        case StringAlignment.Near:
                            toModify.Position = new Point((e.X - BookCover.Position.X) - MouseFirstClickOffset.Width, (e.Y - BookCover.Position.Y) - MouseFirstClickOffset.Height);
                            ContextRectangle = new Rectangle
                            {
                                Height = (int)g.MeasureString(toModify.Text, toModify.Font).Height,
                                Width = (int)g.MeasureString(toModify.Text, toModify.Font).Width,
                                X = toModify.Position.X + BookCover.Position.X,
                                Y = toModify.Position.Y + BookCover.Position.Y
                            };

                            break;
                        case StringAlignment.Far:
                            toModify.Position = new Point((e.X - BookCover.Position.X) + ContextRectangle.Width - MouseFirstClickOffset.Width, (e.Y - BookCover.Position.Y) - MouseFirstClickOffset.Height);
                            ContextRectangle = new Rectangle
                            {
                                Height = (int)g.MeasureString(toModify.Text, toModify.Font).Height,
                                Width = (int)g.MeasureString(toModify.Text, toModify.Font).Width,
                                X = toModify.Position.X + BookCover.Position.X -
                                    (int)g.MeasureString(toModify.Text, toModify.Font).Width,
                                Y = toModify.Position.Y + BookCover.Position.Y
                            };
                            //g.DrawEllipse(new Pen(Color.Black), (e.X - BookCover.Position.X) + MouseFirstClickOffset.Width / 2 -5, (e.Y - BookCover.Position.Y) + MouseFirstClickOffset.Height / 2-5,5,5);

                            break;
                    }

                    pictureBox.Refresh();
                }

                prevPoint = e.Location;
            }
        }

        private void ChangeLanguage(string language)
        {
            CultureInfo.CurrentUICulture = new CultureInfo(language);
            Controls.Clear();
            var size = splitContainer.Panel1.Size;
            var mSize = Size;
            var location = Location;
            InitializeComponent();
            Size = mSize;
            Location = location;
            splitContainer.SplitterDistance = size.Width;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.Filter = "xml files (*.xml)| *.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        var xmlSerializer = new XmlSerializer(BookCover.GetType());
                        xmlSerializer.Serialize(stream,BookCover);
                        stream.Close();
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "xml files (*.xml) | *.xml";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        if (openFileDialog.FileName != "")
                        {
                            var stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                            var xmlSerializer = new XmlSerializer(BookCover.GetType());
                            BookCover = (BookCoverGraphics)xmlSerializer.Deserialize(stream);
                            stream.Close();
                            ContextRectangle = Rectangle.Empty;
                            toModify = (StringGraphics) null;
                            pictureBox.Refresh();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
           
        }
    }
}
