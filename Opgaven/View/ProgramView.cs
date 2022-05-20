using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpgaveBibliotek;

namespace Opgaven.View
{
    internal class ProgramView
    {
        public ProgramView()
        {
            //Hvad er defineret her? Snak med din side mand.
        }

        internal void RunFootBall()
        {
            Console.WriteLine("How many passes");
            bool succes = Int32.TryParse(Console.ReadLine(), out int passes);

            if (!succes)
            {
                Console.WriteLine("You did it wrong. Try again");
                return;
            }

            //Denne del er ikke implementeret i klassen Football
            Console.WriteLine("Is there a goal");
            var goal = Console.ReadLine();

            var foodball = new Class1();

            // Hvis du forstår hvad er sker her, så er du godt med på at forstå hvordan du arbejder med objekter.
            Class1 foodball2 = foodball;

            var result = foodball2.WeCheerIfGoalOrPasses(goal, passes);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
