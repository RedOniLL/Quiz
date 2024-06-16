using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public string Text {  get; set; }

        public string Answer { get; set; }

        public string[] Wrongs { get; set; }

        public bool Status { get; set; }

        public string givenAnswer { get; set; }

        public Question() { givenAnswer = "None"; }
    }
}
