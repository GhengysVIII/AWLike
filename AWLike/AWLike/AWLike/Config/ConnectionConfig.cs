using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Config
{
    public static class ConnectionConfig
    {

        private static string BaseAPIUrl { get; set; } = "http://10.10.2.102/api";
            private static string APIUrlUser { get; set; } = $"{BaseAPIUrl}/user";
                public static string APIUrlUserLog { get; private set; } = $"{APIUrlUser}/log";
                public static string APIUrlUserRegister { get; set; } = $"{APIUrlUser}/Register";
            private static string APIUrlGame { get; set; } = $"{BaseAPIUrl}/game";
                public static string APIUrlGameGetAllAvailable { get; set; } = $"{APIUrlGame}/getallavaillable";

    }
}
