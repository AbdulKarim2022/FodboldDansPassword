using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpgaveBibliotek;

namespace Opgaven
{
    public class DanceView
    {
        private Dance _dance;

        public DanceView()
        {
            _dance = new Dance();

            String name;
            int score = 0;

            bool isValid = false;

            Console.Clear();

            Console.WriteLine("First contestant name: ");
            name = Console.ReadLine();

            GetDanseObject(ref score, ref isValid);
            Dance dancer1 = new Dance(name, score);

            isValid = false;

            Console.WriteLine("\nSecond contestant name: ");
            name = Console.ReadLine();

            GetDanseObject(ref score, ref isValid);
            Dance dancer2 = new Dance(name, score);

            Dance dancer3 = dancer1 + dancer2;

            Console.WriteLine(dancer3.name + ": " + dancer3.score);

            Console.ReadKey();
        }

        private static void GetDanseObject(ref int score, ref bool isValid)
        {
            while (!isValid)
            {
                Console.WriteLine("Second contestant score: ");
                isValid = Int32.TryParse(Console.ReadLine(), out score);
            }
        }
    }
}