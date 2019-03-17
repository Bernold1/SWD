using System;

namespace DebtBook
{
    public class Debt
    {
        private double debtValue;
        public DateTime date { get; set; }

        public Debt(double _debtValue, DateTime _date)
        {
            _debtValue = debtValue;
            date = _date;
        }

        #region Properties
        public double _debtValue
        {
            get { return debtValue; }
            set { debtValue = value; }
        }
        #endregion


    }
}