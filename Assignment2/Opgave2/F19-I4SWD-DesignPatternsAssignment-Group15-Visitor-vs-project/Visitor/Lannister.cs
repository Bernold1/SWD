using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Lannister : IKingdom
    {
        public void HouseName()
        {
            Console.WriteLine("House Lannister:");

        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLannisters(this);
        }
    }
}
