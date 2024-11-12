namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula1_Comparison;

internal class Programa
{
    static void Main(string[] args)
    {
        List<Produto> lista = new List<Produto>();
        lista.Add(new Produto("TV", 900.00));
        lista.Add(new Produto("Notebook", 1900.00));
        lista.Add(new Produto("Tablet", 500.00));
        Comparison<Produto> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());/*Aqui é a expressão lambda*/
        lista.Sort(comp); /*Ordena a lista mas somente se implementa IComparable*/
        foreach (Produto produto in lista)
        {
            Console.WriteLine(produto);

        }


    }


}
