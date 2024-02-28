using System;

class SimpleUser
{
    private string username;
    private int age;

    // Parameterized constructor
    public SimpleUser(string name, int userAge)
    {
        username = name;
        age = userAge;
        Console.WriteLine($"User created: Username={username}, Age={age}");
    }

    // Method to greet the user
    public void GreetUser()
    {
        Console.WriteLine($"Hello, {username}! You are {age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of SimpleUser
        SimpleUser user = new SimpleUser("John", 25);

        // Greet the user
        user.GreetUser();
    }
}
