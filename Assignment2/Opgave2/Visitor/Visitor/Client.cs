using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Client
    {
        public static void BeforeVisitorAcceptance(List<IKingdom> families)
        {
            Console.WriteLine("Before visitor: \n");
            foreach (var family in families)
            {       
                family.HouseName();
                Console.WriteLine("\n");
            }
        }

        public static void CallAcceptVisitor(List<IKingdom> families, IVisitor visitor)
        {
            Console.WriteLine("After visitor: \n");
            foreach (var family in families)
            {               
                family.HouseName();
                family.Accept(visitor);
                Console.WriteLine("\n");
            }
        }
    }
}
