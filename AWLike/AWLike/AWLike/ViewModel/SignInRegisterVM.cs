using AWLike.Models;
using AWLike.Services;
using AWLike.Models.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AWLike.ViewModel
{
    

    public class SignInRegisterVM
    {

        #region Props
        public LoginUser LoginUser { get; set; } = new LoginUser() { Username="Pamellino" , Password="test123"};
        public RegisterUser registerUser { get; set; } = new RegisterUser();
        public ConnectedUser connectedUser { get; set; }


        //public String UsernameEntry { get; set; } = "Pamellino";
        //public String EmailEntry { get; set; }
        //public String PasswordEntry { get; set; } = "test123";
        //public String PasswordConfirmEntry { get; set; }

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
            LoginCommand = new Command(() => LogUser());
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

        public async Task LoadUserNavigationPage()
        {
            await _navigation.PushModal(new UserNavigationPage(connectedUser));

        }
        public async void LogUser()
        {
            //LoginUser.Username = UsernameEntry;
            //loginUser.Password = PasswordEntry;


            connectedUser = await UserService.Log(LoginUser);

            if (connectedUser != null) // user found in server, connect to UserNavigationPage
            {
                await LoadUserNavigationPage();
            }
            //await LoadUserNavigationPage();

            //return (userConnected != null);
        }
        public async void RegisterUser()
        {
            if (registerUser.Username != null && registerUser.Password == registerUser.ConfirmPassword)
            {
                connectedUser = await UserService.Log(LoginUser);
                
                //return (userConnected != null);
            }
        }


    }
}
