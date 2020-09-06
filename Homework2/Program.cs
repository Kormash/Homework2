using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.BishBosh();
        }

        void TempCheck()
        {
            //Ta 3 temperaturer och svara vilken är högst.
        }

        void Print100()
        {
            //Printa alla tal 1 - 100, [] runt jämna tal.
        }

        void MultiTable()
        {
            //Printa ett grid med Multiplkationstabellen
        }

        void BishBosh()
        {
            //Räkna från 1 till <User input>
            //Hämta två tal, "Bish" och "Bosh"
            //Printa alla tal, "Bish" om Delbart med Bish, "Bosh" om Bosh och "Bish-Bosh" om båda

            Console.WriteLine("How high do we count?");
            int countTo = int.Parse(Console.ReadLine());
            Console.WriteLine("What is Bish?");
            int bish = int.Parse(Console.ReadLine());
            Console.WriteLine("What is Bosh?");
            int bosh = int.Parse(Console.ReadLine());
            Console.WriteLine("____________________");

            for(int i = 1; i <= countTo; i++)
            {
                if(i%bish == 0 && i%bosh == 0)
                {
                    Console.WriteLine("Bish-Bosh");
                }
                else if(i%bish == 0)
                {
                    Console.WriteLine("Bish");
                }
                else if(i%bosh == 0)
                {
                    Console.WriteLine("Bosh");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
