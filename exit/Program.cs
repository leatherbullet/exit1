using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string exitWord = "exit";
            bool cycleWork = true;

            while(cycleWork == true)
            {
                Console.WriteLine("для выхода введите exit");
                string userInput = Console.ReadLine();

                if (exitWord == userInput) 
                {
                   cycleWork = false;
                }
            }

        }

    }
}
