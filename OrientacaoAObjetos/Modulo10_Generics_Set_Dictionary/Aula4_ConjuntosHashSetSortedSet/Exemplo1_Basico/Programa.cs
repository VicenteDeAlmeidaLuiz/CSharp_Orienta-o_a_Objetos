namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula4_ConjuntosHashSetSortedSet.Exemplo1_Basico;

internal class Programa
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");
        Console.WriteLine(set.Contains("Notebook")); /*Retorna true ou false,nesse caso true*/
        Console.WriteLine(set.Contains("Computador")); /*Retorna true ou false,nesse caso false*/
        Console.WriteLine("_______________________________");

        foreach (string p in set)
        {
            Console.WriteLine(p);

        }


    }
}
