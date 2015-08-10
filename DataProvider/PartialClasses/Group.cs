using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    [DataContract]
    public partial class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
