namespace Aves;

public class Program
{
    public static void Main()
    {
        List<Ave> aves = new List<Ave> { new Canario(), new Pinguino() };

        foreach (Ave ave in aves)
        {
            ave.Comer();
            ave.Volar();
            ave.Cantar();
        }
    }
}
