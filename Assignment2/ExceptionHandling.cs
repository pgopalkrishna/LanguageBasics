using System;
using System.Collections.Generic;
using System.Text;
/*
 3. Write a c# program to handle the exceptions with appropriate exception class
Any number devide by zero
   int[] arr = { 1 };
     arr[1] = 100;
 Convert any string format input to number
 
4. Write a program to handle multiple catch block
5. Write a program to execute finally block

 */
namespace LanguageBasics.Assignment2
{
    class ExceptionHandling
    {

        //Uncomment Main() method to execute
        static void Main(string[] args)
        {
            division(100);
            try
            {
                int[] arr = { 1 };
                arr[1] = 100;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            AnyStringToNumber("111");
            AnyStringToNumber("                 ");
            AnyStringToNumber(null);
            AnyStringToNumber("abc");
            AnyStringToNumber("999999999999999999999999999999999999999");
        }
        public static void division(int n) {
            try
            {
                var result = n / 0;
                Console.WriteLine("division:" + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide {0} by zero.", n);
            }
        }
        public static void AnyStringToNumber(string str) {
            try
            {
                Console.WriteLine("Converted string :'{0}' to number:{1}", str, Convert.ToInt32(str));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("string is not in correct format, " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("number not valid, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("hi from finnaly block");
            }
        }
    }
}
