using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Greyjoy : IKingdom
    {
        public void HouseName()
        {
            Console.WriteLine("House Greyjoy:");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitGreyjoys(this);
        }
    }
}
