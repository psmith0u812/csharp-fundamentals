﻿

namespace MyFirstApplication;
/*
 Lesson 4 - Control Flow Statments
 */
internal class Lesson4
{
    // Basic If statment
    public void BasicIfStatement(int value)
    {
        Console.WriteLine("Before if statment");
        if (value > 10)
        {
            Console.WriteLine($"Our {value} was greater than 10.");
        }
        Console.WriteLine("After if statment");

    }

    // basic if-else statment
    public void BasicIfElseStatment(int able)
    {
        if(able >= 15)
        {
            Console.WriteLine($"Out {able} is greater than 15");
        }
        else
        {
            Console.WriteLine($"Our {able} was less than 15");
        }
    }

    // Basic if-else chain
    public void BasicIfElseChainStatment(int beta)
    {
        if(beta == 10)
        {
            Console.WriteLine($"Our {beta} is 10");
        }
        else if(beta== 20)
        {
            Console.WriteLine($"Our {beta} is 20");
        }
        else
        {
            Console.WriteLine($"Our {beta}is not the same.");
        }
    }

    // Basic if wheith Boolean Logical Operators
    public void BasicAndOrCondition(int charlie, int delta)
    {
        if(charlie > 15 && delta < 30)
        {
            Console.WriteLine($"{charlie} and {delta}");
        }

        if(charlie == 18 || delta < 25)
        {
            Console.WriteLine($"{charlie} or {delta}");
        }

    }

    // Ternary Operator
    public bool BasicTernaryExample(int echo)
    {
        return (echo > 30) ? true : false;
    }

    // Switch Statment
    public void BasicSwitchStatement(int able)
    {
        switch (able)
        {
            case 1:
            case 2:
                Console.WriteLine($"{able} is 1 or 2");
                break;
            case 3:
                Console.WriteLine($"{able} is 3");
                break;
            case 4:
                Console.WriteLine($"{able} is 4");
                break;
            default:
                Console.WriteLine($"{able} was not in the list");
                break;
        }

    } 

    // While Statement
    public void BasicWhileStatement()
    {
        int fox = 0; // initialization
        while(fox < 10) // condition
        {
            Console.WriteLine($"Number ={fox}");
            fox++; // Increment
        }
    }

    // do Statement
    public void BasicDoStatement()
    {
        int hotel = 0; // initialization
        do
        {
            Console.WriteLine($"Do Number {hotel}.");
            hotel++; // increment
        } while (hotel < 13); // condition
    }

    // For statement
    public void BasicForStatement()
    {
        for(int i = 0; i < 12; i++)
        {
            Console.WriteLine($"For Number = {i}");
        }
    }

    // For-Each statement
    public void BasicForeachStatment()
    {
        foreach(char word in "Something")
        {
            Console.WriteLine($"Char value = {word}");
        }
    }

    // Jump Statements
    public void BasicJumpStatement()
    {
        for(int i =0; i < 10; i++)
        {
            if(i == 2)
            {
                Console.WriteLine($"The {i} was skipped");
            }
            if(i == 4)
            {
                Console.WriteLine($"The loop breaks at {i}");
                break;
            }
            Console.WriteLine($"Number = {i}");
        }
    }


}// End Class
