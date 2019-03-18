using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace DebtBook.ViewModel
{
    class AddDebtorViewModel: BindableBase
    {
        private ObservableCollection<Debtor> _debtors;
        private string _name;
        private string newDebt;


        public AddDebtorViewModel(ObservableCollection<Debtor> debtors)
        {
            _debtors = debtors;
        }

        #region Properties

        public ObservableCollection<Debtor> debtors
        {
            get { return _debtors; }
            set { SetProperty(ref _debtors, value); }
        }

        public string _Name
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

        public string _NewDebt
        {
            get { return newDebt; }
            set { SetProperty(ref newDebt, value); }
        }
        #endregion

        #region Commands

        private ICommand _saveAddedDebtorCommand;

        public ICommand SaveCommand
        {
            get
            {
                return _saveAddedDebtorCommand ?? (_saveAddedDebtorCommand = new DelegateCommand(() =>
                {
                    if (int.TryParse(newDebt, out int n))
                    {
                        debtors.Add(new Debtor(_name, Convert.ToDouble(newDebt)));
                    }
                    else
                    {
                        MessageBox.Show("Error trying to add new debtor");
                    }
                }));
            }
        }
        #endregion

    }
}
