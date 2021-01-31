using System;
using static System.Console;

/*
 * 
 *      A more complex C# Console Payroll application.
 * 
 */

namespace PayrollCh02Console
{
    class Program
    {
        //  Declare and initialize global constants
        const decimal MINHOURS =  0.0m;     //  Minimum # hours worked in week
        const decimal MAXHOURS = 84.0m;     //  Maximum # hours worked in week
        const decimal DEFHOURS = 40.0m;     //  Default # hours worked in week
        const decimal MINRATE  =  0.00m;    //  Minimum hourly rate
        const decimal MAXRATE  = 99.99m;    //  Maximum hourly rate
        const decimal DEFRATE  = 25.0m;     //  Default hourly rate
        const decimal MAXNONOT = 40.00m;    //  Maximum non-overtime hours worked
        const decimal OTRATE   =  1.5m;     //  Overtime rate         

        //  Declare and initialize global variables
        static decimal totGrossPay  = 0.0m; //  Total gross pay all employees
        static int     totEmployees = 0;    //  Total number of employees

        static void Main(string[] args)
        {
            calculate();
        }

        static void calculate()
        {
            //  Declare and initialize local program variables
            string firstName = "";       //  First Name
            string lastName = "";       //  First Name
            decimal hoursWorked = 0.0m;     //  Hours worked
            decimal hourlyRate = 0.0m;     //  Hourly rate
            decimal grossPay = 0.0m;     //  Gross pay hoursWorked * hourlyRate

            while (1 == 1)
            {
                Write("\n\n\t\tHit <enter> to continue: ");
                ReadLine();
                Console.Clear();
                firstName = validateFirstName();
                lastName = validateLastName();
                hoursWorked = validateHoursWorked();
                hourlyRate = validateHourlyRate();
                grossPay = calculateGrossPay(hoursWorked, hourlyRate);
                updateValidEmployeeTotals(grossPay);
                displayAllInputsAndOutputs(firstName, lastName, hoursWorked, hourlyRate, grossPay);
            }
        }

            //  This routine validates that there is a value
            //  in the first name field.  It returns an
            //  actual inputted first name.
            static string validateFirstName()
            {
                string fn = "";

                Write("\n\n\t\tPlease input your first name: ");
                fn = ReadLine();

                while (fn.Trim() == "")
                {
                    Write("\t\tPlease input your first name: ");
                    fn = ReadLine();
                }

                return fn;
            }

            //  This routine validates that there is a value
            //  in the last name field.  It returns an
            //  actual inputted last name.
            static string validateLastName()
            {
                string ln = "";

                Write("\t\tPlease input your last name: ");
                ln = ReadLine();

                while (ln.Trim() == "")
                {
                    Write("\t\tPlease input your last name: ");
                    ln = ReadLine();
                }

                return ln;
            }

            //  This routine will validate whether the field
            //  hoursWorked was valid or not, i.e. is between
            //  0 and 84 (MINHOURS and MAXHOURS).  If it is
            //  NOT within range, set hoursWorked to a default
            //  value of 40.0.
            static decimal validateHoursWorked()
            {
                string hwStr = "";             //  Value inputted
                decimal hwDec = 0.0m;           //  Hours Worked
                bool valid = false;          //  Boolean flag

                Write("\t\tEnter an hours worked between " + MINHOURS +
                      " and " + MAXHOURS + " hours: ");
                hwStr = ReadLine();
                valid = validateIsNumeric(hwStr);

                if (valid)
                {
                    hwDec = Convert.ToDecimal(hwStr);

                    valid = validateHoursWorkedRange(hwDec);
                }

                if (valid)
                {
                    return hwDec;
                }
                else
                {
                    return DEFHOURS;
                }
            }

            //  This routine attempt to validate whether the
            //  hoursWorked was valid or not, i.e. is between
            //  0 and 84 (MINHOURS and MAXHOURS).
            static bool validateHoursWorkedRange(decimal hw)
            {
                if ((hw < MINHOURS) || (hw > MAXHOURS))
                {
                    return false;
                }

                return true;
            }

            //  This routine will validate whether the field
            //  hourlyRate was valid or not, i.e. is between
            //  0 and 99.99 (MINRATE and MAXRATE).  If it is
            //  NOT within range, set hourlyRate to a default
            //  value of 25.0.
            static decimal validateHourlyRate()
            {
                string hrStr = "";              //  Value inputted
                decimal hrDec = 0.0m;          //  Hours Worked
                bool valid = false;             //  Boolean flag

                Write("\t\tEnter an hourly rate between " + MINRATE +
                      " and " + MAXRATE + " per hour: ");
                hrStr = ReadLine();
                valid = validateIsNumeric(hrStr);

                if (valid)
                {
                    hrDec = Convert.ToDecimal(hrStr);

                    valid = validateHourlyRateRange(hrDec);
                }

                if (valid)
                {
                    return hrDec;
                }
                else
                {
                    return DEFRATE;
                }
            }

            //  This routine attempt to validate whether the
            //  hoursRate was valid or not, i.e. is between
            //  0 and 99.99 (MINRATE and MAXRATE).
            static bool validateHourlyRateRange(decimal hr)
            {
                if ((hr < MINRATE) || (hr > MAXRATE))
                {
                    return false;
                }

                return true;
            }

            //  This method returns true if the input was
            //  numeric.  Otherwise, it returns false.
            static bool validateIsNumeric(string input)
            {
                decimal test = 0;

                return decimal.TryParse(input, out test);
            }

            //  This method actually calculates the employee's
            //  gross pay.  It does take into account whether
            //  or not the employee has worked overtime.
            static decimal calculateGrossPay(decimal hw, decimal hr)
            {
                decimal gross = 0.0m;

                if (hw <= MAXNONOT)
                {                       //  Employee worked <= 40 hours.  No OT coming.
                    gross = hw * hr;
                }
                else
            {                           //  Employee worked > 40 hours.  Has OT coming.
                gross = ((MAXNONOT * hr) + ((hw - MAXNONOT) * hr * OTRATE));
                }

                return gross;
            }

            //  This routine attempt to validate whether the
            static void updateValidEmployeeTotals(decimal grossPay)
            {
                //  Increment total employees counter by 1
                //  Incrementing total gross pay by the current gross pay
                ++totEmployees;
                totGrossPay += grossPay;
            }

            static void displayAllInputsAndOutputs(string fn, string ln,
                                                   decimal hw, decimal hr,
                                                   decimal gp)
            {
                WriteLine("\n\n\t\tThe Inputted First Name Was: "   + fn + "\n" +
                              "\t\tThe Inputted Last Name  Was: "   + ln + "\n" +
                              "\t\tThe Inputted Hours Worked Was: " + hw.ToString("f2") + "\n" +
                              "\t\tThe Inputted Hourly Rate Was: "  + hr.ToString("c") + "\n" +
                              "\t\tThe Calculated Gross Pay Was: "  + gp.ToString("c") + "\n" +
                              "\t\tTotal Number Of Employees: "     + totEmployees.ToString() + "\n" +
                              "\t\tTotal Company Payroll Now Is: "  + totGrossPay.ToString("c"));
            }
    }
}
