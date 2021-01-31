using System;
using System.Windows.Forms;

/*
 * 
 *      A simple C# Payroll Windows Forms application.
 *      
 *      1.	Local vs. global variables
 *      2.	Convert.ToDecimal.  TryParse.  (Data Validation).
 * 
 */

namespace PayrollCh03WindowsForms
{
    public partial class FormPayrollChapter06 : Form
    {
        public FormPayrollChapter06()
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
            calculate();
        }

        private void calculate()
        {
            //  Declare and initialize program variables
            decimal hoursWorked = 0.0m;     //  Hours worked
            decimal hourlyRate  = 0.0m;     //  Hourly rate
            decimal grossPay    = 0.0m;     //  Gross pay hoursWorked * hourlyRate
            bool keepGoing      = true;     //  Program continue flag
            string defName      = "Unknown";//  Default name

            if (keepGoing)      //  Should always be true (see line above).
            {
                keepGoing = validateFirstName();
            }
            else                //  Should never be hit.
            {
                return;
            }

            if (!keepGoing)     //  Means validateFirstName() returned false
            {
                //  There was nothing entered in the textBoxFirstName
                //  field.  So, put in the default name of UFN, which
                //  stands for Unknown First Name.
                textBoxFirstName.Text = defName;
                keepGoing = true;
            }
 
            keepGoing = validateLastName();

            if (!keepGoing)     //  Means validateLastName() returned false
            {
                //  There was nothing entered in the textBoxLastName
                //  field.  So, put in the default name of ULN, which
                //  stands for Unknown Last Name.
                textBoxLastName.Text = defName;
                keepGoing = true;
            }

            //  Verify the whatever was entered into the
            //  hoursWorked textBox was indded numeric.
            keepGoing = validateIsNumeric(textBoxHoursWorked.Text);

            if (keepGoing)     //  Means validateIsNumeric() returned true
            {
                //  We know that the hoursWorked textBox has
                //  a value in it that indeed is numeric.
                //  Convert hoursWorked to a decimal
                hoursWorked = Convert.ToDecimal(textBoxHoursWorked.Text);

                //  Validate that entry within range (>= 0 and <= 84).
                keepGoing = validateHoursWorkedRange(hoursWorked);
            }
            else               //  Means validateIsNumeric() returned false
            {
                //  We know that the hoursWorked textBox holds
                //  either no value at all or a non-numeric value.
                //  So, print out an associated MessageBox and
                //  return (quit the routine).
                printMessageBox("Hours Worked Either Empty Or Non-Numeric." +
                                "\nPlease reenter a valid value now",
                                "NON-NUMERIC INPUT!");
                textBoxHoursWorked.Text = "";
                textBoxHoursWorked.Focus();
                return;
            }

            if (keepGoing)     //  Means validateHoursWorkedRange() returned true
            {
                //  We know we have an hoursWorked value inputted
                //  that was between 0 and 84 (MINHOURS and MAXHOURS).

                //  Now attempt to validate contents of hourlyRate textBox
                keepGoing = validateIsNumeric(textBoxHourlyRate.Text);
            }
            else               //  Means validateHoursWorkedRange() returned false
            {
                //  We know that the hoursWorked textBox holds
                //  a value that is out of range, either < 0 or.
                //  > 84 (MINHOURS and MAXHOURS). So print out an
                //  associated MessageBox and return (quit the routine).
                printMessageBox("Hours Worked Inputted Was Out Of Range." +
                                "\nPlease reenter a valid value now",
                                "OUT-OF-RANGE INPUT!");
                textBoxHoursWorked.Text = "";
                textBoxHoursWorked.Focus();
                return;
            }

            if (keepGoing)     //  Means validateIsNumeric() returned true
            {
                //  We know that the hourlyRate textBox has
                //  a value in it that indeed is numeric.
                //  Convert hourlyRate to a decimal
                hourlyRate = Convert.ToDecimal(textBoxHourlyRate.Text);

                //  Validate that entry within range (>= 0 and <= 99.99).
                keepGoing = validateHourlyRateRange(hourlyRate);
            }
            else               //  Means validateIsNumeric() returned false
            {
                //  We know that the hourlyRate textBox holds
                //  a value that is either empty or non-numeric.
                //  So print out an associated MessageBox and 
                //  return (quit the routine).
                printMessageBox("Hourly Rate Inputted Was Empty Or Non-Numeric." +
                                "\nPlease reenter a valid value now",
                                "NON-NUMERIC INPUT!");
                textBoxHourlyRate.Text = "";
                textBoxHourlyRate.Focus();
                return;
            }

            if (keepGoing)     //  Means validateHourlyRateRange() returned true
            {
                //  We know we have an hoursWorked value inputted
                //  that was between 0 and 84 (MINHOURS and MAXHOURS).
                //  We also know that we have an hourlyRate value
                //  inputted that was between 0 and 99.99 (MINRATE
                //  and MAXRATE).  We have a valid employee.
                //

                updateValidEmployeeTotals(hoursWorked, hourlyRate, out grossPay);

                buildValidEmployeeMessageBox(hoursWorked, hourlyRate, grossPay);
            }
            else               //  Means validateHourlyRateRange() returned false
            {
                //  hourlyRate inputted was out of range, i.e. either
                //  it was < 0 or > 99.99.  So, print out an associated
                //  error message, clear out associated fields and return.
                printMessageBox("Hourly Rate Inputted Was Out-Of-Range." +
                                "\nPlease reenter a valid value now",
                                "OUT-OF-RANGE INPUT!");
                textBoxHourlyRate.Text = "";
                textBoxHourlyRate.Focus();
                return;
            }
        }

        //  This routine validates that there is a value
        //  in the first name field.  It returns true
        //  if there is a value and false if there is not.
        private bool validateFirstName()
        {
            if (textBoxFirstName.Text.Trim() == "")
            {
                return false;
            }

            return true;        //  Valid first name
        }

        //  This routine validates that there is a value
        //  in the last name field.  It returns true
        //  if there is a value and false if there is not.
        private bool validateLastName()
        {
            if (textBoxLastName.Text.Trim() == "")
            {
                return false;
            }

            return true;        //  Valid last name
        }

        //  This method returns true if the input was
        //  numeric.  Otherwise, it returns false.
        private bool validateIsNumeric(string input)
        {
            decimal test = 0;

            return decimal.TryParse(input, out test);
        }

        //  This routine attempt to validate whether the
        //  hoursWorked was valid or not, i.e. is between
        //  0 and 84 (MINHOURS and MAXHOURS).
        private bool validateHoursWorkedRange(decimal hw)
        {
            if ((hw < MINHOURS) || (hw > MAXHOURS))
            {
                return false;
            }

            return true;
        }

        //  This routine attempt to validate whether the
        //  hoursRate was valid or not, i.e. is between
        //  0 and 99.99 (MINRATE and MAXRATE).
        private bool validateHourlyRateRange(decimal hr)
        {
            if ((hr < MINRATE) || (hr > MAXRATE))
            {
                return false;
            }

            return true;
        }

        private void updateValidEmployeeTotals(decimal hoursWorked,
                                    decimal hourlyRate, out decimal grossPay)
        {
            //  So, increment total employees counter
            ++totEmployees;
            textBoxTotalNumberOfEmployees.Text = totEmployees.ToString();
            grossPay = calculateGrossPay(hoursWorked, hourlyRate);
            //  Add current gross pay to the total gross pay accumulator
            totGrossPay += grossPay;

            textBoxTotalGrossPay.Text = totGrossPay.ToString("c");

            //  Put gross pay into its formatted textBox
            textBoxGrossPay.Text = grossPay.ToString("c");
        }

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

            MessageBox.Show(empInfo, "EMPLOYEE STATISTICS",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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
    }
}
