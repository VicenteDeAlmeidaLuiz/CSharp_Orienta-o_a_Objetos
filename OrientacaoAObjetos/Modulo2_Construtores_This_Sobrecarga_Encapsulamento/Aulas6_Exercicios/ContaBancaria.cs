﻿//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrientacaoAObjetos.Modulo2_Construtores_This_Sobrecarga_Encapsulamento.Aulas6_Exercicios;

//internal class ContaBancaria
//{
//    public int NumeroConta { get; private set; }
//    public string Titular { get; set; }
//    public double Saldo { get; private set; }


//    public ContaBancaria(int numeroConta, string titular)
//    {
//        NumeroConta = numeroConta;
//        Titular = titular;
//    }

//    public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
//    {
//        Deposito(depositoInicial);

//    }

//    public void Deposito(double quantia)
//    {

//        Saldo += quantia;


//    }

//    public void Saque(double quantia)
//    {
//        Saldo -= quantia + 5.0;

//    }

//    public override string ToString()
//    {
//        return "Dados da Conta: \n"
//            + "Conta: "
//            + NumeroConta
//            + " ,Tiutlar: "
//            + Titular
//            + " ,Saldo: R$ "
//            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

//    }



//}
