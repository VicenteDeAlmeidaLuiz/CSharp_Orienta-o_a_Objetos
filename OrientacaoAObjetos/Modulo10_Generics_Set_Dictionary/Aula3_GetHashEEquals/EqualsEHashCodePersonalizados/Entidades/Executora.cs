using System.Threading.Channels;

namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula3_GetHashEEquals.EqualsEHashCodePersonalizados.Entidades;

internal class Executora
{
    static void Main()
    {
        Cliente cliente = new Cliente { Nome = "Marcelo", Email = "marcelo@gmail.com" };
        Cliente cliente1 = new Cliente { Nome = "Marcelo dos Santos", Email = "marcelo@gmail.com" };

        Console.WriteLine(cliente.Equals(cliente1)); /*True pq os dois tem email igual*/
        Console.WriteLine(cliente.GetHashCode());
        Console.WriteLine(cliente1.GetHashCode());
    }


}
