using System;
using System.Collections.Generic;
using System.Text;

namespace UserNAME.Models
{
    class User
    {
        public string Username { get; set; }
        private int _age;
        private string pasvord;

        public int Age
        { 
            get 
            {
                return _age;
            } 
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Yas menfi ola bilmez");
                      _age = value;
                }
                else if (value>0)
                {
                    Console.WriteLine(value);
                }
                 _age = value;
            } 
        }
        public string Password 
        { 
            get 
            {
                return pasvord;
            } 
            set 
            {
                if (value=="")
                {
                    Console.WriteLine("Password bos ola bilmez");
                    pasvord =value;
                }
                else if (value.Length < 8)
                {
                    Console.WriteLine("Password 8 simvoldan kicik ola bilmez");
                    pasvord = value;
                }
                else if (value.Length > 8)
                {
                    Console.WriteLine(value);
                }
                pasvord = value;
            } 

        }
        public User(string username, int _age, string pasvord)
        {
            this.Username = username;
            this.Password = pasvord;
            this.Age = _age;
        }
    }
}
