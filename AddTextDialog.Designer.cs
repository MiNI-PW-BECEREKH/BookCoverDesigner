
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTextTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.7707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.2293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textAlignmentGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.fontSizeLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fontSizeNumericUpDown, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 138);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(23, 59);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(69, 20);
            this.fontSizeLabel.TabIndex = 0;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontSizeNumericUpDown
            // 
            this.fontSizeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSizeNumericUpDown.Location = new System.Drawing.Point(119, 55);
            this.fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            this.fontSizeNumericUpDown.Size = new System.Drawing.Size(110, 27);
            this.fontSizeNumericUpDown.TabIndex = 1;
            this.fontSizeNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // textAlignmentGroupBox
            // 
            this.textAlignmentGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.textAlignmentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAlignmentGroupBox.Location = new System.Drawing.Point(241, 3);
            this.textAlignmentGroupBox.Name = "textAlignmentGroupBox";
            this.textAlignmentGroupBox.Size = new System.Drawing.Size(232, 138);
            this.textAlignmentGroupBox.TabIndex = 1;
            this.textAlignmentGroupBox.TabStop = false;
            this.textAlignmentGroupBox.Text = "Text Alignment";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.rightRadioButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.centerRadioButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.leftRadioButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 112);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.Location = new System.Drawing.Point(3, 81);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(65, 24);
            this.rightRadioButton.TabIndex = 2;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.UseVisualStyleBackColor = true;
            this.rightRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // centerRadioButton
            // 
            this.centerRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.centerRadioButton.AutoSize = true;
            this.centerRadioButton.Location = new System.Drawing.Point(3, 43);
            this.centerRadioButton.Name = "centerRadioButton";
            this.centerRadioButton.Size = new System.Drawing.Size(73, 24);
            this.centerRadioButton.TabIndex = 1;
            this.centerRadioButton.TabStop = true;
            this.centerRadioButton.Text = "Center";
            this.centerRadioButton.UseVisualStyleBackColor = true;
            this.centerRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.Location = new System.Drawing.Point(3, 6);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(55, 24);
            this.leftRadioButton.TabIndex = 0;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.UseVisualStyleBackColor = true;
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // addTextTextBox
            // 
            this.addTextTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTextTextBox.Location = new System.Drawing.Point(3, 153);
            this.addTextTextBox.Multiline = true;
            this.addTextTextBox.Name = "addTextTextBox";
            this.addTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addTextTextBox.Size = new System.Drawing.Size(476, 158);
            this.addTextTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 317);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(476, 33);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(72, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(310, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddTextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTextDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Text";
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