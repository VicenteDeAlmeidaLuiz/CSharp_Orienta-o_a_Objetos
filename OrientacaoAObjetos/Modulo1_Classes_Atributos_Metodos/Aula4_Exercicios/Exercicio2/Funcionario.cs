using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo1_Classes_Atributos_Metodos.Aula4_Exercicios.Exercicio2
{
    internal class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return  SalarioBruto - Imposto;
            
        }

        public void AumentarSalario(double porcentagem) {

            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + ", "
                + "R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
               


        }
    }
}
