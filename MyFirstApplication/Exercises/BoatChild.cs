
namespace MyFirstApplication;
/*
 Exercise 11 Inheritance  
       Boat Class Child

 Objective: Create a child class based on your Boat object. Include one child attribute as 
an auto property. Create 3 constructors. The first constructor should have 5 parameters; 
4 of them from Horse and your child property. Using the keyword :base(), you will put the 
four horse parameters in the parenthesis. In the body of the constructor you will assigned
your child parameter to your property. The second constructor should have 3 parameters, 
2 based on the Horse, and 1 from your child. Using the :this() keyword, you will pass 2 of
the parent attributes and your child attribute information to the first constructor. Include
default values to represent the 2 remaining horse parameters. For the last constructor, you
will created the default constructor. Using the :this() keyword, you will pass 3 default values 
in that will pass to the 2nd constructor. Also include in the class, your method for your child 
class. Include 1 child attribute as expression body definition properties. 
 */


    // Child class of Horse
    public class Sloop : Boat
    {
        // auto property
        public int Capacity { get; set; }

        // 1st constructor
        public Sloop(string Hull, string Deck, string Helm, string Motor, int Crew)
            : base(Hull, Deck, Helm, Motor)

        { Capacity = Crew; }


        // 2nd constructor         
        public Sloop(string Hull, string Deck)
            : this(Hull, Deck, "mechanical", "in-board", 6)
        { }


        // 3rd constructor
        public Sloop()
            : this("aluminum", "wood")
        { }


        // Sloop Method/s


        public void ShowSloop()
        {
            Console.WriteLine($"My new {Hull} sloop with an {Motor} motor! Seats {Capacity}");

        }// End Method

    /*
     Exercise 12 Polymorphism
    Objective: In your child class of Boat, using the override keyword create
    a method that has the same name as the virtual method from Boat. Add a 
    Console.WriteLine that provides a diffrent message from the Boat. 
     */
    public override void NewBoat()
    {
        base.NewBoat();
        Console.WriteLine($"This {Hull} sloop may only seat {Capacity}.");
    }


}// End SubClass
