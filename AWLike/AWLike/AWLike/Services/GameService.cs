using AWLike.Config;
using AWLike.Models;
using AWLike.Models.GameObjects;
using AWLike.Utils.Mappers;
using ConnectionToApiToolbox.ApiConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AWLike.Services
{
    public static class GameService
    {

        public async static Task<List<GameInfo>> GetAllAvailable()
        {
            //log to service

            ApiConnector api = new ApiConnector(ConnectionConfig.APIUrlGameGetAllAvailable);
            //api.paramList.Add("Username", user.Username);
            //api.paramList.Add("Password", user.Password);
            var Json = await api.GetJSON();
            //var valueSet = JsonConvert.DeserializeObject(Json).ValueSet;
            List<GameInfo> u = JsonConvert.DeserializeObject<List<GameInfo>>(Json);
            return u;            

        }

    }
}
