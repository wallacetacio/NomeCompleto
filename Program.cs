using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome, sobrenome, usuario;
            
            Console.Write("Por gentileza, digite seu primeiro nome: ");
            primeiroNome = Console.ReadLine();

            Console.Write("E agora, por favor, digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.Write("Agora digite o nome de usuário: ");
            usuario = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Nome completo: {char.ToUpper(primeiroNome[0]) + primeiroNome.Substring(1)} {char.ToUpper(sobrenome[0]) + sobrenome.Substring(1)}");
            Console.WriteLine($"Nome catálogo: {sobrenome.ToUpper()}, {char.ToUpper(primeiroNome[0]) + primeiroNome.Substring(1)}");
            Console.WriteLine($"Nome de usuário: {usuario}");
            Console.ReadKey();
        }
    }
}
