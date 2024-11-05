public abstract class Person
{
    public string Name { get; }
    public int Age { get; }
    public Address Address { get; }

    protected Person(string name, int age, Address address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public abstract void ShowDetails();

    public virtual void Greet()
    {
        Console.WriteLine("Hello!");
    }
}
