using OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula2_ComposicaoDeObjetos.Entidades.Enums;

namespace OrientacaoAObjetos.Modulo5_EnumeracaoEComposicao.Aula2_ComposicaoDeObjetos.Entidades;

internal class Trabalhador
{
    public string Nome { get; set; }
    public Nivel Senioridade { get; set; }
    public double BaseSalarial { get; set; }
    public Departamento Departamento { get; set; } /*Aqui é a associação*/
    public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>(); /*Aqui também é a associação.Como um trabalhador pode ter vários contratos,então
                                                       criamos a propriedade como lista.Já instanciamos para garantir que não seja nula.Essa associação
                                                       de um para muitos por via de regra não é inclusiva no construtor*/
    public Trabalhador()
    {

    }

    public Trabalhador(string nome, Nivel senioridade, double baseSalarial, Departamento departamento)
    {
        Nome = nome;
        Senioridade = senioridade;
        BaseSalarial = baseSalarial;
        Departamento = departamento;
    }

    public void AdicionarContrato(HoraContrato contrato)
    {

        Contratos.Add(contrato);

    }

    public void RemoverContrato(HoraContrato contrato)
    {
        Contratos.Remove(contrato);


    }

    public double GanhoTotal(int ano, int mes)
    {
        double soma = BaseSalarial;
        foreach (HoraContrato contrato in Contratos)
        {
            if (contrato.Data.Year == ano && contrato.Data.Month == mes)
            {

                soma += contrato.ValorTotal();

            }



        }
        return soma;


    }
}
