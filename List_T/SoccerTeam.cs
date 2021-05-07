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

       

        //Override ToString() class so we can get a nice visual of what our class contains
        public override string ToString()
        {
            return this.name + " plays at " + this.stadium + ": " + "W" + this.wins + " L" + this.losses + " D" + this.draws;
        }

    }
}
