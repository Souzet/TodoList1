using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration:
            string command;
            // Greetings:
            Console.WriteLine("Hello and welcome todo list");
            Console.WriteLine("To quit type 'quit', for help type 'help'");
            // REPl (do-while-loop)
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                //    Om commandot är load: läs filen
                if (command == "quit")
                {
                    Console.WriteLine("Bye!");
                }
                else
                {
                    Console.WriteLine("unknown command: {0}", command);
                }
            }
            while (command != "quit");
        }
    }
    
}
