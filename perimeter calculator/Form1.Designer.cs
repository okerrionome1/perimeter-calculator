namespace perimeter_calculator
{
    partial class perimeterCalc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSidelenght = new System.Windows.Forms.TextBox();
            this.lblSidelenght = new System.Windows.Forms.Label();
            this.btnFindPerimeter = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::perimeter_calculator.Properties.Resources.square;
            this.pictureBox1.Location = new System.Drawing.Point(497, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtSidelenght
            // 
            this.txtSidelenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSidelenght.Location = new System.Drawing.Point(24, 29);
            this.txtSidelenght.Name = "txtSidelenght";
            this.txtSidelenght.Size = new System.Drawing.Size(185, 61);
            this.txtSidelenght.TabIndex = 1;
            this.txtSidelenght.TextChanged += new System.EventHandler(this.txtSidelenght_TextChanged);
            // 
            // lblSidelenght
            // 
            this.lblSidelenght.AutoSize = true;
            this.lblSidelenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidelenght.Location = new System.Drawing.Point(447, 188);
            this.lblSidelenght.Name = "lblSidelenght";
            this.lblSidelenght.Size = new System.Drawing.Size(0, 39);
            this.lblSidelenght.TabIndex = 2;
            // 
            // btnFindPerimeter
            // 
            this.btnFindPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFindPerimeter.Location = new System.Drawing.Point(24, 146);
            this.btnFindPerimeter.Name = "btnFindPerimeter";
            this.btnFindPerimeter.Size = new System.Drawing.Size(130, 57);
            this.btnFindPerimeter.TabIndex = 3;
            this.btnFindPerimeter.Text = "FInd";
            this.btnFindPerimeter.UseVisualStyleBackColor = true;
            this.btnFindPerimeter.Click += new System.EventHandler(this.btnFindPerimeter_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPerimeter.Location = new System.Drawing.Point(22, 296);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(0, 36);
            this.lblPerimeter.TabIndex = 4;
            // 
            // perimeterCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnFindPerimeter);
            this.Controls.Add(this.lblSidelenght);
            this.Controls.Add(this.txtSidelenght);
            this.Controls.Add(this.pictureBox1);
            this.Name = "perimeterCalc";
            this.Text = "Perimeter Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSidelenght;
        private System.Windows.Forms.Label lblSidelenght;
        private System.Windows.Forms.Button btnFindPerimeter;
        private System.Windows.Forms.Label lblPerimeter;
    }
}

