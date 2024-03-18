namespace Lab4
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            BlackCoffeebutton = new Button();
            Lattebutton = new Button();
            Mocha_button = new Button();
            Chocolate_button = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            coffee_box = new TextBox();
            milk_box = new TextBox();
            choco_box = new TextBox();
            water_box = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 67);
            textBox1.TabIndex = 1;
            // 
            // BlackCoffeebutton
            // 
            BlackCoffeebutton.Location = new Point(479, 109);
            BlackCoffeebutton.Name = "BlackCoffeebutton";
            BlackCoffeebutton.Size = new Size(125, 44);
            BlackCoffeebutton.TabIndex = 2;
            BlackCoffeebutton.Text = "Black Coffee";
            BlackCoffeebutton.UseVisualStyleBackColor = true;
            BlackCoffeebutton.Click += BlackCoffeebutton_Click;
            // 
            // Lattebutton
            // 
            Lattebutton.Location = new Point(479, 150);
            Lattebutton.Name = "Lattebutton";
            Lattebutton.Size = new Size(125, 44);
            Lattebutton.TabIndex = 3;
            Lattebutton.Text = "Latte";
            Lattebutton.UseVisualStyleBackColor = true;
            Lattebutton.Click += Lattebutton_Click;
            // 
            // Mocha_button
            // 
            Mocha_button.Location = new Point(479, 190);
            Mocha_button.Name = "Mocha_button";
            Mocha_button.Size = new Size(125, 44);
            Mocha_button.TabIndex = 4;
            Mocha_button.Text = "Mocha";
            Mocha_button.UseVisualStyleBackColor = true;
            Mocha_button.Click += Mocha_button_Click;
            // 
            // Chocolate_button
            // 
            Chocolate_button.Location = new Point(479, 231);
            Chocolate_button.Name = "Chocolate_button";
            Chocolate_button.Size = new Size(125, 44);
            Chocolate_button.TabIndex = 5;
            Chocolate_button.Text = "Chocolate";
            Chocolate_button.UseVisualStyleBackColor = true;
            Chocolate_button.Click += Chocolate_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.downloads;
            pictureBox2.Location = new Point(479, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(coffee_box);
            groupBox1.Controls.Add(milk_box);
            groupBox1.Controls.Add(choco_box);
            groupBox1.Controls.Add(water_box);
            groupBox1.Location = new Point(257, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "วัตถุดิบคงเหลือ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 141);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "กาแฟ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 112);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 6;
            label3.Text = "นม";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "ช๊อคโกเล็ด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 44);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "น้ำ";
            // 
            // coffee_box
            // 
            coffee_box.Location = new Point(19, 138);
            coffee_box.Name = "coffee_box";
            coffee_box.Size = new Size(77, 27);
            coffee_box.TabIndex = 3;
            coffee_box.TextChanged += coffee_box_TextChanged;
            // 
            // milk_box
            // 
            milk_box.Location = new Point(19, 105);
            milk_box.Name = "milk_box";
            milk_box.Size = new Size(77, 27);
            milk_box.TabIndex = 2;
            milk_box.TextChanged += milk_box_TextChanged;
            // 
            // choco_box
            // 
            choco_box.Location = new Point(19, 72);
            choco_box.Name = "choco_box";
            choco_box.Size = new Size(77, 27);
            choco_box.TabIndex = 1;
            choco_box.TextChanged += choco_box_TextChanged;
            // 
            // water_box
            // 
            water_box.Location = new Point(19, 39);
            water_box.Name = "water_box";
            water_box.Size = new Size(77, 27);
            water_box.TabIndex = 0;
            water_box.TextChanged += water_box_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 642);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(Chocolate_button);
            Controls.Add(Mocha_button);
            Controls.Add(Lattebutton);
            Controls.Add(BlackCoffeebutton);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button BlackCoffeebutton;
        private Button Lattebutton;
        private Button Mocha_button;
        private Button Chocolate_button;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox coffee_box;
        private TextBox milk_box;
        private TextBox choco_box;
        private TextBox water_box;
    }
}
