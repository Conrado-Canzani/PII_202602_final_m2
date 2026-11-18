namespace Aves;

public class Pinguino : Ave
{
    public Pinguino() : base("Pingüino") { }

    public override void Volar()
    {
        throw new NotSupportedException("El pingüino no puede volar.");
    }

    public override void Cantar()
    {
        throw new NotSupportedException("El pingüino no puede cantar.");
    }
}
