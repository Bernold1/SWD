using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    public class Debt
    {
        public double _debtvalue { get; set; }
        public DateTime _date { get; set; }

    
        public Debt(double debtvalue, DateTime date)
        {
            _debtvalue = debtvalue;
            _date = date;
        }
        
    }
}
