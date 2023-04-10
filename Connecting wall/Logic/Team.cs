using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connecting_wall.Logic
{
    public class Team : INotifyPropertyChanged
    {
        private int _teamScore;
        private string _teamName;
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
                    throw new Exception("Team score cannot be blank");
                _teamName = value;
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
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
