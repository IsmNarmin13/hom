using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class IncorrectPasswordException : Exeption
    {
        public IncorrectPasswordException(string message) : base(message)
        {
        }
    }
}
