using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FarazAliProject3A
{

    

    public partial class frmDivision : Form
    {
        
        public frmDivision()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //decimal input1 = Convert.ToDecimal(txtInput1.Text);
                //decimal input2 = Convert.ToDecimal(txtInput2.Text);
                string input1 = txtInput1.Text;
                input1 = input1.RemoveSpecialCharacters();
                string input2 = txtInput2.Text;
                input2 = input2.RemoveSpecialCharacters();

                decimal input11 = Convert.ToDecimal(input1);
                decimal input22 = Convert.ToDecimal(input2);


                decimal result = input11 / input22;
                txtResult.Text = result.ToString("n");
            }

            catch(FormatException)
            {
                MessageBox.Show("Invalid numeric format. Please check all the entries.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow error. Please enter smaller values.", "Entry Error");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("You tried to divide by Zero. Please check the second entry.", "Entry Error");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           



            txtInput1.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
            txtResult.Text = "";

            txtInput1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmDivision_Load(object sender, EventArgs e)
        {

        }
    }
    public static class MethodExtensionHelper
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }

}
