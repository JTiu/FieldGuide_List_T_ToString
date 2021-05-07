using List_T;
using System;

namespace SoccerTeams
{


    class Program
    {
        static void Main()
        {
            //Instantiate object
            SoccerTeam ocsc = new SoccerTeam("Las Cruces SC", "Las Cruces Stadium");

            //Simulate some matches
            ocsc.AddResult(4, 2); //win
            ocsc.AddResult(2, 2); //draw
            ocsc.AddResult(1, 0); //win
            ocsc.AddResult(0, 1); //loss

            //Print record by calling WinRatio property.
            Console.WriteLine("Win Ratio of team is: " + ocsc.WinRatio + "\n");

            //Print what is in our class
            Console.WriteLine(ocsc.ToString());
            
            //Wait for user input
            Console.ReadLine();

        }
    }
}