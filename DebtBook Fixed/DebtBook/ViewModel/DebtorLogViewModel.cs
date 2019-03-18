using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DebtBook.ViewModel
{
    public class DebtorLogViewModel:BindableBase
    {
        
        private Debtor currentDebtor;
        private string _insertDebt;
        private ObservableCollection<Debtor> _debtors;

        public DebtorLogViewModel(ObservableCollection<Debtor> debtors , Debtor debtor)
        {
            _currentDebtor = debtor;
           // _debts = new ObservableCollection<Debt>(_currentDebtor.debts);
            _debtors = debtors;
        }

        #region Properties

        public String CurrentDebtorName => _currentDebtor.Name;
        public ObservableCollection<Debt> _debts => _currentDebtor.debts;
        public string insertDebt
        {
            get { return _insertDebt;}
            set { SetProperty(ref _insertDebt, value); }
        }

        //public ObservableCollection<Debt> Debts
        //{
        //    get { return _debts; }
        //    set { SetProperty(ref _debts, value); }
        //}

        public Debtor _currentDebtor
        {
            get { return currentDebtor; }
            set { SetProperty(ref currentDebtor, value); }
        }
        public double Value { get; set; }
        #endregion

        #region Functions
        //private void AddValue()
        //{
        //    Debt _debt = new Debt(Convert.ToDouble(_insertDebt), DateTime.Now);

        //}
        private void AddValue()
        {
            _debtors.Remove(_currentDebtor);
            _currentDebtor.addDebt(Value);
            _debtors.Add(_currentDebtor);
        }

        #endregion

        #region Commands
        private ICommand _addValue;
        public ICommand AddValueCommand
        {

            get
            {
                return _addValue ?? (_addValue =
                           new DelegateCommand(AddValue));
            }

            //get
            //{
            //    return _addValue ?? (_addValue = new DelegateCommand(() =>
            //    {
            //        if (int.TryParse(insertDebt, out int n))
            //        {

            //           // Debts.Add(new Debt(Convert.ToDouble(insertDebt),DateTime.Now));
            //            //Sidder fast her
            //        }
            //        else
            //        {
            //            MessageBox.Show("The value you inserted was not a number, try again");
            //        }
            //    }));
            //}

        }
        #endregion





    }
}