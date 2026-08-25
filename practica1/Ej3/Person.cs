using System.Diagnostics;

namespace practica1.Ej3;

public class Person
{
    public string Name { get; set; }

    protected int age;

    public Person(string name)
    {
        Name = name;
    }

    public virtual string Greet()
    {
        return $"Hola soy {Name}";
    }
    
    public void SetAge(int age)
    {
        this.age = age;
    }
}