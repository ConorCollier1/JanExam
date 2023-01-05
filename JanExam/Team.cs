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
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public int Points;

        //constructors
        public Team(string name, List<Player> players)
        {
            Name = name;
            Players = players;
        }

        //methods
        public override string ToString()
        {
            return $"{Name}-{Points}";
        }

        public void CalculateTeamPoints(Team team)
        {
            foreach (Player player in team.Players)
            {
                int p=player.CalculatePoints(player);
                Points += p;
            }
        }
    }
}
