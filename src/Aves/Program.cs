namespace Aves;

public class Program
{
    public static void Main()
    {
        Canario canario = new Canario();
        Pinguino pinguino = new Pinguino();

        List<IAnimal> aves = new List<IAnimal> { canario, pinguino };
        List<Ave> avesVoladoras = new List<Ave> { canario };
        List<Ave> avesCantoras = new List<Ave> { canario };

        foreach (IAnimal ave in aves)
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
