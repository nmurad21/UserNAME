using System;
using UserNAME.Models;

namespace UserNAME
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Murad", 20, "1234");
            Console.WriteLine(user1.Username, user1.Age, user1.Password);
            

        }
    }
}
