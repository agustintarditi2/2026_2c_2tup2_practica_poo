namespace practica1.Ej3;

public class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public string Study()
    {
        return "Estoy estudiando";
    }

    public string ShowAge()
    {
        return $"Mi edad es: {age} años";
    }

    public override string Greet()
    {
        return $"Hola soy el estudiante {Name}";
    }
}