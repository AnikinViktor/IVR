using IVRClient.IVRServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVRClient.DataModel
{
    class Organization
    {
        public Organization(OrganizationContract group)
        {
            this.ID = group.ID;
            this.Name = group.Name;
        }

        public static List<Organization> Convert(OrganizationContract[] organizations)
        {
            List<Organization> result = new List<Organization>();
            for (int i = 0; i <= organizations.Length - 1; ++i)
            {
                result.Add(new Organization(organizations[i]));
            }
            return result;
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
