// Project Prolog
// Name: Caleb Baker
// CS3260 Section 001
// Project: Lab_03
// Date: 08/28/2018
// Purpose: Program creates a GUI for the user to do aritmatic on complex numbers
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexArithmeticCalculator
{
    public partial class Calculator : Form
    {
        ///<summary>
        /// This class handles all the operations and event handlers
        /// for the Calculator GUI that the user interacts with./// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(txtReal1.Text != string.Empty && txtReal2.Text != string.Empty 
                && txtImag1.Text != string.Empty && txtImag2.Text != string.Empty)
            {
                string errorMessage = "The Following Fields Need To Be Valid Numbers:\n\n";
                bool isValid = true;
                if(!double.TryParse(txtReal1.Text, out double real1))
                {
                    errorMessage += "Value One Real Number\n";
                    isValid = false;
                }
                if (!double.TryParse(txtImag1.Text, out double imag1))
                {
                    errorMessage += "Value One Imaginary Number\n";
                    isValid = false;
                }
                if (!double.TryParse(txtReal2.Text, out double real2))
                {
                    errorMessage += "Value Two Real Number\n";
                    isValid = false;
                }
                if (!double.TryParse(txtImag2.Text, out double imag2))
                {
                    errorMessage += "Value Two Imaginary Number\n";
                    isValid = false;
                }
                if (isValid)
                {
                    string sign1 = cbSign1.Text;
                    string sign2 = cbSign2.Text;
                    ComplexData value1 = new ComplexData(real1, Convert.ToDouble(sign1 + imag1.ToString()));
                    ComplexData value2 = new ComplexData(real2, Convert.ToDouble(sign2 + imag2.ToString()));
                    ComplexArithmetic ca = new ComplexArithmetic();
                    ComplexData result = null;
                    switch(cbArithmetic.Text)
                    {
                        case "ADD":
                            result = ca.Add(value1, value2);
                            break;
                        case "SUBTRACT":
                            result = ca.Subtract(value1, value2);
                            break;
                        case "MULTIPLY":
                            result = ca.Multiply(value1, value2);
                            break;
                        case "DIVIDE":
                            result = ca.Divide(value1, value2);
                            break;
                    }
                    //txtResults.AppendText(cbArithmetic.Text + ": " + result.ToString() + "\n");
                    txtResults.AppendText(String.Format("{0,-8}: {1,5}\n", cbArithmetic.Text, result.ToString(), 114));
                }
                else
                {
                    MessageBox.Show(errorMessage, "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Value In All Given Fields.", 
                    "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
