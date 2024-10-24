using System.ComponentModel.Design;

namespace V43_grupp_uppgift
{
    internal class Program
    {
        public static List<User> användare = new List<User> ();
        static void Main(string[] args)
        {

            User admin = new User(true); 
            User user = new User(false);
            användare.Add(admin);
            användare.Add(user);
            Console.WriteLine("Välkommen att logga in");
            Console.Write("Användarnamn: ");
            string användarnamn = Console.ReadLine();
            Console.Write("Lössenord: ");
            string lösenord = Console.ReadLine();
            
            
            foreach (User a in användare)
            {
                if (a.IsAdmin)
                {
                    if (admin.IsAdmin == true)
                    {
                        Admin();
                    }
                    else
                    {
                        Användare();
                    }
                }
            }
        }

        static void Användare()
        {

        }
        static void Admin()
        {

        }

    }
}
