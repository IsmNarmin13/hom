using System;

try
{
    User validUser = new User("John Doe", "john.doe@example.com", "Password123");
    validUser.ShowInfo();

    User invalidUser = new User("Jane Doe", "jane.doe@example.com", "invalid");
}
catch (IncorrectPasswordException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}