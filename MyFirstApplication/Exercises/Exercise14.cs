﻿
// Exercise 14 : Arrays
namespace MyFirstApplication;

/* Objective 1: Write a Method with no parameters and no return type. Write a single
 dimensional string array of ice cream flavors. Using a foreach loop in your method, 
print out the results of your array using a Console.WriteLine statment.
*/
internal class Exercise14
{

    
    public void FlavorsArray()
    {
        string[] flavors = { "chocolate", "vanilla", "strawberry", "rocky road" };

        foreach (string flavor in flavors)
        {
            Console.WriteLine(flavor);
        }

    }

    /*
     Objective 2: Write a method with no parameters and no return type. Write a two-dimensional
    array using the int data type. Using the link below, fill in each dimension with the KC Chiefs
    regular season scores. The first dimension will be the home team, while the second dimension will
    be the away team. Using a foreach loop, print out the results of your array using a Console.WriteLine
    statement. To determine which team is home and away, the website includes the link to the box sore.
    the link label shows both teams. The first team in the lable is the away team. 
     */

    public void ChiefScoreArray()
    {                   
        int[,] Scores = { {22, 38, 9, 34, 23, 34, 26, 32, 26, 43, 35, 33, 35, 27, 22, 33, 32, 17, 21 },
            {17, 24, 31, 20, 20, 20, 10, 40, 17, 16, 9, 31, 31, 24, 16, 27, 29, 14, 38} };

        foreach (int score in Scores)
            Console.WriteLine(score);
    }


}
