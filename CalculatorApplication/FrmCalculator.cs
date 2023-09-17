using System.Collections;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {

        public void operators()
        {
            ArrayList array = new ArrayList();
            array.Add("-");
            array.Add("+");
            array.Add("*");
            array.Add("/");

            foreach (string op in array)
            {
                comboBoxoperators.Items.Add(op);
            }
        }

        private CalculatorClass cal;

        double num1;
        double num2;


        public Form1()
        {
            InitializeComponent();
            operators();
            cal = new CalculatorClass();

        }

        private void buttoncal_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtinput1.Text);
                num2 = Convert.ToDouble(txtinput2.Text);



                if (comboBoxoperators.Text.ToString().Equals("-"))
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                }
                else if (comboBoxoperators.Text.ToString().Equals("+"))
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                }
                else if (comboBoxoperators.Text.ToString().Equals("*"))
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                }
                else if (comboBoxoperators.Text.ToString().Equals("/"))
                {
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                }
                else
                {
                    MessageBox.Show("select an operator");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter number only ");
            }
           

        }


    }
}

/*
        MessageBox.Show(comboBoxoperators.Text.ToString());     // trial code to see the error
        double n = cal.GetDifference(num1,num2);
        MessageBox.Show(Convert.ToString(n));
 */