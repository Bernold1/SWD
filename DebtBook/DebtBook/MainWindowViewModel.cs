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

namespace DebtBook
{
    public class MainWindowViewModel : BindableBase
    {
        private int currentIndex = -1;
        private ObservableCollection<Debtor> DebtorInsertion;
        private Debtor currentDebtor = null;


        public MainWindowViewModel()
        {
            DebtorInsertion = new ObservableCollection<Debtor>()
            {
                new Debtor("James", 199.2m),
                new Debtor("John", 10.5m)
            };
            CurrentDebtor = DebtorInsertion[0];

        }

        #region Getters and seters

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

        #region Delegate Commands

        private ICommand _addCommand;
        //Manger men indeholder "Skabelonen" til det!
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new DelegateCommand(() =>
                {
                    //Vi skal finde ud af hvordan vi laver et nyt vindue!!
                    //AllAgents.Add(new Agent());
                    //CurrentIndex = AllAgents.Count - 1;
                }));
            }
        }


        private ICommand _deleteCommand;
        //Skal nok laves om...
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

        private ICommand _addDebtCommand;


        public ICommand AddDebtCommand
        {
            get { throw new NotImplementedException(); }
        }




        #endregion

    }

}