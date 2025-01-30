namespace OOP_ella
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(50, 232);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(49, 293);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 5;
            label1.Text = "radius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 6;
            label2.Text = "base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 144);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 7;
            label3.Text = "height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 204);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 8;
            label4.Text = "width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 266);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 9;
            label5.Text = "length";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(251, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 204);
            listBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(251, 51);
            button1.Name = "button1";
            button1.Size = new Size(69, 34);
            button1.TabIndex = 11;
            button1.Text = "circle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(326, 49);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 12;
            button2.Text = "rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(427, 51);
            button3.Name = "button3";
            button3.Size = new Size(84, 31);
            button3.TabIndex = 13;
            button3.Text = "triangle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(251, 89);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 31);
            textBox6.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 570);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
    }
}
