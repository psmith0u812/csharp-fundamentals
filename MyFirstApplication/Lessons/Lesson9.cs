﻿
namespace MyFirstApplication;

/*Access Modifiers*/
internal class Lesson9
{
    private int _value = 10;

    /*
     Private access modifier can only be seen within the class, struct or nested type
     */
    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     Protected access modifier can only be seen within the type of a chile(derived class.
     */
    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected.");

    }
    /*
     Internal access modifier can be seen within the assembly, not others. 
     */
    internal void SampleInternal()
    {
        Console.WriteLine("This method is Internal.");
    }

    /*
     Protected internal can be seen within the assembly or child(derived class from
    another assembly
     */
    protected internal void SampleProtectedInternal()
    {
        Console.WriteLine("This method is protected inturnal");
    }

    /*
     Private Protected an be seen only within the class and child(derived) class
    from within the assembly
     */
    private protected void SamplePrivateProtected()
    {
        Console.WriteLine("This method is private protected.");
    }


    public class Nested
    {
        public Nested(Lesson9 parent)
        {
            Console.WriteLine($"The value is {parent._value}");
        }

    }// End Nested Class

} // End Class
