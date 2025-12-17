namespace WinForms.UserDefineFunction
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 78);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "กรอกตัวเลข";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 30);
            textBox1.TabIndex = 1;
            textBox1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 139);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "กำหนดขนาด";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 30);
            textBox2.TabIndex = 3;
            textBox2.Text = "S";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 221);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(630, 430);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(726, 106);
            button1.Name = "button1";
            button1.Size = new Size(196, 79);
            button1.TabIndex = 5;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(589, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 27);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "แบบที่1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(589, 132);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 27);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "เเบบที่2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(589, 174);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 27);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "เเบบที่3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1058, 709);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}