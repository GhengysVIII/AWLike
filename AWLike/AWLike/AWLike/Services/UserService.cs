using AWLike.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Services
{
    static class UserService
    {

        public static UserConnected Log(LoginUser user)
        {
            //log to service
            
            return new UserConnected() { Id = 1, Username="Test", Email="test@test.com" };
        }

    }
}
