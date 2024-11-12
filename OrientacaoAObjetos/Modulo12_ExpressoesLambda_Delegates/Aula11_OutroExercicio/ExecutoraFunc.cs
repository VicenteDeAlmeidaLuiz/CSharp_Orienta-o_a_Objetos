using OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula11_OutroExercicio.Entidades;
using System.Globalization;

namespace OrientacaoAObjetos.Modulo12_ExpressoesLambda_Delegates.Aula11_OutroExercicio;

internal class ExecutoraFunc
{
    static void Main(string[] args) {

        Console.WriteLine("Digie o caminho do arquivo: ");
        string caminhoArquivo = Console.ReadLine();
        Console.WriteLine("Digite o salário: ");
        double salario =double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);

        List<Funcionario> funcionarios = new List<Funcionario>();
        using (StreamReader sr = File.OpenText(caminhoArquivo)) {
            while (! sr.EndOfStream ) {
                string[] campos = sr.ReadLine().Split(',');
                string nome = campos[0];
                string email = campos[1];
                double renda = double.Parse(campos[2],CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(nome,email,renda));
            
            }
            var emails = funcionarios.Where(obj => obj.Salario > salario).OrderBy(obj => obj.Email).Select(obj => obj.Email);
            var soma = funcionarios.Where(obj => obj.Nome[0] == 'M').Sum(obj => obj.Salario);

            Console.WriteLine("Emails das pessoas com salário maior que " + salario.ToString("F2",CultureInfo.InvariantCulture));
            foreach (string email in emails) {
                Console.WriteLine(email);
            
            
            }
            Console.WriteLine("Soma dos salários das pessoas cujo nome começa com a letra M: " + soma.ToString("F2",CultureInfo.InvariantCulture));
        
        
        }
    
    
    
    }
}
