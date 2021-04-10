
namespace WinFormsLab
{
    partial class AddTextDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTextDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textAlignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.centerRadioButton = new System.Windows.Forms.RadioButton();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.addTextTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumericUpDown)).BeginInit();
            this.textAlignmentGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTextTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textAlignmentGroupBox, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.fontSizeLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fontSizeNumericUpDown, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // fontSizeLabel
            // 
            resources.ApplyResources(this.fontSizeLabel, "fontSizeLabel");
            this.fontSizeLabel.Name = "fontSizeLabel";
            // 
            // fontSizeNumericUpDown
            // 
            resources.ApplyResources(this.fontSizeNumericUpDown, "fontSizeNumericUpDown");
            this.fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            this.fontSizeNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // textAlignmentGroupBox
            // 
            this.textAlignmentGroupBox.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.textAlignmentGroupBox, "textAlignmentGroupBox");
            this.textAlignmentGroupBox.Name = "textAlignmentGroupBox";
            this.textAlignmentGroupBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.rightRadioButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.centerRadioButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.leftRadioButton, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // rightRadioButton
            // 
            resources.ApplyResources(this.rightRadioButton, "rightRadioButton");
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Tag = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            this.rightRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // centerRadioButton
            // 
            resources.ApplyResources(this.centerRadioButton, "centerRadioButton");
            this.centerRadioButton.Name = "centerRadioButton";
            this.centerRadioButton.TabStop = true;
            this.centerRadioButton.Tag = "Center";
            this.centerRadioButton.UseVisualStyleBackColor = true;
            this.centerRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // leftRadioButton
            // 
            resources.ApplyResources(this.leftRadioButton, "leftRadioButton");
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Tag = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // addTextTextBox
            // 
            resources.ApplyResources(this.addTextTextBox, "addTextTextBox");
            this.addTextTextBox.Name = "addTextTextBox";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddTextDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTextDialog";
            this.Load += new System.EventHandler(this.AddTextDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumericUpDown)).EndInit();
            this.textAlignmentGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.NumericUpDown fontSizeNumericUpDown;
        private System.Windows.Forms.GroupBox textAlignmentGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rightRadioButton;
        private System.Windows.Forms.RadioButton centerRadioButton;
        private System.Windows.Forms.RadioButton leftRadioButton;
        private System.Windows.Forms.TextBox addTextTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}