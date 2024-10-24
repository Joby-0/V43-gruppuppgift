using System.ComponentModel.Design;

namespace V43_grupp_uppgift
{
    internal class Program
    {

        public static List<User> användare = new List<User> ();

        static void Main(string[] args)
        {
            
            User admin = new User(true, "Admin", "emma"); 
            User user = new User(false, "User", "lösen");

            användare.Add(admin);
            användare.Add(user);
            Console.WriteLine("Välkommen att logga in");
            Console.Write("Användarnamn: ");
            string användarnamn = Console.ReadLine();
            Console.Write("Lössenord: ");
            string lösenord = Console.ReadLine();
            
            
            foreach (User a in användare)
            {

                if (a.UserName == användarnamn && a.Password == lösenord)
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

        static void Användare(User användare)
        {
            bool inloggad = true;
            while (inloggad)
            {
                
                Console.WriteLine("Du är loggad");
                Console.WriteLine("1 | Visa lössenord");
                Console.WriteLine("2 | Avsluta");
                string val = Console.ReadLine();
                if (val == "1")
                {
                    Console.WriteLine("Ditt lössenord är: " + användare.Password);
                    Console.WriteLine("\n klicka på enter för att fortsätta...");
                    Console.ReadKey();
                }
                else if (val == "2")
                {
                    Console.Write("Du loggas ut");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    inloggad = false;
                    Console.Clear();
                }
            }

        }
        static void Admin()
        {

        }

    }
}
