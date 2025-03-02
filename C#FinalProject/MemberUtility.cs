using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FinalProject
{
    public class MemberUtility
    {
        //Define our memberlist
        private List<Member> membersList = new List<Member>();

        public void AddMember()
        {
            try
            {
                Console.Write("Enter the name of the new member: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                Console.Write("Create User ID: ");
                string ID = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ID))
                {
                    throw new ArgumentException("ID cannot be null or empty.");
                }

                Console.Write("Enter Membership Plan (Monthly/Annually): ");
                string membershipPlan = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(membershipPlan) || (membershipPlan != "Monthly" && membershipPlan != "Annually"))
                {
                    throw new ArgumentException("Membership plan must be 'Monthly' or 'Annually'.");
                }

                Console.Write("Enter Membership Type (Standard/Special): ");
                string membershipType = Console.ReadLine();
                if (membershipType != "Standard" && membershipType != "Special")
                {
                    throw new ArgumentException("Membership type must be 'Standard' or 'Special'.");
                }

                // Create member based on type
                Member newMember = (membershipType == "Standard")
                    ? new StandardMember(name, ID, membershipPlan)
                    : new SpecialMember(name, ID, membershipPlan);

                membersList.Add(newMember);
                Console.WriteLine("Member added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
