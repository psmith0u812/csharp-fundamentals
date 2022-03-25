namespace MyFirstApplication;

/*
Exercise 1 Value Types
 */

public class Exercise1
{

    /*
     Objective 1: Write a method with no arguments, and a void return type that 
    will print the output of the number 35 based on the number systems Dec, Hex, and Bin.
    The values should be assigned to a variable inside the method prior to using
    the Console WriteLine. Utilize conversion resource document. 
     */
    public void Objective1()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 0x23; //hexadecimal
        int value3 = 0b100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }//End of Objective 1
    

    /*
     Objective 2: Write a method that will accept 3 argument parameters and a 
    void return type. Argument return types should be byte, short, and int respectively.
    Using Implicit conversion, create variables to convert using provided information. 
    Use the argument parameters to provide values being converted from. 
    Print converted result using Console Writeline.
     */
    // Arguments for Objective 2
    byte arg1 = 104;
    short arg2 = 28_702;
    int arg3 = 1_555_425_122;
    
    public void Objective2()
    {
        int ByteToInt = arg1;
        long ShortToLong = arg2;
        float IntToFloat = arg3;
        Console.WriteLine(ByteToInt);
        Console.WriteLine(ShortToLong);
        Console.WriteLine(IntToFloat);
    }//End of Objective 2


    /*
     Objective 3: Write a method that accepts 3 argument parameters and a void return
    type. Arguments should be value type double, float, and long respectively. Using
    Explicit Conversion, create variables to convert using provided information. 
    Use the argument parameters to provide values being converted from. 
    Print converted result using Console Writeline.
     */

    // Arguments for Objective 3
    double arg4 = 1.6e22;
    float arg5 = 1.1e13F;
    long arg6 = 8_452_225_454_954_301_444;

    public void Objective3()
    {
        double DoubleToLong = (long)arg4;
        float FLoatToInt = (int)arg5;
        long LongToShort = (short)arg6;
        Console.WriteLine(DoubleToLong);
        Console.WriteLine(FLoatToInt);
        Console.WriteLine(LongToShort);
    }// End of Objective 3


    /*
     Objective 4: Write a method with no arguments and a void return type.
    Using values provided, assign them to a variable that best suits their
    value type. Utilize the digit separator when assigning them to your 
    variables. Once defined, print out each variable using Console Writeline.
    Do not use the same value type more than once. 
     */

    public void Objective4()
    {
        double alpha = 123456.987;
        int beta = -9516248;
        ushort charlie = 3500;
        uint delta = 988562486;
        decimal echo = -19733.14895M;
        Console.WriteLine(alpha);
        Console.WriteLine(beta);
        Console.WriteLine(charlie);
        Console.WriteLine(delta);
        Console.WriteLine(echo);

    } // End of Objective 4


} // end class