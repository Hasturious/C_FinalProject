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
                                memberUtility.AddMember();
                                break;
                            }
                        
                        case "2":
                            {
                                memberUtility.RemoveMember();
                                break;
                            }
                            
                        case "3":
                            {

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
