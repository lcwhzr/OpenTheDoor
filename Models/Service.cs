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
        public List<string> ipRange;

        public Service(string name, string url, List<string> ipRange)
        {
            id = new Guid().ToString();
            this.name = name;
            this.url = url;
            this.ipRange = ipRange;
        }
    }
}
