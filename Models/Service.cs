using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTheDoor.Models
{
    class Service
    {

        public string id;
        public string name;
        public string url;

        public Service(string name, string url)
        {
            id = new Guid().ToString();
            this.name = name;
            this.url = url;
        }
    }
}
