namespace ExemploPooCSharp.Models
{
    public class Pessoa
    {
        public string Nome {get;set;}

        public int idade {get;set;}

        public void Apresentar(){
            Console.WriteLine($"Olá,meu nome é {Nome} e tenho {idade} anos");
        }
    }
}