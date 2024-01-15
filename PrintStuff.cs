using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language; 

        //Constructor
        public PrintStuff ()
        {
            language = "EN";
        }
        public PrintStuff(string temp) 
        {
            language = temp;
        }

        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "DE")
            {
                System.Console.WriteLine("Hallo, " + n + "!");
            }
        }
        
        public void PrintName()
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, John or Jane Doe!");
            }

            if (language == "DE")
            {
                System.Console.WriteLine("Hallo, John or Jane Doe!");
            }
        }
    }
}
