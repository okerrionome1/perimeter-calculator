namespace using_tenery_operator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFormattedAmount = new System.Windows.Forms.Label();
            this.lblFinalAmount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Amount.Location = new System.Drawing.Point(63, 17);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(198, 58);
            this.Amount.TabIndex = 0;
            this.Amount.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(267, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 64);
            this.textBox1.TabIndex = 1;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // lblFormattedAmount
            // 
            this.lblFormattedAmount.AutoSize = true;
            this.lblFormattedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFormattedAmount.Location = new System.Drawing.Point(85, 88);
            this.lblFormattedAmount.Name = "lblFormattedAmount";
            this.lblFormattedAmount.Size = new System.Drawing.Size(0, 58);
            this.lblFormattedAmount.TabIndex = 2;
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFinalAmount.Location = new System.Drawing.Point(97, 284);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(0, 58);
            this.lblFinalAmount.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Increase by 10%",
            "Decrease by 10%"});
            this.comboBox1.Location = new System.Drawing.Point(73, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(585, 66);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFinalAmount);
            this.Controls.Add(this.lblFormattedAmount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFormattedAmount;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

