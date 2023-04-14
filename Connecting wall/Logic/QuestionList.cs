using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecting_wall.Logic
{
    public static class QuestionList
    {
        private static List<Question> _round1 = new List<Question>();
        private static List<Question> _round2 = new List<Question>();
        private static List<Question> _round3A = new List<Question>();
        private static List<Question> _round3B = new List<Question>();

        public static IReadOnlyCollection<Question> Round1
        {
            get { return _round1; }
        }

        public static IReadOnlyCollection<Question> Round2
        {
            get { return _round2; }
        }

        public static IReadOnlyCollection<Question> Round3A
        {
            get { return _round3A; }
        }
        public static IReadOnlyCollection<Question> Round3B
        {
            get { return _round3B; }
        }

        //This will be eddited later on
        public static void SetUpQuestions1()
        {
            _round1.Add(new Question(new List<string> { "Brian Jones", "Jimi Hendrix", "Jordan Cross", "Kurt Kobain" }, new List<string>
            { "founder and original leader of the rolling stones(1942 - 1969)", "Considered one of the greatest Guitarists. (1942 - 1970)", 
                "Target on the video game “Hitman” on the level “club 27”. Killed on his 27th birthday","Started the idea of 27 club. Killed himself. (1967 - 1994)" },
                "27 club. Died at the age of 27.", QuestionType.Normal));

            _round1.Add(new Question(new List<string> { "Perfect bowling game", "Partridge", "Chinese zodiac signs", "eggs" }, new List<string>
            { "12 strikes", "Partridge in a pear tree - 12 days of Christmas","12 Chinese zodiac signs","a dozen eggs" },
                "12", QuestionType.Normal));

            _round1.Add(new Question(new List<string> { "Miscommunication", "Tragedy", "Resurrection", "The Chosen One" }, new List<string>
            { "When characters miscommunicate to create conflict.", "Having a character experience a tragic event.",
                "Bringing a character back from the dead.","Having the protagonist be the chosen important one." },
                "Common story writing tropes.", QuestionType.Normal));

            _round1.Add(new Question(new List<string> { "Lol", "Cod", "Csgo", "Gta" }, new List<string>
            { "League of Legends", "Call of duty","Counter Strike Global Offensive","Grand theft auto" },
                "Video game acronyms", QuestionType.Normal));

        //These are special rounds, but for now act if they are normal
            _round1.Add(new Question(new List<string> { "world", "magnitude", "soda", "balloon" }, new List<string>
            { "Pop Goes the World - Men Without Hats", "Magnitude - community “Pop Pop”","Soda pop","Balloon" },
                "Pop", QuestionType.Image));

            _round1.Add(new Question(new List<string> { "thunderstruck", "gospeltruth", "greasedlightning", "thunder" }, new List<string>
            { "Thunderstruck - AC/DC", "Gospel Truth - Hercules (talks about Zeus who can throw thunderbolts)",
                "Greased Lightning’ - John Travolta","Thunder - Imagine Dragons" },
               "Songs about thunder/lightning", QuestionType.Audio));

        }

        public static void SetUpQuestions2()
        {
            _round2.Add(new Question(new List<string> { "Eleven", "One hundred", "One hundred and One", "One hundred and ten" }, new List<string>
            { "11 = 3", "100 = 4","101 = 5","110 = 6" },
                "Binary adding one", QuestionType.Normal));

            _round2.Add(new Question(new List<string> { "Delaware", "Florida", "Georgia", "Hawaii" }, new List<string>
            { "8th", "9th","10th","11th" },
                "U.S. States in alphabetical order", QuestionType.Normal));

            _round2.Add(new Question(new List<string> { "Stone", "Secrets", "Azkaban", "Fire" }, new List<string>
            { "Harry Potter and the Philosopher's Stone", "Harry Potter and the Chamber of Secrets",
                "Harry Potter and the Prisoner of Azkaban","Harry Potter and the Goblet of Fire" },
                "Last words of Harry Potter titles ", QuestionType.Normal));

            _round2.Add(new Question(new List<string> { "Revenge of the Sith", "Solo", "Rouge One", "A New Hope" }, new List<string>
            { "3rd", "4th","5th","6th" },
                "Starwar Movies in timeline order ", QuestionType.Normal));

            _round2.Add(new Question(new List<string> { "Orange", "Yellow", "Green", "Blue" }, new List<string>
            { "2nd", "3rd","4th","5th" },
                "Order of the rainbow", QuestionType.Normal));

            _round2.Add(new Question(new List<string> { "rock", "paper", "scissors", "shoot" }, new List<string>
            { "Dwane “The Rock” Jhonson", "Paper Mario","Edward Scissor Hands","Shoot" },
                "Game of RPS", QuestionType.Image));
        }

        public static void SetUpQuestions3A()
        {
            _round3A.Add(new Question(new List<string> { "Hatch", "Fabio", "Cochran", "Boston Rob" }, new List<string>
            { "Richard Hatch - Season 1", "Jud “Fabio” Birza - Season 21","John Cochran - Season 26","Rob Marino - Season 22" },
                "Survivor Winners", QuestionType.Normal));

            _round3A.Add(new Question(new List<string> { "Wooden fence", "Barbed Wire", "Soccer Cleats", "Cactus " }, new List<string>
            { "Top of fence", "Covered in spikes","Spikes on the bottom","Covered in spikes" },
                "Things with spikes", QuestionType.Normal));

            _round3A.Add(new Question(new List<string> { "Quebec", "November", "Tango", "Foxtrot" }, new List<string>
            { "Q", "N","T","F" },
                "NATO / Phonetic Alphabet", QuestionType.Normal));

            _round3A.Add(new Question(new List<string> { "Feather", "Marker", "Brush", "Pencil" }, new List<string>
            { "People wrote with feather and ink.", "Markers are used to write for labels.",
                "Brush is used to write characters in different languages","One of the most popular writing tools today for everything" },
                "Writing Utensils.", QuestionType.Normal));
        }

        public static void SetUpQuestions3B()
        {
            _round3B.Add(new Question(new List<string> { "Apple", "Chipotle", "Dunkin Donuts", "KFC" }, new List<string>
            { "apple", "dried ripe jalapeño chili pepper","doughnut","C = Chicken" },
                "Companies with foods in their names", QuestionType.Normal));

            _round3B.Add(new Question(new List<string> { "Mourning", "Outing", "Meaning", "King" }, new List<string>
            { "Noun: the expression of deep sorrow for someone who has died", "Noun: trip taken for pleasure",
                "Noun: what is meant by a word, text, concept, or action","Noun: the male ruler of an independent state" },
                "Non-verbs ending in “ing” ", QuestionType.Normal));

            _round3B.Add(new Question(new List<string> { "Gypsy", "Myth", "Rhythm", "Fry" }, new List<string>
            { "Gypsy", "Myth","Rhythm","Fry" },
                "No vowels", QuestionType.Normal));

            _round3B.Add(new Question(new List<string> { "Torgue", "Blue Shell", "Creeper", "Red Barrels" }, new List<string>
            { "Weapons manufacturer in Borderlands. All their weapons shoot explosions.", "Mario kart- will blow up the player in first place",
                "Minecraft enemy that blows itself up as a form of attack","Most typical type of shootable explosion in video games." },
                "Things that go boom in video games", QuestionType.Normal));
        }

        public static Question GetRound1Question(int x)
        {
            if (x > 5 || x < 0)
                throw new Exception("Must be in range 0-5");
            return _round1[x];
        }
        public static Question GetRound2Question(int x)
        {
            if (x > 5 || x < 0)
                throw new Exception("Must be in range 0-5");
            return _round2[x];
        }

        public static bool CheckRound3AQuestions(string a,string b,string c,string d)
        {
            foreach (Question question in Round3A)
            {
                bool isTrue = question.CheckItems(a,b,c,d);
                if (isTrue == true)
                    return true;
            }
            return false;
        }

        public static bool CheckRound3BQuestions(string a, string b, string c, string d)
        {
            foreach (Question question in Round3B)
            {
                bool isTrue = question.CheckItems(a, b, c, d);
                if (isTrue == true)
                    return true;
            }
            return false;
        }

        public static void SetUpAllQuestions()
        {
            SetUpQuestions1();
            SetUpQuestions2();
            SetUpQuestions3A();
            SetUpQuestions3B();
        }

    }
}
