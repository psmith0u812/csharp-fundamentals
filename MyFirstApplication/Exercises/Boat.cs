
/*
  Exercise 10 Encapsulation, Boat Class

Objective: Create a class based on your Boat object. Include your attributes as auto
properties. Create 3 constructors. The first constructor should have parameters 
equal to your properties. Assign each parameter to your properties. The second 
constructor should have 2 parameters. Using the :this() keyword, you will pass 
information to the first constructor. This includes the 2 parameters and default
values. For the last constructor, you will create the default constructor. Using
the :this() keyword, you will pass 2 default values in; that will pass to the 2nd
constructor. Also include in the class, your method for Boat. Include your 
attributes as Expression Body Definition Properties. 
 */

namespace MyFirstApplication;

internal class Boat
{
    public string _hull;
    public string _deck;
    private string _helm;
    public string _motor;

    // Attributes as Expression Body Definition Properties. 
    public string Hull
    {
        get => _hull;
        set => _hull = value;
    }
    public string Deck
    {
        get => _deck;
        set => _deck = value;
    }
    private string Helm
    {
        get => _helm;
        set => _helm = value;
    }
    public string Motor
    {
        get => _motor;
        set => _motor = value;
    }

    // 1st Constructor
    public Boat(string Hull, string Deck, string Helm, string Motor)
    {
        _hull = Hull;
        _deck = Deck;
        _helm = Helm;
        _motor = Motor;
    }

    // 2nd Constructor
    public Boat(string Hull, string Deck)
        : this(Hull, Deck, "mechanical", "outboard")
    { }

    // 3rd Default Constructor
    public Boat()
        : this("fiberglass", "wood")
    { }

    // Boat Method
    public void NewBoat()
    {
        Console.WriteLine($"My new {Hull} boat with an {Motor} motor!");
    }

} // End Class


/* 
     Program.cs Call

    void Boat()
    {
        Boat myBoat = new Boat();
        myBoat.NewBoat();
    }
    */