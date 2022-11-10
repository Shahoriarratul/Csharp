using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Member
    {
        private string membershipId;
        private string Name { get; set; }
        private DateTime MembershipExpirationDate { get; set; }

       internal Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}
