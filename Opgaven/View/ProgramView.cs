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

            
            Console.WriteLine("Is there a goal");
            var goal = Console.ReadLine();

            var foodball = new Football();

            
            Football foodball2 = foodball;

            var result = foodball2.WeCheerIfGoalOrPasses(goal, passes);
            Console.ReadKey();
        }
    }
}
