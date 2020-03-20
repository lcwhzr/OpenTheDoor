using System;
using System.Linq;
using Core.Exceptions;

namespace Core.Models
{
    public class ScopeKeyService
    {
        /**
        *  Constants representing key for Scope model in Service model
        */
        public const string AUTHENTICATION_ACCESS = "authentication_access";
        public const string ALL_ACCESS = "all_access";

        public static string[] ScopeKeys = { AUTHENTICATION_ACCESS, ALL_ACCESS };

        public static void KeyInScopeKeys(Scope scope)
        {
            if (!ScopeKeys.Contains(scope.GetKey()))
            {
                throw new InvalidScopeServiceException(scope.GetKey());
            }
        }
    }
}
