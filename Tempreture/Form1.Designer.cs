namespace Tempreture
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(138, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Celcius (C)";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(323, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 27);
            textBox4.TabIndex = 2;
            textBox4.Text = "Fahrenheit";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(522, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 27);
            textBox5.TabIndex = 3;
            textBox5.Text = "Kelvin";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Enabled = false;
            textBox1.Location = new Point(138, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(496, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Tempreture Converter";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 27);
            textBox3.TabIndex = 5;
            textBox3.KeyDown += input_KeyDown;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(323, 184);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 27);
            textBox6.TabIndex = 6;
            textBox6.KeyDown += input_KeyDown;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(522, 184);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(112, 27);
            textBox7.TabIndex = 7;
            textBox7.KeyDown += input_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}