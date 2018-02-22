using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Models.Interfaces
{
    public interface IBaseUser
    {
        int Id { get; set; }
        string Username { get; set; }
        string Email { get; set; }
    }
}
