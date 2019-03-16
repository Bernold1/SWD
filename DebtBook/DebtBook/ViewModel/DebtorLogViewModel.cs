using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DebtBook.Model;

namespace DebtBook.ViewModel
{
    public class DebtorLogViewModel : BindableBase
    {

        private Debtor currentDebtor;

        public DebtorLogViewModel()
        {
            
        }

        private ICommand _addValue;
        public ICommand AddValueCommand
        {
            get
            {
                return _addValue ?? (_addValue = new DelegateCommand(AddValue));
            }
        }

        private void AddValue()
        {
            
        }


    }
}
