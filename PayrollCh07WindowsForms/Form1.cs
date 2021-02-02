using System;
using System.Windows.Forms;

/*
 * 
 *      A simple C# Payroll Windows Forms application.
 *      
 *      1.	Local vs. global variables
 *      2.	Convert.ToDecimal.  TryParse.  (Data Validation).
 *      
 *      This program will now include try/catch blocks for
 *      the following data:
 *      
 *      1.  firstName.
 *      2.  lastName.
 *      3.  hoursWorked.
 *      4.  hourlyRate.
 * 
 */

namespace PayrollCh03WindowsForms
{
    public partial class FormPayrollChapter07 : Form
    {
        public FormPayrollChapter07()
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
        decimal minGrossPay     = 10000000.0m;  //  Smallest calculated gross pay
        decimal maxGrossPay     = -1000000m;    //  Largest  calculated gross pay
        decimal avgGrossPay     = 0.0m;         //  Average  calculated gross pay

        //  This method is run when the Calculate button
        //  is clicked.  It grabs the values from the
        //  hours worked and hourly rate textBoxes,
        //  converts those values to their numeric 
        //  equivalents, multiplies them and places the
        //  answer in the formatted gross pay textBox.
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            //  Declare and initialize program variables
            decimal hoursWorked = 0.0m;             //  Hours worked
            decimal hourlyRate = 0.0m;              //  Hourly rate
            decimal grossPay = 0.0m;                //  Gross pay hoursWorked * hourlyRate

            //  Here calculate puts each of the methods we are
            //  attempting to call in a try/catch block.  If
            //  any method fails, it should throw an associated
            //  exception message.
            try
            {
                validateFirstName();
                validateLastName();
                validateHoursWorked();
                validateHourlyRate();
                hoursWorked = Convert.ToDecimal(textBoxHoursWorked.Text);
                hourlyRate  = Convert.ToDecimal(textBoxHourlyRate.Text);
                ++totEmployees;
                grossPay    = calculateGrossPay(hoursWorked, hourlyRate);
                calculateMinimumGross(grossPay);
                calculateMaximumGross(grossPay);
                calculateAverageGross();
                textBoxGrossPay.Text = grossPay.ToString("c");
                textBoxMinGrossPay.Text = minGrossPay.ToString("c");
                textBoxMaxGrossPay.Text = maxGrossPay.ToString("c");
                textBoxAvgGrossPay.Text = avgGrossPay.ToString("c");
                updateValidEmployeeTotals(hoursWorked, hourlyRate, grossPay);
                buildValidEmployeeMessageBox(hoursWorked, hourlyRate, grossPay);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occurred\n" + e.Message,
                               "EXCEPTION!!!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
        }

        //  This routine validates that there is a value
        //  in the last name field.  It throws an exception
        //  if the textBox for the first name field is blank.
        private void validateFirstName()
        {
            if (textBoxFirstName.Text.Trim() == "")
            {
                textBoxFirstName.Focus();
                throw new ArgumentException(
                    string.Format("No Value Was Entered For First Name"));
            }
        }

        //  This routine validates that there is a value
        //  in the last name field.  It throws an exception
        //  if the textBox for the last name field is blank.
        private void validateLastName()
        {
            if (textBoxLastName.Text.Trim() == "")
            {
                textBoxLastName.Focus();
                throw new ArgumentException(
                    string.Format("No Value Was Entered For Last Name"));
            }
        }

        //  This routine validates that there is a value
        //  in the hours worked field.  It throws an
        //  exception if the field is empty.
        //
        //  If the field is not empty, it validates that
        //  the value in the field is within range.  If
        //  it is not, a different exception is thrown.
        private void validateHoursWorked()
        {
            bool   flag      = false;
            string hoursStr  = textBoxHoursWorked.Text.ToString();
            decimal hoursDec = 0.0m;

            flag = validateIsNumeric(hoursStr);

            if (!flag)
            {
                textBoxHoursWorked.Text = "";
                textBoxHoursWorked.Focus();
                throw new ArgumentException(
                    string.Format("Non-Numeric Value Was Entered For Hours Worked"));
            }
            else
            {
                hoursDec = Convert.ToDecimal(textBoxHoursWorked.Text);

                if ((hoursDec < MINHOURS) || (hoursDec > MAXHOURS))
                {
                    throw new ArgumentOutOfRangeException(
                    string.Format("Out-Of-Range Value (< 0 or > 84) Was Entered For Hours Worked"));
                }
            }
        }

        //  This routine validates that there is a value
        //  in the hourly rate field.  It throws an
        //  exception if the field is empty.
        //
        //  If the field is not empty, it validates that
        //  the value in the field is within range.  If
        //  it is not, a different exception is thrown.
        private void validateHourlyRate()
        {
            bool flag = false;
            string rateStr = textBoxHourlyRate.Text.ToString();
            decimal rateDec = 0.0m;

            flag = validateIsNumeric(rateStr);

            if (!flag)
            {
                textBoxHourlyRate.Text = "";
                textBoxHourlyRate.Focus();
                throw new ArgumentException(
                    string.Format("Non-Numeric Value Was Entered For Hourly Rate"));
            }
            else
            {
                rateDec = Convert.ToDecimal(textBoxHourlyRate.Text);

                if ((rateDec < MINRATE) || (rateDec > MAXRATE))
                {
                    throw new ArgumentOutOfRangeException(
                    string.Format("Out-Of-Range Value (< 0 or > 99.99) Was Entered For Hourly Rate"));
                }
            }
        }

        //  This method returns true if the input was
        //  numeric.  Otherwise, it returns false.
        private bool validateIsNumeric(string input)
        {
            decimal test = 0;

            return decimal.TryParse(input, out test);
        }

 
        //  This method updates the global total employees and
        //  total gross pay accumulators.
        private void updateValidEmployeeTotals(decimal hoursWorked,
                                    decimal hourlyRate, decimal grossPay)
        {
            textBoxTotalNumberOfEmployees.Text = totEmployees.ToString();
            grossPay = calculateGrossPay(hoursWorked, hourlyRate);

            textBoxTotalGrossPay.Text = totGrossPay.ToString("c");

            //  Put gross pay into its formatted textBox
            textBoxGrossPay.Text = grossPay.ToString("c");
        }

        //  Put all input and calculated/output information
        //  into a single MessageBox and then show said
        //  MessageBox.
        private void buildValidEmployeeMessageBox(decimal hoursWorked,
                            decimal hourlyRate, decimal grossPay)
        {
            string empInfo = "";       //  All employee info concatenated

            //  Build string empInfo which will print out all of
            //  the individual's employee information in a MessageBox.
            empInfo += "Employee Name:  " + textBoxFirstName.Text.ToString() + " " +
                                            textBoxLastName.Text.ToString();
            empInfo += "\nEmployee Hours: " + hoursWorked.ToString("f2");
            empInfo += "\nEmployee Rate:  " + hourlyRate.ToString("c");
            empInfo += "\nEmp Gross Pay:  " + grossPay.ToString("c");
            empInfo += "\nMin Gross Pay:  " + minGrossPay.ToString("c");
            empInfo += "\nMax Gross Pay:  " + maxGrossPay.ToString("c");
            empInfo += "\nAvg Gross Pay:  " + avgGrossPay.ToString("c");

            //MessageBox.Show(empInfo, "EMPLOYEE STATISTICS",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);
        }


        //  This method actually calculates the employee's
        //  gross pay.  It does take into account whether
        //  or not the employee has worked overtime.
        private decimal calculateGrossPay(decimal hw, decimal hr)
        {
            decimal gross = 0.0m;

            if (hw <= MAXNONOT)
            {                       //  Employee worked <= 40 hours.  No OT coming.
                gross = hw * hr; 
            }
            else
            {
                                    //  Employee worked > 40 hours.  Has OT coming.
                /*
                 * 
                 * Employee worked 50 hours
                 * 40 hours * hourly rate +
                 * 10 hours * hourly rate * ot rate
                 * gross = (40 * hr) + ((hw - 40) * hr * ot)
                 * 
                 */
                gross = ((MAXNONOT * hr) + ((hw - MAXNONOT) * hr * OTRATE));
            }

            //  Add current gross pay to the total gross pay accumulator
            totGrossPay += gross;

            return gross;
        }

        //  This method is called when the Clear button
        //  is clicked.  It clears out all textBoxes and
        //  sets the cursor (focus) to the 1st textBox.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearOutIndividualEmployeeInfo();
        }

        //  This method is called when the Eixt button
        //  is clicked.  It allows the user to end the
        //  program if s/he so desires.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitProgramNowOrNot();
        }

        private void exitProgramNowOrNot()
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

        private void clearOutIndividualEmployeeInfo()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxHoursWorked.Text = "";
            textBoxHourlyRate.Text = "";
            textBoxGrossPay.Text = "";
            textBoxFirstName.Focus();
        }

        private void clearOutFinalTotals()
        {
            textBoxTotalGrossPay.Text           = "";
            textBoxTotalNumberOfEmployees.Text  = "";
            totGrossPay                         = 0.0m;
            totEmployees = 0;
        }

        //  This method is called if there are
        //  problems with the inputted number.
        private void printMessageBox(String text, String title)
        {
            MessageBox.Show(text, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void calculateMenuItem_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            clearOutIndividualEmployeeInfo();
        }

        private void clearAllMenuItem_Click(object sender, EventArgs e)
        {
            clearOutIndividualEmployeeInfo();
            clearOutFinalTotals();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramNowOrNot();
        }

        private void calculateMinimumGross(decimal gp)
        {
            if (gp < minGrossPay)
            {
                minGrossPay = gp;
            }
        }

        private void calculateMaximumGross(decimal gp)
        {
            if (gp > maxGrossPay)
            {
                maxGrossPay = gp;
            }
        }

        private void calculateAverageGross()
        {
            MessageBox.Show("Show Stats totGrossPay = " + totGrossPay.ToString("c") +
                            "totEmployees = " + totEmployees.ToString(),
                            "STATS",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            avgGrossPay = totGrossPay / totEmployees;
        }
    }
}
