using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class Exam
    {
        public Dictionary<Question, string> Questions { get; set; }
        public int Grade { get; set; }
        public int totalMark = 0;
        public Exam(Dictionary<Question, string> _questions)
        {
            Questions = _questions;
            Grade = 0;
        }
        public virtual void showExam()
        {
            Console.WriteLine("============================== START EXAM ==============================");
            Console.WriteLine();
            string answer;
            bool flag = true;
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Key);
                if (question.Key.GetType().ToString() == "Exam_Project.TrueOrFalseQuestion")
                {
                    do
                    {
                        Console.Write("Your Answer:");
                        answer = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if (answer == question.Value)
                        {
                            Grade += question.Key.Mark;
                        }
                        if (answer != "a" && answer != "b")
                        {
                            Console.WriteLine("InValid Choice !!");
                        }
                    } while (answer != "a" && answer != "b");
                }
                if (question.Key.GetType().ToString() == "Exam_Project.OneChoiceQuestion")
                {
                    do
                    {
                        Console.Write("Your Answer: ");
                        answer = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if (answer == question.Value)
                        {
                            Grade += question.Key.Mark;
                            flag = false;
                            break;
                        }
                        if (answer == "a" || answer == "b" || answer == "c" || answer == "d")
                        {
                            flag = true ;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("InValid Choice !!");
                            flag = true;
                        }
                    } while (flag);
                }
                if (question.Key.GetType().ToString() == "Exam_Project.MultiChoicesQuestion")
                {
                    do
                    {
                        Console.Write("Your Answer: ");
                        answer = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine();
                        string[] userAnswer = answer.Split(",");
                        foreach (var letter in userAnswer)
                        {
                            if (letter == "a" || letter == "b" || letter == "c" || letter == "d") { flag = false; }
                            else { flag = true; break; }
                        }
                        if (flag) { Console.WriteLine("Enter Valid Choices !"); }

                        string[] valueAnswer = question.Value.Split(",");
                        bool trueAnswer = false;
                        if (userAnswer.Length == valueAnswer.Length)
                        {
                            for (int i = 0; i < userAnswer.Length; i++)
                            {
                                if (valueAnswer.Contains(userAnswer[i])) { trueAnswer = true; }
                                else { trueAnswer = false; break; }
                            }
                            if (trueAnswer) { Grade += question.Key.Mark; }
                        }
                    } while (flag);
                }
                totalMark += question.Key.Mark;
            }
        }
    }
}
