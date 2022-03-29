using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp50
{
    internal class User
    {
        private static int _id;
        private string _password;
        public int Id { get; }
        public string Username { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                    _password = value;
            }
        }
        public Role Role { get; set; }

        public User(string username, string password, Role role)
        {
            _id++;
            Id = _id;
            Username = username;
            Password = password;
            Role = role;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Username: {Username} - Role: {Role}");
        }

        public static bool PasswordChecker(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                bool hasDigit = false;
                bool hasLower = false;
                bool hasUpper = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        hasDigit = true;

                    if (char.IsUpper(password[i]))
                        hasLower = true;

                    if (char.IsLower(password[i]))
                        hasUpper = true;

                    if (hasDigit && hasUpper && hasLower)
                        return true;
                }
            }

            return false;
        }
    }
}