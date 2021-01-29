using System;
using static System.Console;

/*
 * 
 *      A simple C# Console Payroll application.
 * 
 */

namespace PayrollCh02Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Declare and initialize program variables
            string firstName    = "";       //  Employee first name
            string lastName     = "";       //  Employee last  name
            double hoursWorked  = 0.0;      //  Employee hours worked
            double hourlyRate   = 0.0;      //  Employee hourly rate
            double grossPay     = 0.0;      //  hoursWorked * hourlyRate

            //  Read in value for first name
            Write("\n\n\t\tEnter Employee First Name: ");
            firstName = ReadLine();

            //  Read in value for last name
            Write("\n\t\tEnter Employee  Last Name: ");
            lastName = ReadLine();

            //  Read in value for hours worked
            Write("\n\t\tEnter Employee Hours Worked: ");
            hoursWorked = Convert.ToDouble(ReadLine());

            //  Read in value for hourly rate
            Write("\n\t\tEnter Employee Hourly Rate: ");
            hourlyRate = Convert.ToDouble(ReadLine());

            //  Calculate gross pay
            grossPay = hoursWorked * hourlyRate;

            //  Output all input values and calculated gross pay
            WriteLine("\n\n\t\tEmployee First  Name:  " + firstName);
            WriteLine("\n\t\tEmployee Last   Name: " + lastName);
            WriteLine("\n\t\tEmployee Hours  Work: " + hoursWorked.ToString("f2"));
            WriteLine("\n\t\tEmployee Hourly Rate: " + hourlyRate.ToString("c"));
            WriteLine("\n\t\tEmployee Gross   Pay: " + grossPay.ToString("c"));
        }
    }
}
