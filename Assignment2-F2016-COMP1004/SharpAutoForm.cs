using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_F2016_COMP1004
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }





        /// <summary>
        /// This method allows you to use the menuStrip to get some information about the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a car trade in calculator making you're trade in's easier since 1999!");
        }


        /// <summary>
        /// The calculate method deals with a lot of the core function of the Form Producing the SubTotal, Total, and amount due.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {


            const double _Tax = 0.13;
            double _SalesTax;
            double _BasePrice;
            double _AdditionalOptions;
            double _SubTotal;
            double _Total;
            double _TradeInAllowance;
            double _AmountDue;


            
            _BasePrice = Convert.ToDouble(BasePriceTextBox.Text);
            _TradeInAllowance = Convert.ToDouble(TradeInAllowanceTextBox.Text);
            

            if (StandardRadioButton.Checked == true)
            {
                _AdditionalOptions = 150;
            }
            else if (PearlizedRadioButton.Checked == true)
            {
                _AdditionalOptions = 1500;
            }
            else
            {
                _AdditionalOptions = 7500;
            }
            
            AdditionalOptionsTextBox.Text = _AdditionalOptions.ToString();

            // Addes the Additional Options and Base price to get the Subtotal
            _SubTotal = _AdditionalOptions + _BasePrice;
            // Generates Sales tax by * Subtotal and Tax
            _SalesTax = _SubTotal * _Tax;
            // Generates the amount due variable
            _AmountDue = (_SubTotal + _SalesTax) - _TradeInAllowance;


            // Sends all the information to the text boxes
            SubTotalTextBox.Text = _SubTotal.ToString();
            SalesTaxTextBox.Text = _SalesTax.ToString();
            TotalTextBox.Text = (_SubTotal + _SalesTax).ToString();
            AmountDueTextBox.Text = _AmountDue.ToString();







        }
        /// <summary>
        /// Clears the form and resets trade in allowance to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.Clear();
            AdditionalOptionsTextBox.Clear();
            SubTotalTextBox.Clear();
            SalesTaxTextBox.Clear();
            TotalTextBox.Clear();
            TradeInAllowanceTextBox.Text = "0";
            AmountDueTextBox.Clear();
        }
        /// <summary>
        /// Closes the aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Closes the application with the Menu Strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }

}
