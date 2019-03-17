using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DebtBook.ViewModel
{
    class AddDebtorViewModel: BindableBase
    {
        private Debtor _currentDebtor;
        private ObservableCollection<Debtor> _debtors;
        private Debt _debt;
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    SetProperty(ref _name, value);
                }
            }
        }


        public AddDebtorViewModel(ObservableCollection<Debtor> debtors)
        {
            _debtors = debtors;
        }

        #region Properties
        public Debtor currentDebtor
        {
            get { return _currentDebtor; }
            set { SetProperty(ref _currentDebtor, value); }
        }

        public ObservableCollection<Debtor> debtors
        {
            get { return _debtors; }
            set { SetProperty(ref _debtors, value); }
        }

        public Debt debt
        {
            get { return _debt; }
            set { SetProperty(ref _debt, value); }
        }

        #endregion

        #region Commands

        private ICommand _saveDebtorCommand;

        public ICommand SaveDebtorCommand => _saveDebtorCommand ?? (_saveDebtorCommand =
                                                 new DelegateCommand(AddDebtor));
                                                    


        #endregion

        #region Functions

        private void AddDebtor()
        {
            currentDebtor = new Debtor(_name);
            currentDebtor.addDebt(debt);
            debtors.Add(currentDebtor);
            //RaisePropertyChanged("Count");
        }

        private bool AddDebtorCanExecute()
        {
            if (currentDebtor.Name != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
