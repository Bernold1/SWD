using System;
using Prism.Mvvm;

namespace DebtBook
{
    public class Debt:BindableBase
    {
        public double debtValue { get; set; }
        public DateTime _date { get; set; }

        public Debt(double _debtValue, DateTime dateOfDebt)
        {
            debtValue = _debtValue;
            _date = dateOfDebt;

        }

        #region Properties
        //public double _debtValue
        //{
        //    get { return debtValue; }
        //    set {
        //        if (value != debtValue)
        //        {
        //            SetProperty(ref debtValue, value);
        //        }
        //    }
        //}
        #endregion


    }
}