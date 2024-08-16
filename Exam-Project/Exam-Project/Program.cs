namespace Exam_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exam? exam = null;
            string examType;
            do
            {
                Console.Write("Choose Your Exam Type (Practice / Final) : ");
                examType = Console.ReadLine().ToLower();
                if (examType == "practice") { exam = Repo.PracticeExam; }
                if (examType == "final") { exam = Repo.FinalExam; }
            } while (examType != "practice" && examType != "final");
            Console.WriteLine();
            exam.showExam();

            Console.ReadKey();
        }
    }
}
