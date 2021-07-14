using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Options
{
    public class AuthenticationOptions
    {
        public string Authority { get; set; }
        public string AuthorizationUrl { get; set; }
        public string ClientId { get; set; }
        public string ApplicationIdUri { get; set; }
    }
}
