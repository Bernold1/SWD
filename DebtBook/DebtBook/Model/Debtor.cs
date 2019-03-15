using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DebtBook.Model
{
    public class Debtor
    {
        private string name;
        private ObservableCollection<Debt> debts { get; set; }



        public Debtor(string _name)
        {
            name = _name;
            debts = new ObservableCollection<Debt>();

        }

        #region GetAndSetters

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddDebt(Debt _debt)
        {
            debts.Add(_debt);
        }


        #endregion


    }
}