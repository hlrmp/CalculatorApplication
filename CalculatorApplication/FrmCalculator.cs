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

        public delegate T Information<T>(T arg1);
        public class CalculatorClass
        {

        }
        public Form1()
        {
            InitializeComponent();
            operators();

        }



    }
}