using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string _body, string[] _choices) : base(_body, _choices)
        {
            Header = "True Or False Question";
            DescAnswer = "You should choose (A for true) OR (B for false)";
            Mark = 1;

        }
    }
}
