namespace EasyCompress
{
    partial class FileSelectionForm
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
            this.openFileDialogSelection = new System.Windows.Forms.OpenFileDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CompressionTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialogSelection
            // 
            this.openFileDialogSelection.FileName = "openFileDialogSelection";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(198, 67);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(114, 47);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse..";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(198, 256);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(114, 46);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Agency FB", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(37, 352);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.ErrorLabel.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // CompressionTypeLabel
            // 
            this.CompressionTypeLabel.AutoSize = true;
            this.CompressionTypeLabel.Location = new System.Drawing.Point(198, 132);
            this.CompressionTypeLabel.Name = "CompressionTypeLabel";
            this.CompressionTypeLabel.Size = new System.Drawing.Size(97, 13);
            this.CompressionTypeLabel.TabIndex = 4;
            this.CompressionTypeLabel.Text = "Compression Type:";
            // 
            // FileSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 423);
            this.Controls.Add(this.CompressionTypeLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.BrowseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileSelectionForm";
            this.Text = "File Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSelection;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CompressionTypeLabel;
    }
}