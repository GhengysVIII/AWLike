using AWLike.Models;
using AWLike.Models.GameObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Utils.Mappers
{
    public static class GameMappers
    {
        //JSON
        public static GameInfo JSONToGameInfo(this string json)
        {
            return JsonConvert.DeserializeObject<GameInfo>(json);
        }
    }
}
