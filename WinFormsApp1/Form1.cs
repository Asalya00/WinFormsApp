namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Discount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate discount and discounted price
            try
            {
                decimal originalPrice = decimal.Parse(textBox1.Text);
                decimal discountRate = decimal.Parse(listBox1.SelectedItem.ToString().Substring(0, 2)) / 100;
                decimal discount = originalPrice * discountRate;
                decimal discountedPrice = originalPrice - discount;

                textBox2.Text = discount.ToString("C2"); // Format as currency
                textBox3.Text = discountedPrice.ToString("C2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit the application
            Close();
        }
    }
}
