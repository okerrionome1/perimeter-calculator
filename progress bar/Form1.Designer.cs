namespace progress_bar
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Fill = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(766, 65);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // Fill
            // 
            this.Fill.AutoSize = true;
            this.Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Fill.Location = new System.Drawing.Point(21, 96);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(89, 58);
            this.Fill.TabIndex = 1;
            this.Fill.Text = "Fill";
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Reset.Location = new System.Drawing.Point(466, 96);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(156, 58);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(766, 494);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Fill;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

