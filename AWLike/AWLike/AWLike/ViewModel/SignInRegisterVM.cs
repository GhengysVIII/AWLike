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
    

    public class SignInRegisterVM : Page
    {

        #region Props
        public LoginUser loginUser = new LoginUser();
        public RegisterUser registerUser = new RegisterUser();


        public String UsernameEntry { get; set; } = "Pamellino";
        public String EmailEntry { get; set; }
        public String PasswordEntry { get; set; } = "test123";
        public String PasswordConfirmEntry { get; set; }

        public ICommand LoginPageCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterPageCommand { get; set; }
        public ICommand RegisterCommand { get; set; }



        private readonly IPageChange _navigation;
        //TPage Callback;
        #endregion
        #region CTOR
        public SignInRegisterVM(IPageChange navigation)
        {
            _navigation = navigation;
            LoginPageCommand = new Command(async () => await LoadModalLoginPage());
            LoginCommand = new Command(() => LoginUser());
            RegisterPageCommand = new Command(async () => await LoadModalRegisterPage());
            RegisterCommand = new Command(async () => await new Task(() => RegisterUser()));
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
            loginUser.Username = UsernameEntry;
            loginUser.Password = PasswordEntry;

            ConnectedUser userConnected;
            userConnected = null;
            userConnected = UserService.Log(loginUser);
            //return (userConnected != null);
        }
        public void RegisterUser()
        {
            if (PasswordEntry != null && PasswordEntry == PasswordConfirmEntry)
            {
                ConnectedUser userConnected;
                userConnected = null;
                userConnected = UserService.Log(loginUser);
                //return (userConnected != null);
            }
        }


    }
}
