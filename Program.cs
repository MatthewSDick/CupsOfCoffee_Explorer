using System;

namespace CupsOfCoffee_Explorer
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
         - Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day
         - Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
         - Create a variable (use your best judgment for type) call today and set it equal to today's date.
         - using your variables, numberOfCupsOfCoffee, fullNameand today, Console.WriteLine out all three on one line.
        
        
         - Ask the user for their name and store it in a variable called 'user'.
         - Print out a greeting to the user, using their name

         - Ask the user to input two numbers
         - Get the numbers as Strings using Console.ReadLine
         - Convert a String to a double using double.parse. Save the first double value in an operand1 variable and the second double value in an operand2 variable
         - Add the operands and save in a sum variable
         - Subtract the operands and save in a difference variable
         - Divide the operands and save in a quotient variable
         - Multiply the operands and save in a product variable
         - Find the remainder when one operand is divided by the other and save in a remainder variable. See this page if you need to learn more about the modulo operator.
         - print all the results to the screen in a meaningful way.

      */

      int numberOfCupsOfCoffee = 1;
      string fullName = "Matthew Dick";
      var today = DateTime.Today;

      Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      Console.WriteLine("Hello " + user + " nice to meet you.");

      Console.WriteLine("Hey " + user + " give me a number.");
      var numOne = Console.ReadLine();
      //Console.WriteLine(numOne);

      Console.WriteLine("Now give me another number.");
      var numTwo = Console.ReadLine();
      //Console.WriteLine(numTwo);

      var operand1 = double.Parse(numOne);
      //Console.WriteLine(operand1);

      var operand2 = double.Parse(numTwo);
      //Console.WriteLine(operand2);

      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;
      var remainder = (15 / 6);


      Console.WriteLine(operand1 + " + " + operand2 + " = " + sum);
      Console.WriteLine(operand1 + " - " + operand2 + " = " + difference);
      Console.WriteLine(operand1 + " / " + operand2 + " = " + quotient);
      Console.WriteLine(operand1 + " * " + operand2 + " = " + product);
      Console.WriteLine("The remainder of 15/6 is " + remainder);


















    }
  }
}
