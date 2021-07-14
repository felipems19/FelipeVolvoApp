using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Authorization
{
    public class Scopes
    {

        public const string UserImpersonationScope = "user_impersonation";

        public static string[] All => typeof(Scopes)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
