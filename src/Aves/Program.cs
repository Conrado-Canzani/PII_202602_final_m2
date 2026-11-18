namespace Aves;

public class Program
{
    public static void Main()
    {
        List<Ave> aves = new List<Ave> { new Canario(), new Pinguino() };

        foreach (Ave ave in aves)
        {
            Console.WriteLine($"Tipo de ave: {ave.GetType().Name}");

            ave.Comer();
            if (ave is not Pinguino)
            {
                ave.Volar();
                ave.Cantar();
            }
        }
    }
}
