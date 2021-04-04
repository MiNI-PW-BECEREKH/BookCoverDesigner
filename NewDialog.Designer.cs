
namespace WinFormsLab
{
    partial class NewDialog
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
            this.newDialogTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.spineWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.spineWidthLabel = new System.Windows.Forms.Label();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newDialogTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spineWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newDialogTableLayoutPanel
            // 
            this.newDialogTableLayoutPanel.ColumnCount = 2;
            this.newDialogTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newDialogTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.newDialogTableLayoutPanel.Controls.Add(this.okButton, 0, 3);
            this.newDialogTableLayoutPanel.Controls.Add(this.spineWidthNumericUpDown, 1, 2);
            this.newDialogTableLayoutPanel.Controls.Add(this.spineWidthLabel, 0, 2);
            this.newDialogTableLayoutPanel.Controls.Add(this.heightNumericUpDown, 1, 1);
            this.newDialogTableLayoutPanel.Controls.Add(this.heightLabel, 0, 1);
            this.newDialogTableLayoutPanel.Controls.Add(this.widthLabel, 0, 0);
            this.newDialogTableLayoutPanel.Controls.Add(this.widthNumericUpDown, 1, 0);
            this.newDialogTableLayoutPanel.Controls.Add(this.cancelButton, 0, 3);
            this.newDialogTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newDialogTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.newDialogTableLayoutPanel.Name = "newDialogTableLayoutPanel";
            this.newDialogTableLayoutPanel.RowCount = 4;
            this.newDialogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.newDialogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.newDialogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.newDialogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.newDialogTableLayoutPanel.Size = new System.Drawing.Size(382, 253);
            this.newDialogTableLayoutPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(239, 206);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // spineWidthNumericUpDown
            // 
            this.spineWidthNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spineWidthNumericUpDown.Location = new System.Drawing.Point(230, 144);
            this.spineWidthNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.spineWidthNumericUpDown.Name = "spineWidthNumericUpDown";
            this.spineWidthNumericUpDown.Size = new System.Drawing.Size(113, 27);
            this.spineWidthNumericUpDown.TabIndex = 6;
            this.spineWidthNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // spineWidthLabel
            // 
            this.spineWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spineWidthLabel.AutoSize = true;
            this.spineWidthLabel.Location = new System.Drawing.Point(50, 147);
            this.spineWidthLabel.Name = "spineWidthLabel";
            this.spineWidthLabel.Size = new System.Drawing.Size(90, 20);
            this.spineWidthLabel.TabIndex = 5;
            this.spineWidthLabel.Text = "Spine Width";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightNumericUpDown.Location = new System.Drawing.Point(230, 81);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(113, 27);
            this.heightNumericUpDown.TabIndex = 4;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(68, 84);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(54, 20);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(71, 21);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(49, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthNumericUpDown.Location = new System.Drawing.Point(230, 18);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(113, 27);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(48, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.newDialogTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Cover ...";
            this.newDialogTableLayoutPanel.ResumeLayout(false);
            this.newDialogTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spineWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel newDialogTableLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown spineWidthNumericUpDown;
        private System.Windows.Forms.Label spineWidthLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Button cancelButton;
    }
}