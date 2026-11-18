namespace Aves;

public class Ave
{
    public string Nombre { get; }

    public Ave(string nombre)
    {
        this.Nombre = nombre;
    }

    public virtual void Comer()
    {
        Console.WriteLine($"{this.Nombre} está comiendo.");
    }

    public virtual void Volar()
    {
        Console.WriteLine($"{this.Nombre} está volando.");
    }

    public virtual void Cantar()
    {
        Console.WriteLine($"{this.Nombre} está cantando.");
    }
}
