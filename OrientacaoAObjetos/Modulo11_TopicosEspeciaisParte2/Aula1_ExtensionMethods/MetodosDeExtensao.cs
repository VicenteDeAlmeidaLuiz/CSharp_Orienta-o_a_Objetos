namespace OrientacaoAObjetos.Modulo11_TopicosEspeciaisParte2.Aula1_ExtensionMethods;
using OrientacaoAObjetos.Modulo11_TopicosEspeciaisParte2.Extensoes;

internal class MetodosDeExtensao
{
    /*São métodos que estendem a funcionalidade de um tipo,sem precisar alterar o código fonte desse tipo e nem herdar desse tipo
     Como fazer?
    1 - Criar uma classe estática
    2 - Na classe criar um método estático
    3 - O primeiro parâmetro do método deverá ter o prefixo this,seguido da declaração de um parâmetro do tipo que se deseja estender.Esta será
    uma referência para o próprio objeto*/

    public static void Main()
    {
        DateTime dt = new DateTime(2018, 12, 16, 8, 10, 45);
        Console.WriteLine(dt.TempoPercorrido());


    }
}
