using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_WinFormInterestRateCalculator
{
    public partial class frmInterestCalculator : Form
    {
        public frmInterestCalculator()
        {
            InitializeComponent();
            ResetControls();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal principal;
            double rate;
            double year;
            decimal amount;
            string output;

            try
            {
                principal = Convert.ToDecimal(txtPrincipleAmount.Text);
                if (principal <= 0)
                    throw new FormatException("Principal amout must be greater than 0");

                rate = Convert.ToDouble(nudInterestRate.Value);
                if (rate < 0)
                    throw new ApplicationException("Interest rate must be greater than or equal to 0.");

                year = Convert.ToDouble(nudYear.Value);

                output = "Year\tAmount on Deposit\r\n";

                double yearCounter = 0.5;

                for (yearCounter = 0.5; yearCounter <= year; yearCounter += 0.5)
                {
                    amount = principal * ((decimal)Math.Pow((1 + rate / 100), yearCounter));

                    output += ($"{yearCounter}\t{amount:C2}\r\n");
                }// End of for

                txtPrincipleAmount.Text = principal.ToString("C");
                txtDisplay.Text = output;

            } //End of try
            catch (Exception)
            {
                MessageBox.Show("There is an invalid value in input field",
                                "Interest Calculator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }// End of catch

        }// End of btnCalculate_Click

        private void SetBackground()
        {
            txtPrincipleAmount.BackColor = Color.AliceBlue;
            nudYear.ForeColor = Color.DarkBlue;
            nudYear.BackColor = Color.AliceBlue;
            nudInterestRate.ForeColor = Color.DarkBlue;
            nudInterestRate.BackColor = Color.AliceBlue;
            btnClear.BackColor = Color.AliceBlue;
            btnCalculate.BackColor = Color.AliceBlue;
            this.BackColor = Color.Ivory;
        }

        private void ResetControls()
        {
            SetBackground();
            txtDisplay.Text = String.Empty;
            nudInterestRate.Value = 0.1M;
            nudInterestRate.Increment = 0.05M;
            nudInterestRate.DecimalPlaces = 2;
            nudYear.Value = 0.50M;
            nudYear.Increment = 0.5M;
            nudYear.DecimalPlaces = 3;
            txtPrincipleAmount.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
