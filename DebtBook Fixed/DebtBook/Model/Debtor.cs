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
        private ObservableCollection<Debt> debts { get; set; }
        // private readonly Debt noDebt = new Debt(0, DateTime.Now);

        //public Debtor()
        //{
        //    name = null;
        //    debts = new ObservableCollection<Debt>();
        //}

        public Debtor(string _name)
        {
            name = _name;
            debts = new ObservableCollection<Debt>();
        }

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public ObservableCollection<Debt> CurrentDebt
        {
            get
            {
                //Vi skal finde en måde at sætte værdien til 0, hvis der ikke er nogen værdi
                    return debts;
            }
            set { debts = value; }
        }


        #endregion

        #region Functions
        public void addDebt(Debt _debt)
        {
            debts.Add(_debt);
        }

        public double TotalDebt()
        {
            double totalDebt = 0;
            foreach (Debt d in debts)
            {
                totalDebt += d._debtValue;
            }
            return totalDebt;
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