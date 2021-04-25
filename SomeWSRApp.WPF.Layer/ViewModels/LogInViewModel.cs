using SomeWSRApp.Domain.Layer.Queries;
using SomeWSRApp.Domain.Layer.Services;
using SomeWSRApp.WPF.Layer.Models;
using SomeWSRApp.WPF.Layer.Models.Queries;
using SomeWSRApp.WPF.Layer.Models.Services;
using SomeWSRApp.WPF.Layer.Views;
using SomeWSRApp.WPF.Layer.Views.Windows;
using System;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        #region Private Members
        private string _login;
        private string _password;

        private readonly IDialogService _dialogService;
        
        // Commands
        private RelayCommand _loginCommand;
        private RelayCommand _closeCommand;

        public LogInViewModel()
        {
            _dialogService = new DefaultDialogService();
        }

        #endregion

        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public RelayCommand LoginCommand =>
            _loginCommand ??= new RelayCommand(async obj =>
                {
                    //var user = await new UserAuthorizationQuery<DefaultAuthorizationService>(null).ExecuteAsync();
                    //switch (user.Role)
                    //{
                    //    case Domain.Layer.Entities.Role.Admin:
                    //        var adminWin = new CreateViewQuery<AdminWindow>().Execute();
                    //        adminWin.Show();
                    //        break;
                    //    case Domain.Layer.Entities.Role.Client:
                    //        var clientWin = new CreateViewQuery<ClientWindow>().Execute();
                    //        clientWin.Show();
                    //        break;
                    //    case Domain.Layer.Entities.Role.Manager:
                    //        var managerWin = new CreateViewQuery<ManagerWindow>().Execute();
                    //        managerWin.Show();
                    //        break;
                    //    default:
                    //        throw new ArgumentOutOfRangeException();
                    //}


                    var managerWin = new CreateViewQuery<ManagerWindow>().Execute();
                    managerWin.Show();

                    var loginWin    = new TakeViewByNameQuery("LoginWin").Execute();
                    loginWin.Close();
                }
            );

        public RelayCommand CloseCommand =>
            _closeCommand ??= new RelayCommand(o => 
                new TakeViewByNameQuery("LoginWin").Execute().Close());
    }
}