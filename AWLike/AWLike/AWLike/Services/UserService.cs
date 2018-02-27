﻿using AWLike.Config;
using AWLike.Models;
using AWLike.Utils.Mappers;
using ConnectionToApiToolbox.ApiConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AWLike.Services
{
    public static class UserService
    {

        public async static Task<ConnectedUser> Log(LoginUser user)
        {
            //log to service

            ApiConnector api = new ApiConnector(ConnectionConfig.APIUrlUserLog);
            //api.paramList.Add("Username", user.Username);
            //api.paramList.Add("Password", user.Password);
            var task = await api.PostJSON(user);
            ConnectedUser u = task.JSONToConnectedUser();

            return u;

            

        }

    }
}
