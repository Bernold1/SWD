using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitor
    {
        void VisitStarks(Stark stark);
        void VisitLannisters(Lannister lannister);
        void VisitGreyjoys(Greyjoy greyjoy);
    }
}
