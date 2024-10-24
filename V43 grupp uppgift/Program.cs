using System.ComponentModel.Design;
using System;
using System.Timers;
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
                        Användare(a);
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
            bool inloggad = true;
            while (inloggad)
            {
                Console.WriteLine("1 | Inställning");
                Console.WriteLine("2 | Lägg till användare");
                Console.WriteLine("3 | Avsluta");
                string val = Console.ReadLine();
                if (val == "1")
                {
                    Console.WriteLine("1 | Byt till slumpmässig textfärg");
                    Console.WriteLine("2 | Byt konsolfönstret namn");
                    string val2 = Console.ReadLine();
                    if (val2 == "1")
                    {
                        // Get all values of the ConsoleColor enum
                        Array colors = Enum.GetValues(typeof(ConsoleColor));

                        // Generate a random index
                        Random random = new Random();
                        ConsoleColor randomColor = (ConsoleColor)colors.GetValue(random.Next(colors.Length));

                        // Set the console text color to the randomly selected color
                        Console.ForegroundColor = randomColor;
                    }
                    else if (val2 == "2")
                    {
                        Console.Title = "Mamma mia";

                    }
                }
                else if (val == "2")
                {
                    Console.WriteLine("Lägg till användare");
                    Console.Write("\nAnvändare: ");
                    string användarenman = Console.ReadLine();
                    Console.Write("\nLössenord: ");
                    string lössenord = Console.ReadLine();
                    användare.Add(new User(användarenman, lössenord));
                }
                else if (val == "3")
                {
                    inloggad = false;
                }
            }
        }
        

    }
}
