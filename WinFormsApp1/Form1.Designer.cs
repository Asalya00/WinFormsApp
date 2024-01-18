namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            Discount = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 75);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 2;
            label1.Text = "Original price:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 75);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 3;
            label2.Text = "Discount rates(%):";
            label2.Click += label2_Click;
            // 
            // Discount
            // 
            Discount.AutoSize = true;
            Discount.Location = new Point(94, 272);
            Discount.Name = "Discount";
            Discount.Size = new Size(86, 25);
            Discount.TabIndex = 4;
            Discount.Text = "Discount:";
            Discount.Click += Discount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 272);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 6;
            label3.Text = "Discount price:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(568, 381);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(450, 381);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(390, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "10 ", "15 ", "20 ", "25 ", "30", "35", "40" });
            listBox1.Location = new Point(390, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(83, 129);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 31);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(845, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(Discount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Discount Warehouse";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label Discount;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}
