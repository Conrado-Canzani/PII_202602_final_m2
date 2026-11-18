namespace Aves;

public class Program
{
    public static void Main()
    {
        Canario canario = new Canario();
        Pinguino pinguino = new Pinguino();

        List<Ave> aves = new List<Ave> { canario, pinguino };
        List<Ave> avesVoladoras = new List<Ave> { canario };
        List<Ave> avesCantoras = new List<Ave> { canario };

        foreach (Ave ave in aves)
        {
            ave.Comer();
        }

        foreach (Ave volador in avesVoladoras)
        {
            volador.Volar();
        }

        foreach (Ave cantor in avesCantoras)
        {
            cantor.Cantar();
        }
    }
}
