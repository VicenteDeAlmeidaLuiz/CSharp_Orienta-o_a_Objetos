namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula4_ConjuntosHashSetSortedSet.Exemplo2_MaisElaborado
{
    internal class SortedSetPrograma
    {
        static void Main(string[] args)
        {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10, 11 };
            //ImprimeColecao(a);

            /*União de conjuntos*/
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); /*Aqui eu só acrescento os elementos de b que não tem em c pois o sortedset não aceita repetições e mantem a ordenação
                             dos elementos*/
            ImprimeColecao(c);
            Console.WriteLine();

            /*Intersecção dos conjuntos (elementos que constam nos dois conjuntos)*/
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            ImprimeColecao(d);
            Console.WriteLine();

            /*Diferença entre conjuntos,nesse caso os elementos que só estão em a*/
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            ImprimeColecao(e);





        }

        static void ImprimeColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write(obj + " ");


            }




        }

    }

}
