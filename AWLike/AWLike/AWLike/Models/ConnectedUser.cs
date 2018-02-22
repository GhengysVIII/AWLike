using AWLike.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Models
{
    public class ConnectedUser : IBaseUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
