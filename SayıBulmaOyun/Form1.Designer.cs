namespace SayıBulmaOyun
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
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(14, 43);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(189, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(221, 41);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 2;
            button1.Text = "Sayı Üret";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(62, 90);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tekrarlı";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(196, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tekrarsız";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 130);
            textBox1.MaxLength = 1;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 41);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 130);
            textBox2.MaxLength = 1;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 41);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 130);
            textBox3.MaxLength = 1;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 41);
            textBox3.TabIndex = 7;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 130);
            textBox4.MaxLength = 1;
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(51, 41);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(286, 130);
            textBox5.MaxLength = 1;
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(51, 41);
            textBox5.TabIndex = 9;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Location = new Point(14, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(51, 20);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(82, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(51, 20);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Location = new Point(150, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(51, 20);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(218, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 20);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.Location = new Point(286, 167);
            panel5.Name = "panel5";
            panel5.Size = new Size(51, 20);
            panel5.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 312);
            label1.Name = "label1";
            label1.Size = new Size(151, 35);
            label1.TabIndex = 12;
            label1.Text = "Kalan Süre : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(231, 312);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 436);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(62, 221);
            button2.Name = "button2";
            button2.Size = new Size(221, 73);
            button2.TabIndex = 15;
            button2.Text = "Kontrol Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(148, 8);
            numericUpDown2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(189, 27);
            numericUpDown2.TabIndex = 16;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 15);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 17;
            label4.Text = "HAK SAYISI";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(231, 372);
            label5.Name = "label5";
            label5.Size = new Size(0, 35);
            label5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(28, 372);
            label6.Name = "label6";
            label6.Size = new Size(145, 35);
            label6.TabIndex = 18;
            label6.Text = "Kalan Hak : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 497);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Sayı Bulma Oyunu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label label6;
    }
}
