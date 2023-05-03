using System;

class Program
{
    static void Main(string[] args)
    {
        // Object or instance of the class. The word "new" means to create a new object from the class.
        var ryan = new Person("Ryan", "Reynolds");
        var austin = new Person("Austin", "Judkins");

        austin.Talk();
        ryan.Talk();
    }
}

// Classification
class Person {

// Here we want to define behaviors and attributes

//Attributes or properties
string firstName;
string lastName;

// Constructor 
public Person(string fn, string ln){
    firstName = fn;
    lastName = ln;
}

//Behaviors or methods
public void Breathe(){
Console.WriteLine("Breathing");
}

public void Walk(){
Console.WriteLine("Walking");
}

public void Talk(){
Console.WriteLine($"Hi! My name is {FullName()}.");
}

public string FullName(){
    string full = string.Concat(firstName, lastName);
    return full;
}
}