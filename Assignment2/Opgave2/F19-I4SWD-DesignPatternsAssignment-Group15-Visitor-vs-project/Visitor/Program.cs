using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IKingdom> kingdoms = new List<IKingdom>
            {
                new Greyjoy(),
                new Lannister(),
                new Stark()
            };
            Client.BeforeVisitorAcceptance(kingdoms);
            Console.WriteLine();

            var visitor1 = new DisplayHouseWordsVisitor();
            Client.CallAcceptVisitor(kingdoms,visitor1);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
