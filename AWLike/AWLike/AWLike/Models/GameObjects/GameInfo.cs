using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Models.GameObjects
{
    class GameInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MapID  { get; set; }
        public List<ConnectedUser> Ref_UserList { get; set; }
        public ConnectedUser Ref_UserTurn { get; set; }
    }
}
