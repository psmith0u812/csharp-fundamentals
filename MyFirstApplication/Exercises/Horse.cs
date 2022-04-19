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
   /*
     Exercise 12 Polymorphism
    Objective: In your Horse class, add the virtual keyword to your method created in
    Lesson 10. Create a second version of the same method and add a parameter. Include
    a Console.WriteLine method in the new method that uses the parameter. This parameter
    needs to be based on one of your properties. 
     */

   public virtual void ShowHorse()
    {
        Console.WriteLine($"My {HorseColor} Horse, with {Main} main, and {Tail} tail.");
    }

   public virtual void ShowHorse(string Tack)
        
        
    {
        Console.WriteLine($"This {HorseColor} Horse, with {Main} main, and {Tail} tail is outfitted with a {Tack} setup.");
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
