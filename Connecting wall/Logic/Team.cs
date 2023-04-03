using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecting_wall.Logic
{
    public class Team
    {
        public int TeamScore
        {
            get { return TeamScore; }
            set
            {
                if (value < 0)
                    throw new Exception("Team score cannot be negative");
                TeamScore = value;
            }
        }

        public string TeamName
        {
            get { return TeamName; }
            set
            {
                if (value == null)
                    throw new Exception("Team score cannot be blank");
                TeamName = value;
            }
        }

        public Team(int teamScore, string teamName)
        {
            TeamScore = teamScore;
            TeamName = teamName;
        }

        public override string ToString()
        {
            return $"{TeamScore}, {TeamScore}";
        }
    }
}
