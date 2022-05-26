namespace WikiMaker
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
            this.SelectFile = new System.Windows.Forms.Button();
            this.Worked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(106, 39);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(112, 34);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select DLL";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Worked
            // 
            this.Worked.AutoSize = true;
            this.Worked.Location = new System.Drawing.Point(155, 136);
            this.Worked.Name = "Worked";
            this.Worked.Size = new System.Drawing.Size(0, 25);
            this.Worked.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 398);
            this.Controls.Add(this.Worked);
            this.Controls.Add(this.SelectFile);
            this.Name = "Form1";
            this.Text = "WikiMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectFile;
        private Label Worked;
        private PictureBox pictureBox1;
    }
}