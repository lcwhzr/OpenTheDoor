using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTheDoor.Models
{
    class Role
    {
        public string id;
        public string name;
        public string key;

        public Role(string name, string key)
        {
            id = new Guid().ToString();
            this.name = name;
            this.key = key;
        }
    }
}
