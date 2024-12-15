using MergePDF.Resources;

namespace MergePDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFolder = new Label();
            txtPath = new TextBox();
            btnFolder = new Button();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(12, 9);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(80, 9);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(606, 23);
            txtPath.TabIndex = 1;
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(692, 9);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(96, 23);
            btnFolder.TabIndex = 2;
            btnFolder.Text = Messages.BUTTON_FOLDER_OPEN;
            btnFolder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFolder);
            Controls.Add(txtPath);
            Controls.Add(lblFolder);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private TextBox txtPath;
        private Button btnFolder;
    }
}
