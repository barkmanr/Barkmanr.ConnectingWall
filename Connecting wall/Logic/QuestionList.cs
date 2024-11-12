using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Connecting_wall.Logic
{
    //I wan't to add 5th round; no vowels 
    //I wan't to add filess to be read

    public static class QuestionList
    {
        private static List<Question> _round1 = new List<Question>(); //find connection
        private static List<Question> _round2 = new List<Question>(); //find 4th item
        private static List<Question> _round3A = new List<Question>(); //Conection wall 1
        private static List<Question> _round3B = new List<Question>(); //Conecting wall 2

        // getting the questions
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

        public static string[] readfile (string filePath)
        {
              using (StreamReader file = new StreamReader(filePath))
                {
                string[] items = new string[10];
                    for (int i = 0; i < items.Length; i++)
                    {
                        items[i] = file.ReadLine();
                    }
                    return items;
                }
        }

                //Hard-codded
        public static void SetUpQuestions1()
        {
            string path = @"C:\Users\Ryan\Documents\Code Term 2\Connecting wall\Connecting wall\Resources\Questions\";
            string[] items = readfile(path + "QuOne1.txt");

            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9]) )) ;

            items = readfile(path + "QuOne2.txt");
            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9]) ));

            items = readfile(path + "QuOne3.txt");
            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuOne9.txt");
            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuOne5.txt");
            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuOne6.txt");
            _round1.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

        }

        public static void SetUpQuestions2()
        {
            string path = @"C:\Users\Ryan\Documents\Code Term 2\Connecting wall\Connecting wall\Resources\Questions\";
            string[] items = readfile(path + "QuTwo1.txt");

            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuTwo2.txt");
            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuTwo3.txt");
            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuTwo4.txt");
            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuTwo5.txt");
            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuTwo6.txt");
            _round2.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));
        }

        public static void SetUpQuestions3A()
        {
            string path = @"C:\Users\Ryan\Documents\Code Term 2\Connecting wall\Connecting wall\Resources\Questions\";
            string[] items = readfile(path + "QuThree1.txt");

            _round3A.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree2.txt");
            _round3A.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree3.txt");
            _round3A.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree4.txt");
            _round3A.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));
        }

        public static void SetUpQuestions3B()
        {
            //  @"C:\Users\Ryan\Documents\Code Term 2\Connecting wall\"
            string solutionFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\"));

            string path = solutionFolder + @"\Resources\Questions\";
            string[] items = readfile(path + "QuThree5.txt");

            _round3B.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree6.txt");
            _round3B.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree7.txt");
            _round3B.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));

            items = readfile(path + "QuThree8.txt");
            _round3B.Add(new Question(new List<string> { items[0], items[1], items[2], items[3] },
             new List<string> { items[4], items[5], items[6], items[7] },
             items[8], (QuestionType)Int32.Parse(items[9])));
        }

        //get individual question
        public static Question GetRound1Question(int x)
        {
            if (x > 6 || x < 1)
                throw new Exception("Must be in range 0-5");
            return _round1[x - 1];
        }
        public static Question GetRound2Question(int x)
        {
            if (x > 6 || x < 1)
                throw new Exception("Must be in range 0-5");
            return _round2[x - 1];
        }

        //Conecting wall checker
        public static bool CheckRound3AQuestions(string a,string b,string c,string d)
        {
            foreach (Question question in Round3A)
            {
                bool isTrue = question.CheckItems(a,b,c,d);
                if (isTrue)
                    return true;
            }
            return false;
        }

        public static bool CheckRound3BQuestions(string a, string b, string c, string d)
        {
            foreach (Question question in Round3B)
            {
                bool isTrue = question.CheckItems(a, b, c, d);
                if (isTrue)
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
