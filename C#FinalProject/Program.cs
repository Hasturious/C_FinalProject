namespace C_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gonna start with recreating my Pseudo code and go from there


            //
            MemberUtility memberUtility = new MemberUtility();

            string menuChoice = "0";

            while (menuChoice != "5")
            {
                Console.Write("Please choose an option:\r\n1. Add Member\r\n2. Remove Member\r\n3. Display All Members\r\n4. Edit Membership Status\r\n5. Exit\r\n");
                menuChoice = Console.ReadLine();

                try
                {
                    if (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4" && menuChoice != "5")
                    {
                        throw new ArgumentException("Invalid input. Only numbers 1-5 are allowed.");
                    }

                    switch (menuChoice)
                    {
                        
                        case "1":
                            {
                                /*try
                                {

                                    Console.Write("Enter the name of the new member: ");
                                    string name = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(name))
                                    {
                                        throw new ArgumentException("Name cannot be null or empty.");
                                    }

                                    Console.Write("\nCreate User ID: ");
                                    string ID = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(ID))
                                    {
                                        throw new ArgumentException("ID cannot be null or empty.");
                                    }


                                    Console.Write("\nEnter Membership Plan. The peroid of time between payments. (Monthly/Annually): ");
                                    string membershipPlan = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(membershipPlan) || membershipPlan != "Monthly" && membershipPlan != "Annually")
                                    {
                                        throw new ArgumentException("Membership plan must be of the two options.");
                                    }

                                    
                                    Console.Write("\nEnter Membership Type. We offer discounts to veterans and students. (Standard/Special): ");
                                    string membershipType = Console.ReadLine();
                                    if (membershipType != "Standard" && membershipType != "Special" || string.IsNullOrWhiteSpace(membershipType))
                                    {
                                        throw new ArgumentException("Membership type must be of the two options.");
                                    }

                                    if (membershipType == "Standard")
                                    {
                                        StandardMember newStandardMember = new StandardMember(name, ID, membershipPlan);
                                        membersList.Add(newStandardMember);
                                    }

                                    if (membershipType == "Special")
                                    {
                                        SpecialMember newSpecialMember = new SpecialMember(name, ID, membershipPlan);
                                        membersList.Add(newSpecialMember);
                                    }

                                }

                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }*/
                                memberUtility.AddMember();
                                break;
                            }
                        
                        case "2":
                            {
                                /*try
                                {
                                    Console.Write("Enter User ID to remove them from system: ");
                                    string removeID = Console.ReadLine();

                                    //Find member from list
                                    
                                    Member removedMember = null;

                                    foreach (Member member in membersList)
                                    {
                                        if (member.ID == removeID)
                                        {
                                            removedMember = member;
                                            break;
                                        }
                                    }

                                    if (removedMember == null)
                                    {
                                        Console.WriteLine("No member found with that ID.");
                                    }

                                    else
                                    {
                                        membersList.Remove(removedMember);
                                        Console.WriteLine($"Member {removedMember.Name} (ID: {removedMember.ID}) has been removed.");
                                    }
                                    
                                }
                                catch (ArgumentException ex)
                                {

                                }*/
                                memberUtility.RemoveMember();
                                break;
                            }
                            
                        case "3":
                            {
                                /*if (membersList.Count == 0)
                                {
                                    Console.WriteLine("No members found.");
                                }
                                else
                                {
                                    Console.WriteLine("List of Members:");
                                    foreach (Member member in membersList)
                                    {
                                        Console.WriteLine(member); // Calls ToString() automatically
                                    }
                                }*/
                                memberUtility.DisplayMembers();
                                break;
                            }
                        case "4":
                            {
                                memberUtility.ChangeMembershipPlan();   
                                break;
                            }
                            
                        case "5":
                            {
                                Console.WriteLine("Closing Program");
                                break;
                            }
                    }
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
