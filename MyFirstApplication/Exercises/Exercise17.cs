

namespace MyFirstApplication;
/*
 Exercise 17 Exception Handling
 */

internal class Exercise17
 {   /*
     Objective 1: Write a method that has two int parameters and no return type. You will use
    a try/catch for this method. Create a division problems in the the try block. 
    The catch block will utilize the DivideByZeroException. Provide a Console.WriteLine 
    message for both the try block and the catch block. The one in the try block should 
    display the answer to the division problem. The one in the catch block should have a 
    message using interpolation along with a variable.Message syntax. Test the method 
    with diffrent numbers, including 0 so you can ensure the catch executes. 
     */

    public void DivisionExceptionCheck(int x, int y)
    {
        try
        {
            int value = x / y;
            Console.WriteLine($"{x} divided by {y} equals {value}");
        }
        catch (DivideByZeroException dz)
        {
            Console.WriteLine($"Invalad Entry: { dz.Message}");
        }

        /*
         Objective 2: Write a method that has a horse parameter and no return type. Using an
        if statement, determine if your horse is null. if it is nu.. use the throw keyword and 
        a message to indate it is null. If the horse is not null, use a Console.WriteLine statement
        to print out one of your horse properties. 
         */


    }


    public void HorseThrow(Horse horse)
    {
        if (horse == null)
        {
            throw new NullReferenceException("Horse Object is Null");
        }
        else
        {
            Console.WriteLine(horse.Main);
        }
    }

}// end class
