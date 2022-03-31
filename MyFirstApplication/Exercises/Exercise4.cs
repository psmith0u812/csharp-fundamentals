

namespace MyFirstApplication
{
    internal class Exercise4
    {

        /*
         Objective 1:
        Write a method that takes 2 string argmuents and a void return type.
        Using an if-else statment, compare the two strings to each other. Using a
        Console.WriteLine statment, print out the restults of whether the strings 
        are equal. Provide a comment inside the method that says what strings you used 
        during testing. 
         */

        public void Ex4Objective1(string alpha, string beta)
            // Values used for alpha = large, narrow  
            // Values used for beta = small, wide
        {
            if (alpha.Length == beta.Length)
            {
                Console.WriteLine($"The words {alpha} and {beta} are the same size.");
            }
            else 
            {
                Console.WriteLine($"The words {alpha} and {beta} are not the same size. ");
            }
        } // End Objective1

        /*
        Objective 2:  
        Write a method that will take 1 char argument and a string return type. 
        using a swtich and the table provided, return the description. If the value 
        does not match the grade, return the default message, "Not a valid grade".
         */
        
        public string Ex4Objective2(char charlie)

        {
            
            switch (charlie)
            {

                case 'E':
                    
                    Console.WriteLine($"{charlie} is Excellent!");
                    break;

                case 'V':
                    Console.WriteLine($"{charlie} is Very Good!");
                    break;

                case 'G':
                    Console.WriteLine($"{charlie} is Good");
                    break;

                case 'A':
                    Console.WriteLine($"{charlie} is Average");
                    break;

                case 'F':
                    Console.WriteLine($"{charlie} is Fail");
                    break;

                default:
                    Console.WriteLine($"{charlie} Is not a valad grade.");
                    break;
    
            }
             return charlie.ToString();

        } // End Objective2



        /*
         Objective 3: 
        Write a method that takes no arguments and a void return type.
        Using an iteration statment, display all the numbers divisible by 3 from 0-30
        Utilize a modulus to obtain your results.
         */

        public void Ex4Objective3()
        {
            int num = 0;

            Console.WriteLine("\nMultiple of 3:");
            for (num = 1; num <= 30; num++)
            {
                if (num % 3 == 0)
                {
                    Console.Write(num + " \n");
                }

            }
            
            
        } // End Objective3     



    } // End of Exercise4

} // End of Class
