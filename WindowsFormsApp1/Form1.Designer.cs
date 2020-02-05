namespace WindowsFormsApp1
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
            this.Amount = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblFormatted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Amount.Location = new System.Drawing.Point(11, 11);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(164, 48);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtInput.Location = new System.Drawing.Point(181, 8);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(412, 55);
            this.txtInput.TabIndex = 1;
            this.txtInput.DoubleClick += new System.EventHandler(this.txtInput_DoubleClick);
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // lblFormatted
            // 
            this.lblFormatted.AutoSize = true;
            this.lblFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblFormatted.Location = new System.Drawing.Point(34, 80);
            this.lblFormatted.Name = "lblFormatted";
            this.lblFormatted.Size = new System.Drawing.Size(0, 48);
            this.lblFormatted.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(733, 276);
            this.Controls.Add(this.lblFormatted);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.Amount);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountFormatted;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblFormatted;
    }
}

