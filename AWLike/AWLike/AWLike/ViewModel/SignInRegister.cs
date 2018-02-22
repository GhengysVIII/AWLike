using AWLike.Models;
using AWLike.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.ViewModel
{
    

    public class SignInRegister
    {
        UserConnected userConnected;
        public UserConnected LoginUser(LoginUser loginUser)
        {
            return Login(loginUser);
        }
    }
}
