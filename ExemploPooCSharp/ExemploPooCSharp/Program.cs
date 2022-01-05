using System;

namespace ExemploPooCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstração
             Pessoa p1 = new Pessoa();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Apresentar(); 
        }
    }
}
