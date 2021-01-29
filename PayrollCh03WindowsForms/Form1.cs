using System;
using System.Windows.Forms;

/*
 * 
 *      A simple C# Payroll Windows Forms application.
 * 
 */
 
namespace PayrollCh03WindowsForms
{
    public partial class FormPayrollChapter03 : Form
    {
        public FormPayrollChapter03()
        {
            InitializeComponent();
        }

        //  This method is run when the Calculate button
        //  is clicked.  It grabs the values from the
        //  hours worked and hourly rate textBoxes,
        //  converts those values to their numeric 
        //  equivalents, multiplies them and places the
        //  answer in the formatted gross pay textBox.
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //  Declare and initialize program variables
            double hoursWorked = 0.0;
            double hourlyRate = 0.0;
            double grossPay = 0.0;

            //  Convert hoursWorked to a double
            hoursWorked = Convert.ToDouble(textBoxHoursWorked.Text);

            //  Convert hourlyRate to a double
            hourlyRate = Convert.ToDouble(textBoxHourlyRate.Text);

            //  Calculate grossPay as hoursWorked * hourlyRate
            grossPay = hoursWorked * hourlyRate;

            //  Put gross pay into its formatted textBox
            textBoxGrossPay.Text = grossPay.ToString("c");
        }

        //  This method is called when the Clear button
        //  is clicked.  It clears out all textBoxes and
        //  sets the cursor (focus) to the 1st textBox.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text   = "";
            textBoxLastName.Text    = "";
            textBoxHoursWorked.Text = "";
            textBoxHourlyRate.Text  = "";
            textBoxGrossPay.Text    = "";
            textBoxFirstName.Focus();
        }

        //  This method is called when the Eixt button
        //  is clicked.  It allows the user to end the
        //  program if s/he so desires.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
