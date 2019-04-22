using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class DisplayHouseWordsVisitor : IVisitor
    {
        public void VisitGreyjoys(Greyjoy greyjoy)
        {
            Console.WriteLine("We Do Not Sow");
        }

        public void VisitLannisters(Lannister lannister)
        {
           Console.WriteLine("Hear Me Roar!");
        }

        public void VisitStarks(Stark stark)
        {
            Console.WriteLine("Winter is Coming");
        }
    }
}
