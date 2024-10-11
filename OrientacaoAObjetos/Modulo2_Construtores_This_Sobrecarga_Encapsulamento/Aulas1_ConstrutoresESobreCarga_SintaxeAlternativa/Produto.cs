//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aula1_Construtores;

//internal class Produto1
//{
//    public string Nome;
//    public double Preco;
//    public int Quantidade;

//    /*Posso colocar també um construtor padrão e nesse caso ficamos com 3 construtores e isso chamamos de sobrecarga.Nesse caso
//     podemos instanciar um produto sem passar argumentos*/

//    public Produto1() {
    
//    }

//    public Produto1(string nome, double preco, int quantidade) {

//        Nome = nome;
//        Preco = preco;
//        Quantidade = quantidade;
    
//    }/*Aqui é o construtor.Ele é uma operação que tem o mesmo nome da classe,podemos definir ele com e sem parâmetros.Se eu informar
//      parâmetros no construtor (como nesse caso) na hora de instanciar eu preciso informar os parâmetros,atribuindo-os aos atributos*/
//    public Produto1(String nome , double preco) {
//        Nome = nome;
//        Preco = preco;
//        Quantidade = 5;
    
    
//    }/*Aqui um segundo construtor,porém recebendo somente o nome e o preço.A quantidade vamos receber com valor zero por questões 
//      de didática,mas não é necessário pq o valor zero em int já é iniciado por padrão,mas iniciamos com 5*/

//    public double ValorTotalEmEstoque()
//    {
//        return Preco * Quantidade;

//    }

//    public void AdicionarProdutos(int quantidade)
//    {
//        Quantidade += quantidade;

//    }
//    public void RemoverProdutos(int quantidadeRemovida)
//    {
//        Quantidade -= quantidadeRemovida;

//    }

//    public override string ToString() {
//        return Nome
//                + ",R$"
//                + Preco.ToString("F2", CultureInfo.InvariantCulture)
//                + ", "
//                + Quantidade
//                + " unidades, Total: R$"
//                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
    
    
//    }
//}
