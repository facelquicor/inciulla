using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new instance of the Person class
        Person person = new Person("John", "Doe");
        
        // Call the Introduce method on the person object
        person.Introduce();
    }
}
