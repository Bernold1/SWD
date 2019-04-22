using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Stark : IKingdom
    {
        public void HouseName()
        {
            Console.WriteLine("House Stark:");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitStarks(this);
        }
    }
}
