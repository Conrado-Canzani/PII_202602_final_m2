namespace Aves;

public class Pinguino : IAnimal
{
    public string Nombre { get; }

    public Pinguino ()
    {
        this.Nombre = "Pinguino";
    }
    public virtual void Comer()
    {
        Console.WriteLine($"{this.Nombre} está comiendo.");
    }
}

