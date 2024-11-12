using OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula2_RestricoesParaGenerics.Entidades;
using OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula2_RestricoesParaGenerics.Servicos;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula2_RestricoesParaGenerics;

internal class Executora
{
    static void Main(string[] args)
    {
        List<Produto> lista = new List<Produto>();

        Console.WriteLine("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            string[] vect = Console.ReadLine().Split(',');
            string nome = vect[0];
            double preco = double.Parse(vect[1], CultureInfo.InvariantCulture);
            lista.Add(new Produto(nome, preco));


        }
        CalculoServico calculoServico = new CalculoServico();

        Produto max = calculoServico.Max(lista);
        Console.WriteLine("Max: ");
        Console.WriteLine(max);



    }
}
