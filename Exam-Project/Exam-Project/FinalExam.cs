using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class FinalExam : Exam
    {
        public FinalExam(Dictionary<Question, string> _questions) : base(_questions)
        {

        }
        public override void showExam()
        {
            base.showExam();

            if (Grade < (totalMark / 2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("============================== FINAL GRADE ==============================");
                Console.WriteLine();
                Console.WriteLine($"Your Result : {Grade}/{totalMark}");
                Console.WriteLine("You Failed !!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("============================== FINAL GRADE ==============================");
                Console.WriteLine();
                Console.WriteLine($"Your Result : {Grade}/{totalMark}");
                Console.WriteLine("You Passed !");
            }
        }
    }
}
