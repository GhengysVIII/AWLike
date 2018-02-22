using AWLike.Models;
using AWLike.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.ViewModel
{
    

    public class SignInRegisterVM
    {

        LoginUser loginUser = new LoginUser();
        
        public bool LoginUser(LoginUser loginUser)
        {
            ConnectedUser userConnected;
            userConnected = null;
            userConnected = UserService.Log(loginUser);
            return (userConnected != null);
        }
    }
}
