using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Connecting_wall.Logic
{
    // Team class containing all the team properties and makes use of INotifyPropertyChanged to catch changes in properties.
    
    public class Team : INotifyPropertyChanged
    {
        private int _teamScore; // Team score variable
        private string _teamName; // Team name variable
        
        // Team score property that will not take score values under zero.
        
        public int TeamScore
        {
            get { return _teamScore; }
            set
            {
                if (value < 0)
                    throw new Exception("Team score cannot be negative");
                _teamScore = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TeamScore)));
            }
        }
        public string TeamName
        {
            get { return _teamName; }
            set
            {
                if (value == null)
                    throw new Exception("Team name cannot be blank");
                _teamName = value;
            }
        }

        /// <summary>
        /// Team constructor for creating team.
        /// </summary>
        /// <param name="teamScore"></param>
        /// <param name="teamName"></param>
        public Team(int teamScore, string teamName)
        {
            TeamScore = teamScore;
            TeamName = teamName;
        }

        /// <summary>
        /// Method for accessing strings of team score and team name.
        /// </summary>
        /// <returns>String values for team score and team name</returns>
        public override string ToString()
        {
            return $"{TeamScore}, {TeamName}";
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
