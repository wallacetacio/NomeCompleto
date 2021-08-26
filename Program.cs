using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome, sobrenome;
            
            Console.Write("Por gentileza, digite seu primeiro nome: ");
            primeiroNome = Console.ReadLine();

            Console.Write("E agora, por favor, digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Nome completo: {primeiroNome} {sobrenome}");
            Console.WriteLine($"Nome catálogo: {sobrenome.ToUpper()}, {primeiroNome}");
        }
    }
}
