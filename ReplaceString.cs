using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class ReplaceString
    {

        public static void ReadInput()
        {
            string template = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Please Enter your name");
            string userInput = Console.ReadLine();
            ReplaceWord(template, userInput);

        }

        private static void ReplaceWord(string template, string userInput)
        {
            string result = template.Replace("<<UserName>>", userInput);
            Console.WriteLine("After done Replace\t " + result);
        }
    }
}