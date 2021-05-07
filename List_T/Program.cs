using System;

namespace Lawyers
{
    public class Example
    {
        public static void Main()
        {
            Prosecutors pros1 = new Prosecutors();
            PublicDefender pd1 = new PublicDefender();
            Console.WriteLine(pros1.ToString());
            Console.WriteLine(pd1.ToString());
            Console.ReadLine();
        }
    }
}


