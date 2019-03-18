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
        public Debt GetnewDebt;
        private Debtor currentDebtor;
        private ObservableCollection<Debt> _debts;
        private string _insertDebt;


        public DebtorLogViewModel(Debtor debtor)
        {
            _currentDebtor = debtor;
            _debts = new ObservableCollection<Debt>(_currentDebtor.debts);
        }

        #region Properties

        public string insertDebt
        {
            get { return _insertDebt;}
            set { SetProperty(ref _insertDebt, value); }
        }

        public ObservableCollection<Debt> Debts
        {
            get { return _debts; }
            set { SetProperty(ref _debts, value); }
        }

        public Debtor _currentDebtor
        {
            get { return currentDebtor; }
            set { SetProperty(ref currentDebtor, value); }
        }

        #endregion

        #region Functions
        private void AddValue()
        {
            Debt _debt = new Debt(Convert.ToDouble(_insertDebt), DateTime.Now);

        }

        #endregion

        #region Commands
        private ICommand _addValue;
        public ICommand AddValueCommand
        {
            get
            {
                return _addValue ?? (_addValue = new DelegateCommand(() =>
                {
                    if (int.TryParse(insertDebt, out int n))
                    {
                        GetnewDebt = new Debt(Convert.ToDouble(insertDebt), DateTime.Now);
                        _currentDebtor.addDebt(Convert.ToDouble(insertDebt));
                        Debts.Add(GetnewDebt);

                    }
                    else
                    {
                        MessageBox.Show("The value you inserted was not a number, try again");
                    }
                }));
            }
        }
        #endregion





    }
}