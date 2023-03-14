using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecting_wall.Logic
{
    public class Question
    {
        private List<string> _items = new List<string>();
        private List<string> _description = new List<string>();
        private string _connection;
        private QuestionType _type;

        public List<string> Item
        {
            get { return _items; }
            private set 
            {
                if (value.Count != 4)
                    throw new Exception("List must be 4 items");
                _items = value;
            }
        }
        public List<string> Description
        {
            get { return _description; }
            private set 
            {
                if (value.Count != 4)
                    throw new Exception("There must be 4 descriptions");
                _description = value; 
            }
        }

        public string Connection
        {
            get { return _connection; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Must have an input");
                _connection = value;
            }
        }

        public QuestionType Type
        {
            get { return _type; }
            private set
            {
                if (!Enum.IsDefined(typeof(QuestionType), value))
                    throw new Exception("Invalid Question Type");
                _type = value;
            }
        }

        public Question(List<string> items,List<string> description, string connection,QuestionType type) 
        {
            Item = items;
            Description = description;
            Connection = connection;
            Type = type;
        }


        //This is for the connecting wall. checks if four items are in a conection
        public bool CheckItems(string item1,string item2,string item3,string item4) 
        {
            if (!Item.Contains(item1))
            { return false; }
            if (!Item.Contains(item2))
            { return false; }
            if (!Item.Contains(item3))
            { return false; }
            if (!Item.Contains(item4)) 
            { return false; }
            return true;

        }
    }
}
