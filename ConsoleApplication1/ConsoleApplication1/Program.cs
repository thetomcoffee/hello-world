using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            Console.Write("\r\nPlease type something in: ");
            string msg = Console.ReadLine();
            Console.WriteLine("\r\nThank you for typing.  At " 
                + DateTime.Now.ToShortDateString() + " " 
                + DateTime.Now.ToShortTimeString() + " you wrote: " + msg);
            Console.WriteLine("\r\nPress the return key to close this application.");
            msg = Console.ReadLine();
            //effectively pauses and ends the app.
        }
    }
}
