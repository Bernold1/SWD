using System;
using Prism.Mvvm;

namespace DebtBook
{
    public class Debt:BindableBase
    {
        private double debtValue;
        public DateTime _date { get; set; }
        public double debtSize { get; set; }

        public Debt(double _debtValue, DateTime _date)
        {
            _debtValue = debtValue;
            _date = _date;
        }

        #region Properties
        public double _debtValue
        {
            get { return debtValue; }
            set {
                if (value != debtValue)
                {
                    SetProperty(ref debtValue, value);
                }
            }
        }
        #endregion


    }
}