using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorAPI.Features
{
    public class OnlyServicesAuthorizationHandler : AuthorizationHandler<OnlyServicesRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyServicesRequirement requirement)
        {
            if (context.User.IsInRole(Roles.Service))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
