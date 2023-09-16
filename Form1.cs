namespace FrmCalculator
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(firstNum.Text);
            num2 = Convert.ToDouble(secondNum.Text);
            if (operators.Text == "+") 
            {
                cal.CalculateEvent += new Information<double>(cal.GetSum);
                answer.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetSum);
            }
            else if (operators.Text == "-")
            {
                cal.CalculateEvent += new Information<double>(cal.GetDifference);
                answer.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetDifference);
            }
            else if (operators.Text == "*")
            {
                cal.CalculateEvent += new Information<double>(cal.GetProduct);
                answer.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetProduct);
            }
            else if (operators.Text == "/")
            {
                cal.CalculateEvent += new Information<double>(cal.GetQuotient);
                answer.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(cal.GetQuotient);
            }
        }
    }
}