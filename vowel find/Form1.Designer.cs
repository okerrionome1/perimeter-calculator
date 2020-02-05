namespace vowel_find
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
            this.rchVowelnput = new System.Windows.Forms.RichTextBox();
            this.btnVowelFind = new System.Windows.Forms.Button();
            this.rchVowelsOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchVowelnput
            // 
            this.rchVowelnput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rchVowelnput.Location = new System.Drawing.Point(5, 0);
            this.rchVowelnput.Name = "rchVowelnput";
            this.rchVowelnput.Size = new System.Drawing.Size(788, 96);
            this.rchVowelnput.TabIndex = 0;
            this.rchVowelnput.Text = "";
            // 
            // btnVowelFind
            // 
            this.btnVowelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnVowelFind.Location = new System.Drawing.Point(5, 102);
            this.btnVowelFind.Name = "btnVowelFind";
            this.btnVowelFind.Size = new System.Drawing.Size(788, 99);
            this.btnVowelFind.TabIndex = 1;
            this.btnVowelFind.Text = "FIND A VOWEL";
            this.btnVowelFind.UseVisualStyleBackColor = true;
            this.btnVowelFind.Click += new System.EventHandler(this.btnVowelFind_Click);
            // 
            // rchVowelsOutput
            // 
            this.rchVowelsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.rchVowelsOutput.Location = new System.Drawing.Point(6, 207);
            this.rchVowelsOutput.Name = "rchVowelsOutput";
            this.rchVowelsOutput.Size = new System.Drawing.Size(788, 547);
            this.rchVowelsOutput.TabIndex = 2;
            this.rchVowelsOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.rchVowelsOutput);
            this.Controls.Add(this.btnVowelFind);
            this.Controls.Add(this.rchVowelnput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchVowelnput;
        private System.Windows.Forms.Button btnVowelFind;
        private System.Windows.Forms.RichTextBox rchVowelsOutput;
    }
}

