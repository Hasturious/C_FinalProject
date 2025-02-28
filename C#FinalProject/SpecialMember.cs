using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    internal class SpecialMember : Member
    {
        public SpecialMember(string name, string id, string membershipPlan) : base(name, id, membershipPlan)
        {
            MemberType = "Special";
        }
    }
}
