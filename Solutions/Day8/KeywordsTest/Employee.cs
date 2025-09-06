namespace HR;

public class Employee
{

    public int id { get; set; }

    public string name { get; set; }

    public Employee(int id, string name)
    {

        id = id;
        name = name;
    }

//Object Oriented Programming
    //Encapsulation
    //Inheritance
    //Polymorphism
                //Overriding parent behavior in child class
    //Abstraction

    //Polymorphism
    //Change the default implementation of ToString method here in this Employee class
    public override string ToString()
    {
        return $"Employee class ToStrinng method: ID- {id},  Name- {name}";
    }
}