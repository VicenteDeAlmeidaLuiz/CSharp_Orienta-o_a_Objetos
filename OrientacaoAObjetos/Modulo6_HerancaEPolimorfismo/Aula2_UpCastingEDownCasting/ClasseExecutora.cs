using OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula2_UpCastingEDownCasting.Entidades;
using System;
using System.Collections.Generic;
namespace OrientacaoAObjetos.Modulo6_HerancaEPolimorfismo.Aula2_UpCastingEDownCasting
{
    internal class ClasseExecutora
    {
        static void Main(string[] args)
        {
            Conta1 conta1 = new Conta1(1001, "Alex", 0.0);
            ContaEmpresa1 conta1Emp = new ContaEmpresa1(1002, "Maria", 0.0, 500);

            //UPCASTING - Conversão da subclasse para superclasse

            Conta1 conta1Upcasting = conta1Emp;
            Conta1 conta2Upcasting = new ContaEmpresa1(1003, "Bob", 0.0, 200);
            Conta1 conta3Upcasting = new ContaPoupanca1(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING - Conversão da superclasse para subclasse

            ContaEmpresa1 conta1Downcasting = (ContaEmpresa1)conta2Upcasting;
            conta1Downcasting.Emprestimo(100.0);

            //ContaEmpresa1 conta2Downcasting = (ContaEmpresa1)conta3Upcasting; /*Aqui compila,mas gera exception em tempo de execução
            //Para não gerar a exceeption eu testo com a palvra is.is significa "se for uma instância"*/

            if (conta3Upcasting is ContaEmpresa1)
            {

                ContaEmpresa1 conta2Downcasting = (ContaEmpresa1)conta3Upcasting; /*Aqui é falso,pois não é uma instância,porém complia sem exception*/
                conta2Downcasting.Emprestimo(200.0);
                Console.WriteLine("Empréstimo");


            }




        }
    }
}
