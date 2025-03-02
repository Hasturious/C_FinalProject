using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    class StandardMember : Member
    {
        public StandardMember(string name, string id, string membershipPlan): base(name, id, membershipPlan)
        {
            MemberType = "Standard";
        }
    }
}
