namespace Grafic
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblminX = new System.Windows.Forms.Label();
            this.LblmaxX = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblStep = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(1100, 42);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(107, 54);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1102, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 2;
            // 
            // LblminX
            // 
            this.LblminX.AutoSize = true;
            this.LblminX.Location = new System.Drawing.Point(1099, 151);
            this.LblminX.Name = "LblminX";
            this.LblminX.Size = new System.Drawing.Size(36, 16);
            this.LblminX.TabIndex = 3;
            this.LblminX.Text = "minX";
            // 
            // LblmaxX
            // 
            this.LblmaxX.AutoSize = true;
            this.LblmaxX.Location = new System.Drawing.Point(1099, 211);
            this.LblmaxX.Name = "LblmaxX";
            this.LblmaxX.Size = new System.Drawing.Size(40, 16);
            this.LblmaxX.TabIndex = 5;
            this.LblmaxX.Text = "maxX";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1102, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 4;
            // 
            // LblStep
            // 
            this.LblStep.AutoSize = true;
            this.LblStep.Location = new System.Drawing.Point(1099, 274);
            this.LblStep.Name = "LblStep";
            this.LblStep.Size = new System.Drawing.Size(35, 16);
            this.LblStep.TabIndex = 7;
            this.LblStep.Text = "Step";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1102, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 22);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 587);
            this.Controls.Add(this.LblStep);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblmaxX);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblminX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblminX;
        private System.Windows.Forms.Label LblmaxX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblStep;
        private System.Windows.Forms.TextBox textBox3;
    }
}

