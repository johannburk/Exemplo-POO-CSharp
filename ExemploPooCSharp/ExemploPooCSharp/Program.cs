using System;

namespace ExemploPooCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstração
             Pessoa p1 = new Pessoa();
            p1.Nome = "Pedro";
            p1.Idade = 19;
            p1.Apresentar(); 
              // Encapsulamento - valores inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Encapsulamento - valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(25, 20);
            System.Console.WriteLine($"Área: {r.ObterArea()}");
        }
    }
}
