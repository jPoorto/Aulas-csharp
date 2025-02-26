namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 19;
            string nomeCompleto = "João Pedro Porto Gonçalves Pardo";

            var variavelSemTipo = "João";

            Console.WriteLine(variavelSemTipo.GetType());
            Console.WriteLine("Digite seu nome: ");
            Console.WriteLine("Digite sua idade: ");
            string nomeUsuario = Console.ReadLine();






            Console.WriteLine($"Meu nome é {nomeCompleto} e a minha idade é {idade} ");



        }
    }
}
