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
    public partial class NewDialog : Form
    {
        public NewCoverDialogData DialogData = new NewCoverDialogData();
        public NewDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            DialogData.Height = (int)heightNumericUpDown.Value;
            DialogData.Width = (int) widthNumericUpDown.Value;
            DialogData.SpineWidth = (int) spineWidthNumericUpDown.Value;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
