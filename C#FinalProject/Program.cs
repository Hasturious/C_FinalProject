namespace C_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gonna start with recreating my Pseudo code and go from there

            //Define our memberlist
            List<Member> members = new List<Member>();

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
                                    Console.Write("Enter the name of the new member");
                                    string name = Console.ReadLine();
                                    if (string.IsNullOrWhiteSpace(name))
                                    {
                                        throw new ArgumentException("Name cannot be null or empty.");
                                    }

                                    Console.Write("Enter the species of the lion: ");
                                    string species = Console.ReadLine();
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
