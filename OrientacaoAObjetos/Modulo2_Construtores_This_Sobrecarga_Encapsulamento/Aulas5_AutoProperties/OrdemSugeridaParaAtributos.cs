using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas5_AutoProperties;

internal class OrdemSugeridaParaAtributos
{

   /*1 - Atributos privados
     2 - Propriedades autoimplementadas
     3 - Construtores
     4 - Propriedades customizadas
     5 - Outros métodos da classe. Exemplo abaixo*/

    private string _nome;
    public double Preco { get; private set; }

    public OrdemSugeridaParaAtributos(string nome, double preco)
    {
        _nome = nome;
        Preco = preco;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;

            }

        }

    }
}
