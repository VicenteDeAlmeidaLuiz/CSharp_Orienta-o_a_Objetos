namespace OrientacaoAObjetos.Modulo10_Generics_Set_Dictionary.Aula3_GetHashEEquals
{
    internal class Equals
    { /*Equals é o método que compara se um objeto é igual a outro,retornando true ou false*/
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "João";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine("_______");

            int c = 10;
            int d = 10;
            Console.WriteLine(c.Equals(d));


        }





    }
}
