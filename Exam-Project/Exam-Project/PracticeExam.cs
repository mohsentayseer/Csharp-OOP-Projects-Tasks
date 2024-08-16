using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class PracticeExam : Exam
    {
        public PracticeExam(Dictionary<Question, string> _questions) : base(_questions) { }
        public override void showExam()
        {
            base.showExam();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================== MODEL ANSWER ==============================");
            Console.WriteLine();
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Key);
                Console.WriteLine($"Right Answer : {question.Value}");
                Console.WriteLine();
            }
            if (Grade < (totalMark / 2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your Result : {Grade}/{totalMark}");
                Console.WriteLine("You Failed !!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your Result : {Grade}/{totalMark}");
                Console.WriteLine("You Passed !");
            }
        }
    }
}
