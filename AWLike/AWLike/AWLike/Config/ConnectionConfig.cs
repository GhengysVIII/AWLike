using System;
using System.Collections.Generic;
using System.Text;

namespace AWLike.Config
{
    public static class ConnectionConfig
    {

        private static string BaseAPIUrl { get; set; } = "http://localhost:62661/api";
            private static string APIUrlUser { get; set; } = $"{BaseAPIUrl}/user";
                public static string APIUrlUserLog { get; private set; } = $"{APIUrlUser}/log";
                private static string APIUrlUserRegister { get; set; } = $"{APIUrlUser}/Register";

    }
}
