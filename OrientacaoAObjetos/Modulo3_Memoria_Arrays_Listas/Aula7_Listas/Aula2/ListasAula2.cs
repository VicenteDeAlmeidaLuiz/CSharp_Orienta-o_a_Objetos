//using System;
//using System.Collections.Generic;


//namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula7_Listas.Aula2;

//internal class ListasAula2

//{
//    static void Main(string[] args)
//    {
//        List<string> lista = new List<string>();
//        /*Adicionando elementos na lista*/
//        lista.Add("Vicente");
//        lista.Add("Letícia");
//        lista.Add("Isolda");
//        lista.Add("Ana");
//        /*Adicionando elementos com insert,com insert eu consigo escolher qual a posição da lista*/
//        lista.Insert(2, "Aline");
//        lista.Insert(5, "Marcosssss");

//        foreach (string nome in lista)
//        {
//            Console.WriteLine(nome);

//        }

//        Console.WriteLine("Contagem da lista com count (Na contagem é normal,sem começar com zero)" + lista.Count);
//        string nome1 = lista.Find(x => x[0] == 'A'); /*O que está dentro dos parênteses chamamos de expressão lambda,vamos aprender isso mais tarde*/
//        Console.WriteLine("O primeiro A na lista de nomes é do nome " + nome1);
//        string nome2 = lista.FindLast(x => x[0] == 'A');
//        Console.WriteLine("O último A na lista de nomes é do nome " + nome2);
//        int posicao = lista.FindIndex(x => x[0] == 'A'); /*Como é posição a tipagem tem que ser int*/
//        Console.WriteLine("Primeira posição começando com A " + posicao);
//        int posicao2 = lista.FindLastIndex(x => x[0] == 'A');
//        Console.WriteLine("Última posição começando com A " + posicao2);

//        List<string> lista2 = lista.FindAll(x => x.Length == 7);/*Filtrando a lista para pegar somente ceracteres com tamanho sete*/
//        foreach (string nome in lista2)
//        {
//            Console.WriteLine(nome);
//        }

//        Console.WriteLine("________________________________________");

//        lista.Remove("Marcosssss"); /*Removendo itens da lista*/
//        foreach (string nome in lista)
//        {
//            Console.WriteLine(nome);
//        }
//        Console.WriteLine("________________________________________");
//        lista.RemoveAll(x => x[0] == 'A'); /*Remover todo mundo que começa com a letra A,se eu passar algo que não existe ele não faz nada*/
//        foreach (string nome in lista)
//        {
//            Console.WriteLine(nome);
//        }

//        Console.WriteLine("________________________________________");

//        lista.RemoveAt(0); /*Removendo itens da lista por posição*/
//        foreach (string nome in lista)
//        {
//            Console.WriteLine(nome);
//        }

//        List<string> listaa = new List<string>();
//        listaa.Add("Murilo");
//        listaa.Add("Marcelo");
//        listaa.Add("Roberto");
//        listaa.Add("Paula");
//        listaa.Add("Márcia");
//        listaa.Add("Ana");
//        listaa.Add("Mariana");
//        listaa.Add("Marina");

//        Console.WriteLine("________________________________________");

//        /*Usando o range para remover de um index até outro,nesse caso a partir do index 2 remover cinco ítens da lista
//         Especificamente, a partir do índice 2 (que é “Roberto”), serão removidos cinco itens. Portanto, “Roberto”, “Paula”, “Márcia”, “Ana” 
//        e “Mariana” serão removidos da lista.*/
//        listaa.RemoveRange(2, 5);
//        foreach (string nome in listaa)
//        {
//            Console.WriteLine(nome);

//        }






//    }



//}
