using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Genericoo
{
    class input
    {

        public void enter() {


            WriteLine("Welcome to the generic program. Please enter a number.");
            string input = ReadLine();

            int p = Convert.ToInt32(input);

            
            ui<int> ui = new ui<int>(p);
            ui.welcome();
            Console.ReadLine();


        }

    }
}
