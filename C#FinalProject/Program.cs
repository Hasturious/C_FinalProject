namespace C_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gonna start with recreating my Pseudo code and go from there

            //Define our memberlist
            List<Member> membersList = new List<Member>();

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
                                try
                                {
                                    Console.Write("Enter the name of the new member: ");
                                    string name = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(name))
                                    {
                                        throw new ArgumentException("Name cannot be null or empty.");
                                    }

                                    Console.Write("Create User ID");
                                    string ID = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(ID))
                                    {
                                        throw new ArgumentException("ID cannot be null or empty.");
                                    }


                                    Console.WriteLine("Enter Membership Plan. The peroid of time between payments. (Monthly/Annually): ");
                                    string membershipPlan = Console.ReadLine();
                                    if (membershipPlan != "Monthly" && membershipPlan != "Annually" || string.IsNullOrWhiteSpace(membershipPlan))
                                    {
                                        throw new ArgumentException("Membership plan must be of the two options.");
                                    }

                                    Member newMember = new Member(name, ID, membershipPlan);
                                    membersList.Add(newMember);
                                    /*
                                    Console.WriteLine("Enter Membership Type. We offer discounts to veterans and students. (Standard/Sepecial): ");
                                    string membershipType = Console.ReadLine();
                                    if (membershipType != "Standard" && membershipType != "Special" || string.IsNullOrWhiteSpace(membershipType))
                                    {
                                        throw new ArgumentException("Membership type must be of the two options.");
                                    }
                                    */

                                }

                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }
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
