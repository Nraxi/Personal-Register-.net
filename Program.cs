namespace Personal_Register_.net
{
    internal class Program
    {
        private static List<string> users = new List<string>();
        static void Main()
        {
            while (true)
            {
                ShowUsers();
                AddUser();
            }
           
        }
        static void AddUser()
        {
            Console.WriteLine("\nAdd user and their salary:");
            string input = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(input))
            {
                users.Add(input);
                Console.WriteLine($"\nUser & salary: {input} was added\n");
            }
            else
            {
                Console.WriteLine("try again\n");
            }

           
            
        }
        static void ShowUsers()
        {
            Console.WriteLine("----");
            Console.WriteLine("Press enter to add a user & their salary, Press ctrl + c to end app.");
            Console.WriteLine("You can not add an empty user btw.");
            Console.WriteLine("----");
            Console.WriteLine("Userslist:");

            foreach (var user in users)
            {
                Console.WriteLine(user);
               
            }

            if (users.Count > 0) {
                Console.WriteLine();
                Console.WriteLine("----");
            }
        }
    }
   

}   