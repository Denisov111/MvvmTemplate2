using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using MahApps.Metro.Controls.Dialogs;
using MvvmTemplate;

namespace MvvmTemplate.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        Main modelMain;
        bool leftFlyoutOpen = false;
        string appMode;

        private IDialogCoordinator dialogCoordinator;

        public override void InitializeViewModel()
        {
            modelMain = (Main)model;
            dialogCoordinator = ((Views.MainWindow)view).dialogCoordinator;
        }
    }
}
