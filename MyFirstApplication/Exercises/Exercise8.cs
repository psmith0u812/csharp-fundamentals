

namespace MyFirstApplication;
/*
 Objective 1: Write a constant at the class level. The constant should be Foot with a value of 12
to represent the number of inches in a foot. Write a method that takes 1 int parameter and 
a void return type. This method will convert feet to inches. The formula that you would use will be 
the parameter * Foot. Your parameter will represent the number of feet to convert to inches. Using
Console.WriteLine statment, print the restuls. Test your method using the numer 3 to see if you get 36.
 */
internal class Exercise8
{
    public const int Foot = 12;

    public void CalculateInches(int Feet)
    {
        Console.WriteLine($"There are {Foot*Feet} inches, in {Feet}ft");    
    } // End Objective1


    /*
     Write a static method that takes 2 int parameters and a void return type. 
    This method will be used to calculate the length and width of a rectangle/square.
    This formula is length x width. The first parameter should represent the length and the second
    parameter should be the width. Using a Console.WriteLine statment, print the results. 
    Test your method and add what you used to test as a comment, either before the method or after.
     */

    public static int AreaOf(int length, int width)
    {
        return length * width;
    }
    /*
      // Static Objective2 Program.cs Call
      Console.WriteLine(MyFirstApplication.Exercise8.AreaOf(12, 14));
     */

} // End Class
