using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DebtBook
{
    class NavigationService : INavigationService
    {
        public void show(Object obj)
        {
            //Får objektets type
            Type t = obj.GetType();
            //Create new window
            Window window = null;
            //Switch case efter viewmodel klasserne
            switch (t.Name)
            {
                //ny vindue, viser vinduet og breaker
                case "AddDebtorViewModel":
                    window = new AddDebterView();
                    window.ShowDialog();
                        break;
                case "MainWindowViewModel":
                    window = new MainWindow();
                    window.ShowDialog();
                    break;
                case "DebterLogViewModel":
                    window = new MainWindow();
                    window.ShowDialog();
                    break;

            }
            
        }
    }
}
