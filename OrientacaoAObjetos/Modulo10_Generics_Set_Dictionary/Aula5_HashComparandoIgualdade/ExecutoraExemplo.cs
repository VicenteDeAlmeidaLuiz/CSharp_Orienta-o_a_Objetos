using OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula5_HashComparandoIgualdade.Entidades;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula5_HashComparandoIgualdade;

internal class ExecutoraExemplo
{
    static void Main(string[] args)
    {

        HashSet<Produto> produto = new HashSet<Produto>();
        produto.Add(new Produto("TV", 900.00));
        produto.Add(new Produto("Notebook", 1200.00));

        HashSet<Ponto> ponto = new HashSet<Ponto>();
        ponto.Add(new Ponto(1, 10));
        ponto.Add(new Ponto(4, 20));

        Produto produto1 = new Produto("Notebook", 1200.00);
        Console.WriteLine(produto.Contains(produto1)); /*Aqui ele vai considerar os endereços de mémória (instanciação) e não os argumentos iguais
                                                        mas como eu criei os equals e hashcode lá na classe Produto ele vai considerar os atributos e não a 
                                                        instanciação*/

        Ponto ponto1 = new Ponto(4, 20);
        Console.WriteLine(ponto.Contains(ponto1));/*Aqui ele compara direto por conteúdo pq o tipo é struct*/




    }
}
