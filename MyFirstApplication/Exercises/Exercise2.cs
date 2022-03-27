
namespace MyFirstApplication
{
    internal class Exercise2
    {



        /*
         Objective 1: Write a method that takes a string argument parameter and void
        return type. Using String Concatenation and the given string methods. Write
        a Console.Writeline statement for each. Inside the concatenation will be the
        name of each string method. When testing use the string "EXERCISE two Lab".

         */
        // Argument for Objective 1

        string ExString = "EXERCISE two Lab";
        public void Ex2Objective1()
        {
            
            Console.WriteLine(ExString.Trim());
            Console.WriteLine(ExString.ToLower());
            Console.WriteLine(ExString.Contains("tow"));
            Console.WriteLine(ExString.Length);
            Console.WriteLine(ExString.IndexOf('C'));

        }//End Objective1


        /*
         Objective 2: Write a method that takes no arguments and a void return type.
        Using the Unicode Table, assign the Unicode value of the Pilcrow Sign to 
        a Variable. Use the Console.WriteLine to print that variable. This variable
        should utilize the type that takes 1 character.
         */
        public void Ex2Objective2()
        {
            char myPilcrow = '\u00B6';
            Console.WriteLine(myPilcrow);

        }//End Objective2


        /*
         Objective 3: Write a method that takes no arguments and a void return type.
        Use 1 string variable and 1 console Writeline to complete this task.
        Use Escape Sequences to achieve the restults given. 
         */

        public void ExObjective3()
        {
            Console.WriteLine("Jack and Jill\nwent up the hill\nto fetch a pail" +
                "of water.\nJack fell down and broke his crown\nand Jill came tumbling" +
                "after.");

        }//End Objective3


        /* Objective 4: Write a method that takes no arguments bu does have a 
        string return type. Utilize Interpolation to complete this task. Create variables
        for each data item provided. Return a string that includes the variables in a 
        sentence. 
       */

        public string Ex2Objective4(string name, string snack, string drink, string movie)
        {
            return $"Hi I\'m {name}, and I like to have {snack} and {drink} while I enjoy " +
                $"watching {movie} my favorite movie!";

        }//End Objective4


    } // End of Exercise
} //End of Class
