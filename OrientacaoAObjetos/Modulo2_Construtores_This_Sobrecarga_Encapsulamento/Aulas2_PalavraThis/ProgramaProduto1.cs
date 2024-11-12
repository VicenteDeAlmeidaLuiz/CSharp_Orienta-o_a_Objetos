using OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula3_SegundoProblema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aula2_PalavraThis;

internal class ProgramaProduto2
{
    static void Main(string[] args)
    {

        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Produto1 produto = new Produto1(nome, preco); /*Aqui é onde utilizamos o construtor*/
        Produto1 produto1 = new Produto1(); /*Aqui instanciamos sem parâmetros devido a termos um construtor sem parâmetros*/
        /*Sintaxe alternativa para inicialização de valores,mesmo não tendo nenhum construtor*/
        Produto1 produto2 = new Produto1 { Nome = "TV", Preco = 500.00, Quantidade = 10 };
        Console.WriteLine(produto2);

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + produto);
        Console.WriteLine();
        Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
        int quantidadeAd = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(quantidadeAd);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);
        Console.WriteLine();
        Console.Write("Digite o número de produtos a serem removidos no estoque:");
        int quantidadeRemovidos = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(quantidadeRemovidos);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);



    }
}

