using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas3_Encapsulamento;

internal class Produto2
{
    private string _nome;
    private double _preco;
    private int _quantidade; /*Por convenção da linguagem quando trabalhamos com atributos private,começamos com _ e primeira letra 
                              minúscula*/

    public Produto2()
    {

    }

    public Produto2(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome()
    {
        return _nome;
    }/*Como os atributos estão private,eu preciso criar os métodos Get para poder acessar os mesmo na classe de execução*/

    public void SetNome(string nome)
    {
        if (nome != null & nome.Length > 1)
        {
            _nome = nome;


        }
        else
        {
            Console.WriteLine("Nome não pode ser nulo e precisa ter mais de um caractere.");

        }


    }
    /*Aqui eu uso o set quando eu quiser alterar algum atributo lá na classe de execução,posso também colocar validações*/


    public double GetPreco()
    {
        return _preco;

    }

    public int GetQuantidade()
    {

        return _quantidade;

    }
    /*Criando os gets para Preço e quantidade,mas sem os sets pq o controle eu quero fazer apenas pelos métodos adicionar 
     e remover produtos*/
    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;

    }

    public void AdicionarProdutos(int quantidade)
    {
        _quantidade += quantidade;

    }
    public void RemoverProdutos(int quantidadeRemovida)
    {
        _quantidade -= quantidadeRemovida;

    }

    public override string ToString()
    {
        return _nome
                + ",R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


    }
}
