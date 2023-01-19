namespace Session_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        enum Operation
        {
            Addition,
            Substraction,
            Product,
            Division,
            Sqrt,
            Power
        }
        private Operation _operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void buttonEigth_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            display.Text += "^";
            _operation=Operation.Power;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            display.Text += "sqrt:";
            _operation = Operation.Sqrt;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            display.Text += "=";
            switch (_operation)
            {
                case Operation.Addition:
                    _result = _value1 + _value2;
                break;
                case Operation.Substraction: 
                    _result = _value1 - _value2;
                break;
                case Operation.Division:
                    _result = _value1 / _value2;
                break;
                case Operation.Product: 
                    _result = _value1 * _value2;
                break;
                case Operation.Sqrt:
                    _result = (decimal?)Math.Sqrt((double)_value1);
                break;
                case Operation.Power:
                    _result = (decimal?)Math.Pow((double)_value1, (double)_value2);
                break;
                default:
                break;
            }
            display.Text = String.Format("{0}",_result);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            display.Text += "+";
            _operation = Operation.Addition;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            display.Text += "-";
            _operation = Operation.Substraction;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            display.Text += "*";
            _operation= Operation.Product;

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            display.Text += "/";
            _operation= Operation.Division;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }
    }
}