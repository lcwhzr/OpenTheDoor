using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTheDoor.Models
{
    class Identity
    {

        public string id;
        public string idToken;
        public List<Permission> permissions;

        public Identity()
        {
            id = new Guid().ToString();
            idToken = new Guid().ToString();
            permissions = new List<Permission>();
        }
    }
}
