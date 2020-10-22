using System;
using System.Globalization;

namespace ExStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10); //Instanciar o produto

            //Inprimir as saídas
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Preço individual do Produto: R$" + p.Preço.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // vai adicionar os produtos da quantidade

            //Dados atualizados pós adição
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a serem removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); // vai remover os produtos da quantidade 

            //Dados atualizados pós remoção
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
