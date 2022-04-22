/*
   Exercise 16 Collections

 */

namespace MyFirstApplication;

internal class Exercise16
{
    /*
    Objective 1: Write a method that has no parameters and no return type. 
    Create a List<T> of your horse objects. When creating your list, utilize all 
    the constructors you created with your horse class. Using a foreach
    loop, print out the restults of your collection using a 
    Console.WriteLine statment. 
     */

    public void HorseObjectList()
    {
        List<Horse> HorseList = new List<Horse>();
        HorseList.Add(new Horse());
        HorseList.Add(new Horse("Braided", "Stright", "Red", "Good"));
        HorseList.Add(new Horse("Cropped", "Braided", "Grey", "Poor"));
        HorseList.Add(new Horse("Loose", "Cropped", "Walnut", "New"));


        foreach (Horse ThisHorse in HorseList)
        {
            Console.WriteLine(ThisHorse.Main);
            Console.WriteLine(ThisHorse.Tail);
            Console.WriteLine(ThisHorse.HorseColor);
            Console.WriteLine(ThisHorse.Hooves);
            
        }
    }

    /*
     Objective 2: Write a method that has no parameters and no return type. Using only
    the data you used when building your favorite movies from exercise 15, create
    a Dictionary collection that takes an int key and string value. When adding
    Dictionary elements, pick an int value as the key and use the favorite movies
    data as the string. Using a Foreach loop, print out the results of your colletion 
    a Console.WriteLine statement. 
     */

    public void MovieDict()
    {
        Dictionary<int, string> movie = new Dictionary<int, string>();
        movie.Add(5, "Fifth Element");
        movie.Add(10, "Repo the Genetic Opera");
        movie.Add(15, "Mr. Nobody");
        movie.Add(20, "Pathfinder");
        
       
        foreach (KeyValuePair<int, string> film in movie)
        {
            Console.WriteLine($"Key: {film.Key}, Value: {film.Value}");
        }

    }



}// end class
