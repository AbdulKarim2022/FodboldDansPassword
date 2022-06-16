using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpgaveBibliotek;
using System.IO;

namespace Opgaven
{
    public class DanceView
    {
        private Dance _dance;

        public DanceView()
        {
            String name;
            int score = 0;

            Console.Clear();

            Console.WriteLine("First contestant name: ");
            name = Console.ReadLine();
            Console.WriteLine("First contestant score: ");
            score = Int32.Parse(Console.ReadLine());
            
            Dance dancer1 = new Dance(name, score);

            

            Console.WriteLine("\nSecond contestant name: ");
            name = Console.ReadLine();
            Console.WriteLine("Second contestant score: ");
            score = Int32.Parse(Console.ReadLine());


            Dance dancer2 = new Dance(name, score);

            Dance dancer3 = dancer1 + dancer2;

            Console.WriteLine(dancer3.name + ": " + dancer3.score);

            Console.ReadKey();
        }



    }
}