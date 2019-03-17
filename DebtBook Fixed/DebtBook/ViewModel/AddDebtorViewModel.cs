using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DebtBook.ViewModel
{
    class AddDebtorViewModel: BindableBase
    {
        private Debtor _currentDebtor;
        private string _title;

        public AddDebtorViewModel(Debtor debtor, string title)
        {
            Title = title;
            currentDebtor = debtor;
        }

        #region Properties
        public Debtor currentDebtor
        {
            get { return _currentDebtor; }
            set { SetProperty(ref _currentDebtor, value); }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        #endregion

        #region Commands

        

        #endregion

    }
}
