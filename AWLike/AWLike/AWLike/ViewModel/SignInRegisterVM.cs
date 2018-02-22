using AWLike.Models;
using AWLike.Services;
using AWLike.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace AWLike.ViewModel
{
    

    public class SignInRegisterVM
    {
        LoginUser loginUser = new LoginUser();

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        private readonly IPageChange _navigation;
        //TPage Callback;

        #region CTOR
        public SignInRegisterVM(IPageChange navigation)
        {
            _navigation = navigation;
            LoginCommand = new Command(async () => await LoadModalLoginPage());
            RegisterCommand = new Command(async () => await LoadModalRegisterPage());
            //if (LoginCommand.CanExecute(null))
            //{
            //     LoginCommand.Execute(null);
            //}

        }

        #endregion

        public async Task LoadModalLoginPage()
        {
            await _navigation.PushModal(new LoginPage());

        }

        public async Task LoadModalRegisterPage()
        {
            await _navigation.PushModal(new RegisterPage());

        }
        public void LoginUser()
        {
            ConnectedUser userConnected;
            userConnected = null;
            userConnected = UserService.Log(loginUser);
            //return (userConnected != null);
        }

    }
}
