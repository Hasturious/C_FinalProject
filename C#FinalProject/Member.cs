using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    public abstract class Member : IMembership
    {
        protected string Name { get; set; }
        protected string ID { get; set; }
        protected string MembershipPlan { get; set; }

        //Standard or "Special
        protected string MemberType { get; set; }

        /// <summary>
        /// Constructor for name, id , and membershipPlan
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="membershipPlan"></param>
        public Member(string name, string id, string membershipPlan)
        {
            Name = name;
            ID = id;
            MembershipPlan = membershipPlan;
        }

        /// <summary>
        /// Interface usage to change the membership plan
        /// </summary>
        /// <param name="newPlan"></param>
        public void ChangeMembershipPlan(string newPlan)
        {
            if (newPlan == "Monthly" || newPlan == "Annually")
            {
                MembershipPlan = newPlan;
            }
            else
            {
                Console.WriteLine("Invalid membership plan.");
            }
        }

        /// <summary>
        /// The overide to write all members in the list
        /// </summary>
        /// <returns>All Member Types</returns>
        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}, Membership Plan: {MembershipPlan} Membership Type: {MemberType}";
        }
    }
}   
