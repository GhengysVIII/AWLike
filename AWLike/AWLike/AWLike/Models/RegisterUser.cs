using AWLike.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Models 
{
    public class RegisterUser : IBaseUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
    }
}
