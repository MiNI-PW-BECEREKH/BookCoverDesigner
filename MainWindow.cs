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


            englishToolStripMenuItem.Checked = true;

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            BookCover.Draw(e.Graphics, pictureBox);
            
            System.GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (additionalTextTextBox.Text == String.Empty)
                return;
            else
            {
                pictureBox.Cursor = Cursors.Cross;
                selectedtext = additionalTextTextBox.Text;
            }
        }


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedtext != null && pictureBox.Cursor == Cursors.Cross)
            {
                pictureBox.Cursor = Cursors.Default;
                
                using (Graphics g = pictureBox.CreateGraphics())
                {
                    Font fn = new Font("Arial", 16, FontStyle.Bold);
                    BookCover.TextList.Add(new StringGraphics {Font =fn ,Text = selectedtext, Position = new Point(e.X - (int)(g.MeasureString(selectedtext,fn).Width / 2) - BookCover.Position.X, e.Y - (int)(g.MeasureString(selectedtext, fn).Height / 2) - BookCover.Position.Y),Color = currentTextColor });
                    pictureBox.Refresh();
                    
                }
                additionalTextTextBox.Text = String.Empty;
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
    }
}
