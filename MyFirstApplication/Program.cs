using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment


/*
 Multi-line comment
The below statement is a local function, local functions
are inside of members and are private by default. This means
they are specific to that member and can only be called
inside that member.
 */

// Lesson Examples
// HouseExample();
// Lesson1Example();
// Exercise1();
// Exercise2();
// Lesson2Example();
// Lesson3Example(); 
// Exercise3();
// Lesson4Example();
// Exercise4();
// Lesson5Example();
// Exercise5();
Lesson6Examples();


void Lesson6Examples()
{
    // Default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");
    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 Parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;


    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);


    // Multi-Cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");




}




void Exercise5()
{
    Exercise5 myExercise5 = new Exercise5();
    //myExercise5.Ex5Objective1(23,4);
    // myExercise5.Ex5Objective2('G');
    // string result = myExercise5.Ex5Objective2('G');
    // Console.WriteLine($" Your grade is {result}!");
    myExercise5.Ex5Objective3(24);
    



}





// Lesson 5 Expressions & Pattern Matching
// void Lesson5Example()
{
    // Lesson5 myLesson5 = new Lesson5();

    // Call Method of myLesson5
    // myLesson5.IsOperatorExample(34);

    // Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    // Function Delagate
    // Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"Func example = {add(23)}");

    //Lambda Expression
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    //Switch Expressions
    // string value1 = myLesson5.BasicSwitch("red");
   // Console.WriteLine(value1);
    // string value2 = myLesson5.FavoriteColor("green");
    // Console.Write(value2);

    // Relational Pattern
    // myLesson5.DrinkSize(33);

    //Logical Patterns
    // myLesson5.TemperatureGuide(48.6);
    // myLesson5.NumberChoice(3);


}

// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatment(12);
    // myLesson4.BasicIfElseChainStatment(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatment();
    // myLesson4.BasicJumpStatement();
    
}

void Exercise4()
{
    Exercise4 myExercise4 = new Exercise4();
    // myExercise4.Ex4Objective1("narrow", "wide");
    // myExercise4.Ex4Objective2('G');
    // myExercise4.Ex4Objective3();

}


    //Exercise3 Operators

    void Exercise3()
    {
        Exercise3 myExercise3 = new Exercise3();
        myExercise3.Ex3Objective1(245);
        // myExercise3.Ex3Objective2();
        // myExercise3.Ex3Objective3(-16_485, 18_542);
        // myExercise3.Ex3Objective4(false, true);
    }





    // Lesson 3 Operators and Overflow Checking
    void Lesson3Example()
    {
        Lesson3 myLesson3 = new Lesson3();
        // myLesson3.BasicCheckedOperator(14);
        // myLesson3.BasicCheckedExample2();
        //  int alpha = 2147483647;
        //  int total = alpha + 1;
        //  Console.WriteLine(total);
        // -2147483639
        // myLesson3.BasicUncheckedExample();
        // myLesson3.BasicMath();
        // myLesson3.BasicModulus(783);
        // myLesson3.BasicBooleanLogical(true, false);
        // myLesson3.BasicCompoundExample(12, 35, 9);
        // myLesson3.BasicRelationalExample("Tom", "Tim");
        // myLesson3.MyIncrDecrExample();

    }


/* Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello Wolrd");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.myEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}*/


/*
void Exercise1()
{
    Exercise1 myExercise1 = new Exercise1();
    // myExercise1.Objective1();
    // myExercise1.Objective2();
    // myExercise1.Objective3();
    myExercise1.Objective4();
}

void Exercise2()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.Ex2Objective1();
    myExercise2.Ex2Objective2();
    myExercise2.ExObjective3();

    Console.WriteLine(myExercise2.Ex2Objective4("Hrothgar", "Takis chips", "Dr Pepper", "10 Things I hate about You"));
}
*/    

/*
void HouseExample()
{ 
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}
*/


/*
 This local function is for the Overview exercise lab.
 */


/*     void MyLocalFunction()
{ 
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");
}
*/
   // MyLocalFunction();



 
