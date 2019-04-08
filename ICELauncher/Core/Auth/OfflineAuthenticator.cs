using System;
using ICELauncher.Core.Net.MojangApi.Api;

namespace ICELauncher.Core.Auth
{
    public static class OfflineAuthenticator
    {
        public static Tuple<string, Uuid> DoAuthenticate(string displayname)
        {
            Uuid uuid = new Uuid()
            {
                PlayerName = displayname,
                Value = Guid.NewGuid().ToString("N")
            };

            string accessToken = Guid.NewGuid().ToString("N");

            return new Tuple<string, Uuid>(accessToken, uuid);
        }
    }
}
