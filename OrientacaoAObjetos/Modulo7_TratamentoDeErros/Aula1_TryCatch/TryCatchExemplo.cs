namespace OrientacaoAObjetos.Modulo7_TratamentoDeErros.Aula1_TryCatch
{
    internal class TryCatchExemplo
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());/*Nas variáveis se eu digitar uma letra vai lançar a excessão FormatException */
                int n2 = int.Parse(Console.ReadLine());
                int resultado = n1 / n2; /*Aqui se ue fizer qualquer divisão por 0 vai lançar a excessão DivideByZeroException*/
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não pode dividir por zero!!");

            }
            catch (FormatException)
            {
                Console.WriteLine("Não é permitido digitar letras,somente números.");

            }



        }
    }
}
