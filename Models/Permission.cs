using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTheDoor.Models
{
    class Permission
    {
        public string id;
        public string serviceId;
        public string roleId;
        public string identityId;

        public Permission(string serviceId, string roleId, string identityId)
        {
            this.serviceId = serviceId;
            this.roleId = roleId;
            this.identityId = identityId;
        }
    }
}
