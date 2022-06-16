using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveBibliotek
{
    public class Dance
    {
        public string name;
        public int score;

        public Dance(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public static Dance operator +(Dance dancer1, Dance dancer2)
        {
            return new Dance(dancer1.name + " & " + dancer2.name, dancer1.score + dancer2.score);
        }
    }
}
