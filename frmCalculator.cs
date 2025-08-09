namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {


        private CalculatorClass cal;

        public frmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private double num1;
        private double num2;

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);


            if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an operator.");
                return;
            }

            if (cbOperator.Text == "+")
            {
                cal.formula = cal.GetSum;
                cal.CalculateEvent += null;
                cal.CalculateEvent += cal.formula;

                //trigger/call the event
                //and pass the two numbers to the delegate method
                double result = cal.TriggerCalculation(num1, num2);

                //display the result in the labels
                lblDisplayTotal.Text = result.ToString();
            }

            else if (cbOperator.Text == "-")
            {
                cal.formula = cal.GetDifference;
                cal.CalculateEvent += null;
                cal.CalculateEvent += cal.formula;
                double result = cal.TriggerCalculation(num1, num2);
                lblDisplayTotal.Text = result.ToString();
            }

            else if (cbOperator.Text == "*")
            {
                cal.formula = cal.GetProduct;
                cal.CalculateEvent += null;
                cal.CalculateEvent += cal.formula;
                double result = cal.TriggerCalculation(num1, num2);
                lblDisplayTotal.Text = result.ToString();
            }

            else if (cbOperator.Text == "/")
            {
                cal.formula = cal.GetQuotient;
                cal.CalculateEvent += null;
                cal.CalculateEvent += cal.formula;
                double result = cal.TriggerCalculation(num1, num2);
                if (num2 == 0)
                {
                    lblDisplayTotal.Text = "Cannot divide by zero";
                }
                else
                {
                    lblDisplayTotal.Text = result.ToString();
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }



            }
        }
    }

}