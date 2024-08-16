using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public static class Repo
    {
        public static Dictionary<Question, string> questions = new Dictionary<Question, string>();
        static Repo()
        {
            questions.Add(new TrueOrFalseQuestion("Can birds fly ?", ["A.true", "B.false"]), "a");
            questions.Add(new TrueOrFalseQuestion("Is HTML a backend Language ?",["A.true", "B.false"]), "b");
            questions.Add(new OneChoiceQuestion("What is the color of the sea ?",["A.Red", "B.Blue", "C.Green", "D.Black"]), "b");
            questions.Add(new OneChoiceQuestion("What is the color of the Grass ?",["A.Red", "B.Blue", "C.Green", "D.Black"]), "c");
            questions.Add(new MultiChoicesQuestion("Which of these are Cites in Europe ? ",["A.Spain", "B.Brazil", "C.France", "D.England"]), "a,c,d");
        }
        public static Exam PracticeExam
        {

            get
            {
                return new PracticeExam(questions);
            }
        }
        public static Exam FinalExam
        {
            get
            {
                return new FinalExam(questions);
            }
        }
    }
}
