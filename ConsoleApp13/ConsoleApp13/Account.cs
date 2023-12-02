using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public abstract void ShowInfo();
    }
}
