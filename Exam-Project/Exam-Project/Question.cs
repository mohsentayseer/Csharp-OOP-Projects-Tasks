using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    public class Question
    {
        public string Header { get; set; }
        public string DescAnswer {  get; set; }
        public string Body { get; set; }
        public string[] Choices { get; set; }
        public int Mark { get; set; }
        public Question( string _body, string[] _choices)
        {
            Body = _body;
            Choices = _choices;
        }
        public string showChoices(string[] _choices)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string choice in Choices)
            {
                sb.Append(choice);
                sb.Append("\n");
            }
            return sb.ToString();
}
        public override string ToString()
        {
            return $"{Header} Note: {DescAnswer} ({Mark}:Marks)\n----------------------------------------------------\n=> Q- {Body}\n{showChoices(Choices)}";
        }
    }
}
