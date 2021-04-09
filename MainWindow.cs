using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{ 
    public partial class MainWindow : Form
    {
        List<StringGraphics> grapics = new List<StringGraphics>();
        String selectedtext = null;
        BookCoverGraphics BookCover = new BookCoverGraphics() ;
        public AddTextDialogData TextContext = new AddTextDialogData();

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

            //Magic Numbers are going to be passed from dialogs
            //800,600,50 is the default 
            BookCover.SpineWidth = 50;
            BookCover.Size = new Size(800, 600);
            BookCover.Position = new Point(pictureBox.Width/2 - BookCover.Size.Width / 2, pictureBox.Height/2 - BookCover.Size.Height / 2);
            currentTextColor = Color.Black;

            englishToolStripMenuItem.Checked = true;

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            BookCover.Draw(e.Graphics, pictureBox);
            
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

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //uncheck all check polish
            englishToolStripMenuItem.Checked = false;
            polishToolStripMenuItem.Checked = true;

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polishToolStripMenuItem.Checked = false;
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
                }
            }
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
                                X = item.Position.X + BookCover.Position.X - (int)g.MeasureString(item.Text, item.Font).Width/2,
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

                    
                    if (e.X < stringRect.Right && e.X  >= stringRect.Left && e.Y < stringRect.Bottom &&
                        e.Y >= stringRect.Top) //check if mouse point is inside the rectangle
                    {
                        g.DrawRectangle(new Pen(Color.Black), stringRect);
                        toremove = item;
                        using (AddTextDialog textDialog = new AddTextDialog())
                        {
                            textDialog.DialogData = new AddTextDialogData
                                {FontSize = (int) item.Font.Size, Text = item.Text, TextAlignment = item.Alignment};
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
                                        toadd = new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point(stringRect.X + (int)stringMeasuresC.Width/2  - BookCover.Position.X, stringRect.Y /*- (int)stringMeasures.Height / 2 */- BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment };
                                        break;
                                    case StringAlignment.Near:
                                       toadd = new StringGraphics { Font = fn, Text = TextContext.Text, Position = new Point(stringRect.X - (-stringRect.Width + (int)(g.MeasureString(TextContext.Text, fn).Width))/2 - BookCover.Position.X, stringRect.Y  /*(int)(g.MeasureString(TextContext.Text, fn).Height )*/ - BookCover.Position.Y), Color = currentTextColor, Alignment = TextContext.TextAlignment }; break;
                                    case StringAlignment.Far:
                                        //this is problematic ?? others work as it should be 
                                        var stringMeasures = (g.MeasureString(TextContext.Text, fn));
                                        var diff = (int)Math.Abs(g.MeasureString(TextContext.Text, fn).Width - stringRect.Width / 2);
                                        if (stringRect.Width > stringMeasures.Width)
                                            diff = (int)Math.Abs(g.MeasureString(TextContext.Text, fn).Width + stringRect.Width/4 );
                                        toadd = new StringGraphics
                                        {
                                            Font = fn, Text = TextContext.Text,

                                            Position = new Point(
                                                stringRect.X + diff  -
                                                BookCover.Position.X,
                                                stringRect.Y /*- (int) stringMeasures.Height / 2*/ - BookCover.Position.Y),
                                            Color = currentTextColor, Alignment = TextContext.TextAlignment
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

            }
                pictureBox.Refresh();
        }
    }
}
