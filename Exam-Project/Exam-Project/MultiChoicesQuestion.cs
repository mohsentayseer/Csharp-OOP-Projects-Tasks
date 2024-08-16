using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class MultiChoicesQuestion : Question
    {
        public MultiChoicesQuestion(string _body, string[] _choices) : base(_body, _choices)
        {
            Header = "Multi-Choice_Question";
            DescAnswer = "You can choose more of choice";
            Mark = 3;
        }
    }
}
