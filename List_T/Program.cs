// C# program to demonstrate
// Stack ToString() method
using System;
using System.Collections;

class Lawyer
{

    public static void Main(String[] args)
    {
        // Creating an Empty Stack
        Stack jd = new Stack();
        Console.WriteLine("The Stack is empty here");
        Console.ReadLine();

        // Use Push() method
        // to add elements to 
        // the stack
        Console.WriteLine("Pushing to a stack: *jd*, here");
        jd.Push("PD1\n");
        jd.Push("PD2");
        jd.Push("PD3");
        jd.Push("PD4");
        jd.Push("PD5");
        Console.ReadLine();
        Console.WriteLine("*jd* is a " + jd.GetType());
        Console.ReadLine();

        Console.WriteLine("Let's apply the 'ToString Method': \n");

        foreach (string str in jd)
        {
            // Using ToString() method
            Console.WriteLine(str.ToString());
        }

       
        Console.ReadLine();
    }
    
}