using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    internal class Player
    {
        //properties
        private string Name { get; set; }
        private string ResultRecord { get; set; }
        private int Points;

        //constructors
        public Player(string name, string resultRecord)
        {
            Name = name;
            ResultRecord= resultRecord;
        }

        //methods
        public override string ToString()
        {
            return $"{Name}-{ResultRecord}-{Points}";
        }

        public void CalculatePoints(Team team)
        {
            //loop through players on team
            foreach (Player player in team.Players) 
            { 

            //declare variables
            int Points = 0, win = 3, draw = 1;
            
            //read result record and split
            char[] chars = player.ResultRecord.ToCharArray();

            //loop through results and assign points
            for(int x = 0; x < chars.Length;x++)
            {
                if (chars[x] == 'W')
                {
                    player.Points += win;
                }
                else if (chars[x] == 'D')
                {
                    player.Points += draw;
                }
            }
            }
        }
    }
}
