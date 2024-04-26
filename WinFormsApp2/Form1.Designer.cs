namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            cb1 = new ComboBox();
            cb2 = new ComboBox();
            cb3 = new ComboBox();
            cb4 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // t1
            // 
            t1.Location = new Point(40, 145);
            t1.Name = "t1";
            t1.Size = new Size(150, 23);
            t1.TabIndex = 0;
            t1.TextChanged += textBox1_TextChanged;
            // 
            // t2
            // 
            t2.Location = new Point(196, 145);
            t2.Name = "t2";
            t2.Size = new Size(137, 23);
            t2.TabIndex = 1;
            // 
            // t3
            // 
            t3.Location = new Point(339, 145);
            t3.Name = "t3";
            t3.Size = new Size(100, 23);
            t3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 3;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label2.Location = new Point(196, 120);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label3.Location = new Point(339, 120);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 5;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label4.Location = new Point(68, 174);
            label4.Name = "label4";
            label4.Size = new Size(82, 22);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label5.Location = new Point(68, 216);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 7;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 14.25F, FontStyle.Italic);
            label6.Location = new Point(144, 258);
            label6.Name = "label6";
            label6.Size = new Size(189, 22);
            label6.TabIndex = 8;
            label6.Text = "Program to apply";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(543, 42);
            label7.TabIndex = 9;
            label7.Text = "Student Registration Form";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(156, 177);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;

            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(213, 177);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(176, 215);
            cb1.Name = "cb1";
            cb1.Size = new Size(68, 23);
            cb1.TabIndex = 12;
            cb1.Text = "Day";

            // 
            // cb2
            // 
            cb2.FormattingEnabled = true;
            cb2.Location = new Point(250, 215);
            cb2.Name = "cb2";
            cb2.Size = new Size(120, 23);
            cb2.TabIndex = 13;
            cb2.Text = "Month";
            // 
            // cb3
            // 
            cb3.FormattingEnabled = true;
            cb3.Location = new Point(376, 215);
            cb3.Name = "cb3";
            cb3.Size = new Size(86, 23);
            cb3.TabIndex = 14;
            cb3.Text = "Year";
            // 
            // cb4
            // 
            cb4.FormattingEnabled = true;
            cb4.Location = new Point(86, 283);
            cb4.Name = "cb4";
            cb4.Size = new Size(336, 23);
            cb4.TabIndex = 15;
            cb4.Text = "Programs";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(144, 372);
            button1.Name = "button1";
            button1.Size = new Size(214, 45);
            button1.TabIndex = 16;
            button1.Text = "Register Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(550, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 426);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cb4);
            Controls.Add(cb3);
            Controls.Add(cb2);
            Controls.Add(cb1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(t3);
            Controls.Add(t2);
            Controls.Add(t1);
            Name = "Form1";
            Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox t1;
        private TextBox t2;
        private TextBox t3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox cb1;
        private ComboBox cb2;
        private ComboBox cb3;
        private ComboBox cb4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
