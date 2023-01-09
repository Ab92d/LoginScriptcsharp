namespace MyApplication
{
    class Program
    {
        

        static void Login()
        {
            string userName = "amy";
            string password = "123";
            Console.WriteLine("Enter username: ");
            string EnteredUsername = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string EnteredPassword = Console.ReadLine();
            
            

            if (EnteredUsername.ToLower().Equals(userName) && EnteredPassword.Equals(password))
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
        static void Main(string[] args)
        {
            Login();
        }
    }
}
