using System;
using Classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Digite o seu nome:");
            // string new = Console .ReadLine();
            // Console.WriteLine("Digite o seu sobrenome:");
            // string 
            // Pessoa p = new Pessoa("Carlos Eduardo", "Tsukamoto");

            // Console.WriteLine($"Bem vindo {p.Name} {p.SobreNome}");
            // Pessoa Lameck = new Pessoa("Lameck");

            Produto produto1 = new Produto();
            produto1 .Codigo = 1;
            produto1.Nome = "Coca-Cola";
            produto1.Descricao = "Refrigerente de cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");
            Produto Produto2 = new Produto(10);
            Produto2.Nome = "Pepsi";
            Console.WriteLine($"Codigo inserido {Produto2.Codigo}, nome {Produto2.Nome}");

            Produto produto3 = new Produto(1,"Traquinas", "Bolacha de Chocolate", 1000);
            Console.WriteLine($"Codigo {produto3.Codigo}, nome {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");

        }
    }
}
