using OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.Enums;

namespace OrientacaoAObjetos.Modulo9_Interfaces.Aula2_HerdarVsCumprirContrato.EntidadesFormas;

internal abstract class AbstrataForma : IForma
{
    public Corr Cor { get; set; }

    public abstract double Area();
}
