using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    internal class Team
    {
        //properties
        private string Name { get; set; }
        private List<Player> Players { get; set; }

        //constructors
        public Team(string name, List<Player> players)
        {
            Name = name;
            Players = players;
        }
    }
}
