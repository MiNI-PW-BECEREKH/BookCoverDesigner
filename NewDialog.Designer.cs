
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDialog));
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
            resources.ApplyResources(this.newDialogTableLayoutPanel, "newDialogTableLayoutPanel");
            this.newDialogTableLayoutPanel.Controls.Add(this.okButton, 0, 3);
            this.newDialogTableLayoutPanel.Controls.Add(this.spineWidthNumericUpDown, 1, 2);
            this.newDialogTableLayoutPanel.Controls.Add(this.spineWidthLabel, 0, 2);
            this.newDialogTableLayoutPanel.Controls.Add(this.heightNumericUpDown, 1, 1);
            this.newDialogTableLayoutPanel.Controls.Add(this.heightLabel, 0, 1);
            this.newDialogTableLayoutPanel.Controls.Add(this.widthLabel, 0, 0);
            this.newDialogTableLayoutPanel.Controls.Add(this.widthNumericUpDown, 1, 0);
            this.newDialogTableLayoutPanel.Controls.Add(this.cancelButton, 0, 3);
            this.newDialogTableLayoutPanel.Name = "newDialogTableLayoutPanel";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // spineWidthNumericUpDown
            // 
            resources.ApplyResources(this.spineWidthNumericUpDown, "spineWidthNumericUpDown");
            this.spineWidthNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.spineWidthNumericUpDown.Name = "spineWidthNumericUpDown";
            this.spineWidthNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // spineWidthLabel
            // 
            resources.ApplyResources(this.spineWidthLabel, "spineWidthLabel");
            this.spineWidthLabel.Name = "spineWidthLabel";
            // 
            // heightNumericUpDown
            // 
            resources.ApplyResources(this.heightNumericUpDown, "heightNumericUpDown");
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // heightLabel
            // 
            resources.ApplyResources(this.heightLabel, "heightLabel");
            this.heightLabel.Name = "heightLabel";
            // 
            // widthLabel
            // 
            resources.ApplyResources(this.widthLabel, "widthLabel");
            this.widthLabel.Name = "widthLabel";
            // 
            // widthNumericUpDown
            // 
            resources.ApplyResources(this.widthNumericUpDown, "widthNumericUpDown");
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newDialogTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewDialog";
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