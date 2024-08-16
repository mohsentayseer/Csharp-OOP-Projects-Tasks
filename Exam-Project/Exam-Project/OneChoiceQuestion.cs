using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class OneChoiceQuestion:Question
    {
        public OneChoiceQuestion(string _body, string[]_choices):base(_body,_choices)
        {
            Header = "One-Choice_Question";
            DescAnswer = "You should choose only one";
            Mark = 2;
        }
    }
}
