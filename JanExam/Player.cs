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

        //constructors
        public Player(string name, string resultRecord)
        {
            Name = name;
            ResultRecord= resultRecord;
        }

        //methods
        public override string ToString()
        {
            return $"{Name}-{ResultRecord}";
        }
    }
}
