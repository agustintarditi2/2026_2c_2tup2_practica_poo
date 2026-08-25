namespace practica1.Ej3;

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public string Explain()
    {
        return "Estoy explicando";
    }

    public override string Greet()
    {
        return $"Hola soy el profesor {Name}";
    }
}