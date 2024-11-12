namespace orientacaoaobjetos.modulo10_generics_set_dictionary.aula7_dictionary_sorteddictionary
{
    internal class dictionary
    {
        static void main(string[] args)
        {
            /*dictionary é o conjunto baseado em chave e valor*/
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["usuario"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["fone"] = "997145896";
            cookies["fone"] = "854578963"; /*o dictionary não aceita repetições,então ele vao sobrescrever o valor da chave fone nesse caso*/
            Console.WriteLine(cookies["fone"]); 
            Console.WriteLine(cookies["email"]);


            cookies.Remove("email");


            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);

            }
            else
            {
                Console.WriteLine("essa chave não está contida no dicionário.");

            }
            Console.WriteLine("tamanho: " + cookies.Count);

            Console.WriteLine("todos os cookies:");
            foreach (KeyValuePair<string, string> itens in cookies)
            {
                Console.WriteLine(itens.Key + ": " + itens.Value);
            }





        }
    }
}
