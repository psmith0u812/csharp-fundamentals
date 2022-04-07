
namespace MyFirstApplication
{
    internal class Exercise6
    {
        /*
         Objective 1: Write a constructor for your exercise file that takes 2 parameters. 
        The first parameter should have an int type and a variable name of showSize.
        The second parameter should have a string type and a variable name of shoeType.
        Create private class variables for these types and use and undescore when defining them. 
        Inside the constructor associate the class variables with the constructor parameters.
         */

            private int _shoeSize;
            private string _shoeType;

        public Exercise6(int size, string type)
        {
            _shoeSize = size;
            _shoeType = type;
        }
         // ----End Objective 1----
        /*
         Objective 2: Write the properties for the class variables defined in exercise 1. 
        Ensure they are labled as publi and are spelled using a capital letter. 
         */  
        
        public string ShoeType
        {
         get { return _shoeType; }
         set { _shoeType = value; }
        }

        public int ShoeSize
        {
        get { return _shoeSize; }
        set { _shoeSize = value; }
        }
        //----End Objective2----

        /*
         Objective 3: Write a delegate that takes a string parameter. This delegate should be named
        TryOn. Write a method that takes a string argument and void return type. In the method body, 
        include a Console.WriteLine statement that will print the message. Test your delegate in 
        Program.cs to ensure everything works properly. Using a multi-line comment on your 
        Exercise6.cs file, provide the information you used to test the delegate. 
         */

        public delegate void TryOn(string type);

        public void TryOnShoes(string message)
        {
            Console.WriteLine($"{message}");
        }

        /*
          Method Used to call Objective 3. 

            Exercise6();

            void Exercise6()
            {
                Exercise6 myExercise6 = new Exercise6(12, "Brogues");
                Exercise6 myExercise6Shoes = new Exercise6(myExercise6.ShoeSize ,myExercise6.ShoeType);
                Exercise6.TryOn ShoeType = myExercise6.TryOnShoes;
                Console.WriteLine($"Brand new pair of {myExercise6Shoes.ShoeType}...");   
            }

         */
        // ----End Objective 3----

    } // End class
}
