using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    public interface IMembership
    {
        /// <summary>
        /// Changes the membership plan from monthly annually or vice versa
        /// </summary>
        /// <param name="newPlan"></param>
        void ChangeMembershipPlan(string newPlan);
    }
}
