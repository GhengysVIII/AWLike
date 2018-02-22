using AWLike.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Services
{
    public static class UserService
    {

        public static ConnectedUser Log(LoginUser user)
        {
            //log to service
            
            return new ConnectedUser() { Id = 1, Username="Test", Email="test@test.com" };
        }

    }
}
