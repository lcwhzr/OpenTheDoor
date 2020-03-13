using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Features
{
    public static class Policies
    {
        //public const string OnlyEmployees = nameof(OnlyEmployees);
        public const string authentication_access = nameof(authentication_access);
        public const string all_access = nameof(all_access);
        //public const string OnlyThirdParties = nameof(OnlyThirdParties);
    }
}
