using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml.Serialization;
using DebtBook.ViewModel;

namespace DebtBook
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly INavigationService _iNavigationService = new NavigationService();
        private int currentIndex = -1;
        private ObservableCollection<Debtor> DebtorInsertion;
        private Debtor currentDebtor = null;


        public MainWindowViewModel()
        {
            DebtorInsertion = new ObservableCollection<Debtor>()
            {
              new Debtor("James", 100),
              new Debtor("John", 0.50)
            };
            CurrentDebtor = null; 

        }
        #region Properties

        public Debtor CurrentDebtor
        {
            get { return currentDebtor; }
            set { SetProperty(ref currentDebtor, value); }
        }
        public ObservableCollection<Debtor> AllDebtors
        {
            get { return DebtorInsertion; }
            set { SetProperty(ref DebtorInsertion, value); }
        }

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
        }


        #endregion

        #region Commands

        private ICommand _AddDebtorCommand;
        public ICommand AddDebtorCommand
        {
            get
            {
                return _AddDebtorCommand ?? (_AddDebtorCommand = new DelegateCommand(() =>
                {
                    var vm = new AddDebtorViewModel(DebtorInsertion);
                    _iNavigationService.show(vm);
                }));
            }
        }

        private ICommand _editDebtCommand;

        public ICommand EditDebtCommand
        {
            get
            {
                return _editDebtCommand ?? (_editDebtCommand = new DelegateCommand(() =>
                {
                    var tempDebtor = currentDebtor.Clone();
                    var vm = new DebtorLogViewModel(DebtorInsertion, tempDebtor){//Vi skal måske have tilføjet noget med debts her
                                                                };

                    _iNavigationService.show(vm);
                },
                () => { return CurrentIndex >= 0; }
                ).ObservesProperty(()=> CurrentIndex));
            }
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand => _deleteCommand ?? (_deleteCommand =
                                             new DelegateCommand(DeleteExecute, DeleteCanExecute).ObservesProperty(() => CurrentIndex));


        private void DeleteExecute()
        {
            DebtorInsertion.RemoveAt(currentIndex);
            RaisePropertyChanged("Count");
        }

        private bool DeleteCanExecute()
        {
            if (AllDebtors.Count > 0 && currentIndex >= 0)
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