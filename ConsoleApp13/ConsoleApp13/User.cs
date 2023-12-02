using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    internal class User
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (!PasswordChecker(value))
                {
                    throw new IncorrectPasswordException("Password does not meet the criteria.");
                }
                _password = value;
            }
        }
        public User(string fullname, string email, string password)
        {
            Id = nextId++;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public override bool PasswordChecker(string password)
        {
            return password.Length >= 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
