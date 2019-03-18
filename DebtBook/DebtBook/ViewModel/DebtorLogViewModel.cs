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
        public String CurrentDebtorName => _currentDebtor.Name;
        public ObservableCollection<Debt> _debts => _currentDebtor.debts;

        private Debtor currentDebtor;
        private string _insertDebt;
        private ObservableCollection<Debtor> _debtors;

        public DebtorLogViewModel(ObservableCollection<Debtor> debtors , Debtor debtor)
        {
            _currentDebtor = debtor;
            _debtors = debtors;
        }

        #region Properties

        public string insertDebt
        {
            get { return _insertDebt;}
            set { SetProperty(ref _insertDebt, value); }
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
            
            if (double.TryParse(insertDebt, out double num))
            {
                _debtors.Remove(_currentDebtor);
                _currentDebtor.addDebt(Convert.ToDouble(insertDebt));
                _debtors.Add(_currentDebtor);
            }
            else
            {
                MessageBox.Show("You inserted something that wasnt a number");
            }
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

        }


        #endregion


    }
}