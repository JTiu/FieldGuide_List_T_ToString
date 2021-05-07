using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_T
{
    public class SoccerTeam
    {
        //Private fields
        private string name;
        private string stadium;

        //Private fields with initial values
        private int wins = 0;
        private int losses = 0;
        private int draws = 0;

        //Property that takes private fields and computes win ratio
        public double WinRatio
        {
            get
            {
                int matches = this.wins + this.losses + this.draws;
                return (double)this.wins / matches;
            }
        }


        //Method for adding matches to SoccerTeam
        public void AddResult(int goalsFor, int goalsAgainst)
        {
            if (goalsFor > goalsAgainst)
            {
                this.wins++;
            }
            else if (goalsFor == goalsAgainst)
            {
                this.draws++;
            }
            else
            {
                this.losses++;
            }
        }

        //Override ToString() class so we can get a nice visual of what our class contains
        public override string ToString()
        {
            return this.name + " plays at " + this.stadium + ": " + "W" + this.wins + " L" + this.losses + " D" + this.draws;
        }

        //Constructor which defines how the class is initialized
        //Takes two arguments (name and stadium)
        public SoccerTeam(string n, string s)
        {
            this.name = n;
            this.stadium = s;
        }
    }
}
