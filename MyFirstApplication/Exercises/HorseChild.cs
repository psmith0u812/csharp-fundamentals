
namespace MyFirstApplication;
/*
 Exercise 11 Inheritance  
       Horse Class Child

 Objective: Create a child class based on your Horse object. Include one child attribute as 
an auto property. Create 3 constructors. The first constructor should have 5 parameters; 
4 of them from Horse and your child property. Using the keyword :base(), you will put the 
four horse parameters in the parenthesis. In the body of the constructor you will assigned
your child parameter to your property. The second constructor should have 3 parameters, 
2 based on the Horse, and 1 from your child. Using the :this() keyword, you will pass 2 of
the parent attributes and your child attribute information to the first constructor. Include
default values to represent the 2 remaining horse parameters. For the last constructor, you
will created the default constructor. Using the :this() keyword, you will pass 3 default values 
in that will pass to the 2nd constructor. Also include in the class, your method for your child 
class. 
 */

// Child class of Horse
public class Pony : Horse
{
    // auto property
 public bool HasSpots { get; set; }
 
    // 1st constructor
    public Pony(string main, string tail, string color, string hooveCondition, bool spots)
        : base(main, tail, color, hooveCondition)
    
    {HasSpots = spots;}
     
        
    // 2nd constructor         
    public Pony(string main, string tail)
        :this(main, tail, "grey", "Good", true)
    { }

        
    // 3rd constructor
    public Pony()
        :this("cropped", "braided")
    { }
 

    // Pony Method/s
    public string PonySpots(bool HasSpots)
    {
        return HasSpots ? "spotted" : "plain";
        
    }

    public void ShowPony()
    {
      Console.WriteLine($"My {PonySpots(HasSpots)} {HorseColor} Pony, with {Main} main, and {Tail} tail.");

    }// End Method
    /*
     Exercise 12 Polymorphism
    Objective: In your child class of Horse, using the override keyword create
    a method that has the same name as the virtual method from horse. 
    Add a Console.Writeline that provides a different message from Horse.
     */
    public override void ShowHorse()
    {
        base.ShowHorse();
        Console.WriteLine($"This {HorseColor} Pony, with {Main} main, and {Tail} tail is too small to be outfitted.");
    }

} // End Subclass

    
    
    






