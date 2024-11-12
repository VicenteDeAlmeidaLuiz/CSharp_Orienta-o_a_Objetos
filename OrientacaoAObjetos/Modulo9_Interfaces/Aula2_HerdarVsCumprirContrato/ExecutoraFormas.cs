using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Entidades;
using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.EntidadesFormas;
using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Enums;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato;

internal class ExecutoraFormas
{
    static void Main(string[] args)
    {
        IForma circulo = new Circuloo() { Raio = 2.0, Cor = Corr.Branco };
        IForma retangulo = new Retanguloo() { Largura = 3.5, Altura = 4.2, Cor = Corr.Preto };
        Console.WriteLine(circulo);
        Console.WriteLine(retangulo);



    }
}
