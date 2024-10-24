namespace V43_grupp_uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User admin = new User(true); 
            User user = new User(false);

            if (admin.IsAdmin == true)
            {
                Admin();
            }
            else
            {
                Användare();
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
