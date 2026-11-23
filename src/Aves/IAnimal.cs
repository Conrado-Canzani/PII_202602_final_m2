namespace Aves;

public interface IAnimal
{
    public string Nombre { get; }

    public virtual void Comer()
    {
        Console.WriteLine($"{this.Nombre} está comiendo.");
    }
}