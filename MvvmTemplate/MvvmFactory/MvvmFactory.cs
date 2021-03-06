using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;

namespace MvvmTemplate
{
    class MvvmFactory
    {
        public static void CreateWindow(BaseModel model, BaseViewModel viewModel, IView view, ViewMode viewMode)
        {
            viewModel.SetModel(model, view);
            (view as MetroWindow).DataContext = viewModel;
            model.SendMessage += (object sender, string e) => view.OnSendMessage(e);
            if (viewMode == ViewMode.Show)
                view.Show();
            if (viewMode == ViewMode.ShowDialog)
                view.ShowDialog();
            model.Run();
        }

        public static void RegisterModel(BaseModel parentModel, BaseModel childModel)
        {
            childModel.viewModel = parentModel.viewModel;
        }
    }
}
