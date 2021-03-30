using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class ReplaceString
    }
        public static void ReadInput
        { 
    string template = "Hello <<Username>> ,How are you?";
    Console.WriteLine("please enter your name");
            string UserInput = Console.ReadLine();
    ReplaceWord(template, UserInput);
}       


    private void ReplaceWord(string template,string UserInput)
    
    {
        string result = template.Replace("<<username>>", UserInput);
        Console.WriteLine("after done replace" + result);
    }
}
