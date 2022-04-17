/*
 Exercise 10 Encapsulation, Horse Class

Objective: Create a class based on your Horse object. Include your attributes as auto
properties. Create 3 constructors. The first constructor should have parameters 
equal to your properties. Assign each parameter to your properties. The second 
constructor should have 2 parameters. Using the :this() keyword, you will pass 
information to the first constructor. This includes the 2 parameters and default
values. For the last constructor, you will create the default constructor. Using
the :this() keyword, you will pass 2 default values in; that will pass to the 2nd
constructor. Also include in the class, your method for Horse. 
 */

namespace MyFirstApplication;

public class Horse
{ // properties
    public string Main { get; init; }
    public string Tail { get; init; }
    public string HorseColor { get; init; }
    private string Hooves { get; init; }

    // 1st constructor
     public Horse(string main, string tail, string color, string hooveCondition)
    {
        Tail = tail;
        Main = main;
        HorseColor = color;
        Hooves = hooveCondition;  
    }
    
    // 2nd constructor
    public Horse(string main, string tail)
        :this(main, tail, "Red", "Good")
    { }
    
    // 3rd Default constructor
    public Horse()
        :this("braided", "stright")
    { }

   // Horse Method
   public void ShowHorse()
    {
        Console.WriteLine($"My {HorseColor} Horse, with {Main} main, and {Tail} tail.");
    }

} // End Class


/*
 Program.cs Call 

void Horse()
{
    Horse myHorse = new Horse();
    myHorse.ShowHorse();
}
*/
