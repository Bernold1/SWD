using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace DebtBook
{
    public class Debtor:BindableBase
    {
        private string name;
        public ObservableCollection<Debt> debts;// { get; set; }

        private double _totalDebt = 0;
        // private readonly Debt noDebt = new Debt(0, DateTime.Now);

        //public Debtor()
        //{
        //    name = null;
        //    debts = new ObservableCollection<Debt>();
        //}

        public Debtor(string _name, double initialDebt)
        {
            name = _name;
            debts = new ObservableCollection<Debt>();
            if (initialDebt != 0)
            {
                addDebt(initialDebt);
            }
        }

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public double totalDebt
        {
            get { return _totalDebt;}
            set
            {
                    SetProperty(ref _totalDebt, value);
            }
        }

        #endregion

        #region Functions
        public void addDebt(double debt)
        {
            debts.Add(new Debt(debt, DateTime.Now));
            _totalDebt += debt;
        }
        ///<summary>
        /// 
        ///Shallow copies the Debtor user is trying to add or edit debt on
        ///</summary>
        /// <returns></returns>
        public Debtor Clone()
        {
            return this.MemberwiseClone() as Debtor;  
        }

        #endregion



    }
}