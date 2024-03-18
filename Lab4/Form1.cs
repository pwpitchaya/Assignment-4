namespace Lab4
{
    public partial class Form1 : Form
    {
        coffee_maker coffeemachine;

        public Form1()
        {
            InitializeComponent();
            coffeemachine = new coffee_maker();
            UpdateTextBoxes();

        }

        private void BlackCoffeebutton_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeBlackCoffee();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.BlackCoffee;
                textBox1.Text = "Order completed";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.sorry;
                textBox1.Text = "Not enough objects";
            }
        }

        private void Lattebutton_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeLatte();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Latte;
                textBox1.Text = "Order completed";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.sorry;
                textBox1.Text = "Not enough objects";

            }
        }

        private void Mocha_button_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeMocha();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Mocha;
                textBox1.Text = "Order completed";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.sorry;
                textBox1.Text = "Not enough objects";
            }
        }

        private void Chocolate_button_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeChocolate();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Chocolate;
                textBox1.Text = "Order completed";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.sorry;
                textBox1.Text = "Not enough objects";

            }
        }
        private void UpdateTextBoxes()
        {
            water_box.Text = coffeemachine.water.ToString();
            coffee_box.Text = coffeemachine.coffee.ToString();
            milk_box.Text = coffeemachine.milk.ToString();
            choco_box.Text = coffeemachine.chocolate.ToString();
        }


        private void water_box_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void choco_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void milk_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void coffee_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
