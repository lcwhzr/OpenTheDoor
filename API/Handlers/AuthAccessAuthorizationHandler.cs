using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Features
{
    public class AuthAccessAuthorizationHandler : AuthorizationHandler<AuthAccessRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthAccessRequirement requirement)
        {
            //if (context.User.IsInRole(Roles.all_access))
            //{
            //    context.Succeed(requirement);
            //}
            if (context.User.IsInRole(Roles.authentication_access))
            {
                context.Succeed(requirement);
            }
            
            return Task.CompletedTask;
        }
    }
}
