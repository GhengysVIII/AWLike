using AWLike.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Models
{
    public class UserConnected : IBaseUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
