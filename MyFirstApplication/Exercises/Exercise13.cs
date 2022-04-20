
namespace MyFirstApplication;
/*
 Exercise 13 Abstract & Interfaces
Objective 1: In Exercise 13.cs file, change your class to an interface and name it IMovement. 
This interface will have 1 property. The property will be an int and called Speed. It will have a get and init.
 */
public interface IMovement
{
    int Speed { get; init; }
    
}
/*
 Objective 2: Under the interface you will create an Abstract class called WaterBirds.
This abstract class will implement the IMovement interface. The interface property
should be implemented in the Abstract class as an abstract property. Create two
abstract methods for the abstract class that are related to WaterBirds. Create
a constructor that will take an int parameter and be assigned to the Speed property.
 */
internal abstract class WaterBirds : IMovement
{
    protected int num;
    public abstract int Speed { get; init; }
    public abstract int Hours { get; set; }
    public abstract int Miles { get; set; }
    public abstract int WingBeats { get; set; }

    public abstract int Distance();
    public abstract int BeatsPerMinute();

    protected WaterBirds(int Speed)
    {
        this.Speed = Speed;
    }
    
    

} // end class
/*
 Objective 3: Under the abstract class WaterBirds, create a derived class that will extend the WaterBird Class.
Implement the abstract methods and property. Use Console.WriteLine statements in your methods that provide
infrmation related to the methods. One of them should use an Interpolation and consume the speed property.
create a constructor that will take an int parameter and use the :base() to pass that int value back to 
the base abstract class

 */


internal class Ducks : WaterBirds
    
{
    public override int Hours { get; set; } = 10;
    public override int Miles { get; set; } = 500;
    public override int WingBeats { get; set; } = 60;
    public override int Speed { get; init; } = 50;

    public Ducks(int value)
        :base(value) { }

    public override int Distance()
    {
        
        return Speed * Hours;
    }
    public override int BeatsPerMinute()
    {
       
        return ((Miles / Speed)* 60) * WingBeats;
    }

} // end class


// Program.cs Call
/*
Exercise13Test();

void Exercise13Test()
{
    Ducks myDucks = new Ducks(50);
    Console.WriteLine($"This water bird beat its wings {myDucks.BeatsPerMinute()} times," +
            $"for this flight!");

    Console.WriteLine($" Distance traveled was {myDucks.Distance()} miles.");
}
*/