namespace ProgrammingExercise3_1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double inches))
            {
                double centimeters = ConvertInchesToCentimeters(inches);
                textBox2.Text = centimeters.ToString();
            }
            else
            {
                textBox2.Text = "Invalid input";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
}