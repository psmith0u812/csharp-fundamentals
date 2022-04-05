
namespace MyFirstApplication;

internal class Exercise5
{

    /*
     Objective 1: Write a method that takes 2 int parameters, and an int return type. 
    Using the formula for Ohm's Law, determine the voltage. The first method parameter
    will represent current and the second  will represent resistance. Using the 
    Func<int, int, int> and Lambda expression, determine the voltage calculation and 
    return the value.  (Voltage = Current x Resistance)
     */
    public int Ex5Objective1(int c, int r)
   
    {
     
        Func<int, int, int> voltage = (c,r) => (c * r);
        Console.WriteLine($"Calculation is {voltage(c,r)}-volts");
        return voltage(c,r);
        
    }  // End Objective1



    /*
     Objective 2: Write a method that will take 1 char parameter and a string return type. 
    Using a switch expression and the provided table return the description. if the value
    does not match the grade, return the default message, "Not a valid grade".
     */

    public string Ex5Objective2(char grade)

    {

        string result = grade switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Not a valid grade"
        };

        return result;

        /*  Program.cs call method
         * string result = myExercise5.Ex5Objective2('G');
         * Console.WriteLine($" Your grade is {result}!");
         */

    }// End Objective2




    /*
     Objective 3: Write a method that takes 1 argument and a void return type. 
    Using a relational pattern and switch expression determine a size of 
    popcorn based on the table below and using a Console.WriteLine, print the popcorn size. 
     */

    public void Ex5Objective3(int pop)
    {
        string size = pop switch
        {
            <= 3 => "Microwave Bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We dont have that size."
        };
        
        Console.WriteLine($" The Popcorn size You've selected is, {size}!");
    
    } //End Objective3





}//End Class
        


    
