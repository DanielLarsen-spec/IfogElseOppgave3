using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfogElseOppgave3
{
    internal class Oppgave3
    {
        public void Run()
        {
            int numb = 15;
            int numb2 = 15;
            int sum = numb += numb2;
            bool isEqual = true;

            if (sum == 30)
            {
                isEqual = true;
                Console.WriteLine("It is 30");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Is not 30");
            }



        }
    }
}
