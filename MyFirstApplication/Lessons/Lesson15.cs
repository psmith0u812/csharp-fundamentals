﻿namespace MyFirstApplication;
/*
 Enums can be created either within a class or struct 
or in the namespace
 */
public enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri};
public enum IceCreamFlavors { Vanilla, Chocolate, Strawberry, RockyRoad}
internal class Lesson15
{
    public void EnumExmple()
    {
        Console.WriteLine(Day.Mon); // displays value
        Console.WriteLine((double)Day.Tue); //displays number value
    }
    // Enum using a switch expression to narrow down choices
    public string FavoriteIceCream(IceCreamFlavors flavors)
    {
        string message = flavors switch
        {
            IceCreamFlavors.Vanilla => $"My Favorite is {IceCreamFlavors.Vanilla}",
            IceCreamFlavors.Chocolate => $"My Favorite is {IceCreamFlavors.Chocolate}",
            IceCreamFlavors.Strawberry => $"My Favorite is {IceCreamFlavors.Strawberry}",
            _ => $"My favorite is {IceCreamFlavors.RockyRoad}"
        };
        return message;
    }

    /*
     Tuples are a group of types using parathesis and separating with a comma.
     */
    public void TupleExample()
    {
        (double, int) able = (2.3, 5);
        Console.WriteLine($"Tuple with elements {able.Item1} and {able.Item2}");

        (double value, double value2) beta = (3.3, 5.4);
        Console.WriteLine($"The second value is {beta.value2} is after {beta.value}");
    }

    /*
     Using a tuple to return multiple results in a method
     */
    public (int able, int beta, int delta) TupleReturnExample(int value1, int value2)
    {
        int alpha, bravo, charlie;
        if (value1 >= 10 || value2 <= 50)
        {
            alpha = ++value1;
            bravo = ++value2;
            charlie = alpha + bravo;
        }
        else
        {
            alpha = 1;
            bravo = 2;
            charlie = 3;
        }
        return (alpha, bravo, charlie);
    }



} // end class
