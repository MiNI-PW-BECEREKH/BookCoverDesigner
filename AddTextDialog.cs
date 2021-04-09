using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    public class AddTextDialogData
    {
        public StringAlignment TextAlignment { get; set; }
        public string Text { get; set; }
        public int FontSize { get; set; }

    }

    public partial class AddTextDialog : Form
    {
        public AddTextDialogData DialogData = new AddTextDialogData();
        public AddTextDialog()
        {
            InitializeComponent();
        }

        protected void CheckChanged(object sender, EventArgs e)
        {
            var checkedButton = tableLayoutPanel4.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            switch (checkedButton.Text)
            {
                case "Left":
                    addTextTextBox.TextAlign = HorizontalAlignment.Left;
                    break;
                case "Center":
                    addTextTextBox.TextAlign = HorizontalAlignment.Center;
                    break;
                case "Right":
                    addTextTextBox.TextAlign = HorizontalAlignment.Right;
                    break;
                
            }
        }

        private void AddTextDialog_Load(object sender, EventArgs e)
        {
            leftRadioButton.Checked = true;
            if (DialogData.Text != null)
            {
                fontSizeNumericUpDown.Value = DialogData.FontSize;
                addTextTextBox.Text = DialogData.Text;
                switch (DialogData.TextAlignment)
                {
                    case StringAlignment.Center:
                        centerRadioButton.Checked = true;
                        break;
                    case StringAlignment.Near:
                        leftRadioButton.Checked = true;
                        break;
                    case StringAlignment.Far:
                        rightRadioButton.Checked = true;
                        break;
                    
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            //Initialize data to public member;
            DialogData.Text = addTextTextBox.Text;
            DialogData.FontSize = (int)fontSizeNumericUpDown.Value;
            switch (addTextTextBox.TextAlign)
            {
                case HorizontalAlignment.Center:
                    DialogData.TextAlignment = StringAlignment.Center;
                    break;
                case HorizontalAlignment.Left:
                    DialogData.TextAlignment = StringAlignment.Near;
                    break;
                case HorizontalAlignment.Right:
                    DialogData.TextAlignment = StringAlignment.Far;
                    break;
            }
            //DialogData.TextAlignment = (StringAlignment)addTextTextBox.TextAlign;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
