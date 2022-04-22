/*
 Exercise 15 Enums and Tuples 
Objective 1: Above the class, write an enum called Favorite Movies. Add your own
favorite movies to the enum. Write a method that has a string return type
and an enum parameter. This enum parameter will be your favorite movie enum.
Write a switch expression that takes the enum and prints out a string return. 
Use string interpolation in your return message that includes the name of the 
movie chosen. 
 */

namespace MyFirstApplication;

public enum FavoriteMovies { Fifth_Element, Pathfinder, Mr_Nobody, The_Three_Musketeers, Repo_The_Genetic_Opera}

internal class Exercise15
{
    public string MovieEnum(FavoriteMovies Movies)
    {
        string message = Movies switch
        {
            FavoriteMovies.Fifth_Element => $"My favorite movie is {FavoriteMovies.Fifth_Element}",
            FavoriteMovies.Pathfinder => $"My favorite movie is {FavoriteMovies.Pathfinder}",
            FavoriteMovies.Mr_Nobody => $"My favorite movie is {FavoriteMovies.Mr_Nobody}",
            FavoriteMovies.The_Three_Musketeers => $"My favorite movie is {FavoriteMovies.The_Three_Musketeers}",
            _ => $"My favorite movie is {FavoriteMovies.Repo_The_Genetic_Opera}"
        };
        return message;
        
    }

    /*
     Objective 2: Write a method that takes an enum parameter. This enum will be your favorite movie enum.
    The method will have a tuple return type (int num,string movie). Using an explicit int cast on one 
    of your enum, assign the value to an int variable. Create a second variable of type string.
    assign the same enum value you used and use the ToString() at the end of it. Return both variables as 
    a tuple. see example:
    Ex:  a. int value = (int)Enum.Value;
         b. string something = Enum.Value.ToString();
     */

    public (int, string) TupleMovieReturn(FavoriteMovies Movies)
    {
        
        int able = (int)FavoriteMovies.Mr_Nobody;
        string film = FavoriteMovies.Mr_Nobody.ToString();
        (int, string) obscure = (able , film);
        Console.WriteLine($"The return of this exercise is {obscure}");
         return obscure;
    }
    



} // end class
