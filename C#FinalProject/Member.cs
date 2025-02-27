using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    public abstract class Member
    {
        private string Name; { get; set; }
        private string ID; { get; set; }
        private string MembershipType; { get; set; }

        //Constructor for name, id , and membershipPlan
        public Member(string name, string id, string membershipPlan)
        {
            Name = name;
            ID = id;
            MembershipType = membershipPlan;
        }

    }
}
