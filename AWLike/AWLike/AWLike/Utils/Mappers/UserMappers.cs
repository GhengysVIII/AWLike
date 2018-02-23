using AWLike.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Utils.Mappers
{
    public static class UserMappers
    {
        //JSON
        public static ConnectedUser JSONToConnectedUser(this string json)
        {
            return JsonConvert.DeserializeObject<ConnectedUser>(json);
        }
    }
}
