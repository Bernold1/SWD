using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DebtBook
{
    public class Debtor
    {
        private string name;
        private decimal debt;


        public Debtor(string _name, decimal _debt)
        {
            name = _name;
            debt = _debt;
        }

        #region GetAndSetters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Debt
        {
            get { return debt;}
            set { debt = value; }
        }


        #endregion


    }
}