using System;
using System.Windows.Forms;

/*
 * 
 *      A simple C# Payroll Windows Forms application.
 * 
 */
 
namespace PayrollCh03WindowsForms
{
    public partial class FormPayrollChapter04 : Form
    {
        public FormPayrollChapter04()
        {
            InitializeComponent();
        }

        //  Declare and initialize global constants
        const int     MINHOURS  =  0;           //  Minimum # hours worked in week
        const int     MAXHOURS  = 84;           //  Maximum # hours worked in week
        const decimal MINRATE   =  0.00m;       //  Minimum hourly rate
        const decimal MAXRATE   = 99.99m;       //  Maximum hourly rate
        const decimal MAXNONOT  = 40.00m;       //  Maximum non-overtime hours worked
        const decimal OTRATE    =  1.5m;        //  Overtime rate         

        //  Declare and initialize global variables
        decimal totGrossPay     = 0.0m;         //  Total gross pay all employees
        int totEmployees        = 0;            //  Total number of employees

        //  This method is run when the Calculate button
        //  is clicked.  It grabs the values from the
        //  hours worked and hourly rate textBoxes,
        //  converts those values to their numeric 
        //  equivalents, multiplies them and places the
        //  answer in the formatted gross pay textBox.
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //  Declare and initialize program variables
            decimal hoursWorked = 0.0m;     //  Hours worked
            decimal hourlyRate  = 0.0m;     //  Hourly rate
            decimal  grossPay   = 0.0m;     //  Gross pay hoursWorked * hourlyRate
            string   empInfo    = "";       //  All employee info concatenated

            //  Convert hoursWorked to a decimal
            hoursWorked = Convert.ToDecimal(textBoxHoursWorked.Text);

            //  Convert hourlyRate to a decimal
            hourlyRate = Convert.ToDecimal(textBoxHourlyRate.Text);

            //  Increment the total number of employees accumulator
            ++totEmployees;
            textBoxTotalNumberOfEmployees.Text = totEmployees.ToString();

            //  Calculate grossPay as hoursWorked * hourlyRate
            grossPay = hoursWorked * hourlyRate;

            //  Add current gross pay to the total gross pay accumulator
            totGrossPay += grossPay;

            textBoxTotalGrossPay.Text = totGrossPay.ToString("c");

            //  Put gross pay into its formatted textBox
            textBoxGrossPay.Text = grossPay.ToString("c");

            //  Build string empInfo which will print out all of
            //  the individual's employee information in a MessageBox.
            empInfo += "Employee Name:  " + textBoxFirstName.Text.ToString() + " " +
                                            textBoxLastName.Text.ToString();
            empInfo += "\nEmployee Hours: " + hoursWorked.ToString("f2");
            empInfo += "\nEmployee Rate:  " + hourlyRate.ToString("c");
            empInfo += "\nEmp Gross Pay:  " + grossPay.ToString("c");

            MessageBox.Show(empInfo, "EMPLOYEE STATISTICS",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //  This method is called when the Clear button
        //  is clicked.  It clears out all textBoxes and
        //  sets the cursor (focus) to the 1st textBox.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearOutIndividualEmployeeInfo();
        }

        private void clearOutIndividualEmployeeInfo()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxHoursWorked.Text = "";
            textBoxHourlyRate.Text = "";
            textBoxGrossPay.Text = "";
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

        //  This method is called when the Clear All
        //  button is clicked.  It will call the
        //  clear clearOutIndividualEmployeeInfo()
        //  method to clear out the individual 
        //  employee info.  It will then call the
        //  clearOutFinalTotals() to clear out the
        //  final total textBoxes and accumulators.
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            clearOutIndividualEmployeeInfo();
            clearOutFinalTotals();
        }

        private void clearOutFinalTotals()
        {
            textBoxTotalGrossPay.Text           = "";
            textBoxTotalNumberOfEmployees.Text  = "";
            totGrossPay                         = 0.0m;
            totEmployees = 0;
        }
    }
}
