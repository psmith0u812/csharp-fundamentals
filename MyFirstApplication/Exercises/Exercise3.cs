

namespace MyFirstApplication
{
    internal class Exercise3
    {

        /*
         Objective 1: Write a method that takes 1 int argumart and an int return type. Utilize the modulus operator
        to complete this task. Assign the data values given to their own variable. Use Console.Writeline statment on the 
        first 4 variables listed below and calculate the modulus with the passed in argument parameter. Using the last variable below,
        Calculate the modulus with the passed in argument parameter and return it. 
         */

        public void Ex3Objective1(int arg)
        { //Objective 1 argument
            arg = 245; //last variable in list 
            //calculated modulus using first four provided values.
            Console.WriteLine(arg % 15);
            Console.WriteLine(arg % 456);
            Console.WriteLine(arg % 23);
            Console.WriteLine(arg % 89);

        }//End of Objective1


        /*
         Objective 2: Write a method that takes no arguments and a void return type.
        Utilizing the math problem in this task, fill any missing pieces to get the output
        10 + 32 * 12 / 3. Write a Console.WriteLine to solve each output. 
         */
        public void Ex3Objective2()
        {
            Console.WriteLine(10 + 32 * 12 / 3);
            Console.WriteLine(24 + 18 * 24 / 3);
            Console.WriteLine(71 + 60 * 3 / 3);

        }//End of Objective2
         

        /*
         Objective 3: Write a method that takes two short type arguments and a void return type
        Using the Compound Assignment operators provided, use the first argument parameter as the 
        left operand to get the result. 
        Print each one using the Console WriteLine Statement. 
         */
        public void Ex3Objective3(short arg1, short arg2)

        {
            arg1 = -16_485;
            arg2 = 18_542;

            Console.WriteLine(arg1 += arg2);
            Console.WriteLine(arg2 /= arg1);
            Console.WriteLine(arg1 *= arg2);
            Console.WriteLine(arg2 %= arg1);

        }// End of Objective3


        /*
         Objective 4: Write a method that takes two bool type arguments and a void return type.
        Using Boolean Logical operators &, |, ^, and || to complete this task. 
        Use a Console WriteLine statement to calculate each result using operators.
        The second argument is the left Operand. Use values given when testing your method.
        Using comments, Provide your output results inside the method after your statments. 
         */

        public void Ex3Objective4(bool alpha, bool beta)
        {// Output results in order ------------_A_-----_B_-----_C_-----_D_---|
            Console.WriteLine(beta & alpha); // False | False | True  | False |
            Console.WriteLine(beta | alpha); // True  | False | True  | True  |
            Console.WriteLine(beta ^ alpha); // True  | False | False | True  |
            Console.WriteLine(beta || alpha);// True  | False | True  | True  |

        } // End of Objective4


    } //End of Exercise


}// End of Class
