using System;

namespace ProjetoProdutosEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis que estarão no estoque
            char opcao = 's';
            int TamanhoEstoque = 2;
            int i = 0;
            //

            //Chamando a classe de produto
            Produto Produto1;
            Produto1 = new Produto();

            //Chamando a classe estoque
            Estoque Estoque;
            Estoque = new Estoque();

            for (i = 0; Estoque.QuantidadeEstoque < TamanhoEstoque; i++)
            {
                //Lógica
                while (opcao != 'n')
                {
                    //Impressão de Tabela
                    Console.WriteLine("Sistema de produtos em estoque!");
                    Console.WriteLine("Opções: ");
                    Console.WriteLine("1 - Visualizar estoque");
                    Console.WriteLine("2 - Adicionar Produtos no estoque");
                    Console.WriteLine("3 - Remover produtos do estoque");
                    Console.Write("Entre com o comando: ");
                    int escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1://Caso A quantidade seja 0
                            if (Produto1.Quantidade == 0)
                            {
                                Console.WriteLine("Estoque zerado! É preciso adicionar um produto: ");
                                Console.Write("Entre com o nome do produto: ");
                                Produto1.Nome = Console.ReadLine();
                                Console.Write("Entre com o preço do produto: ");
                                Produto1.Preco = double.Parse(Console.ReadLine());
                                Console.Write("Entre com a quantidade do produto: ");
                                Produto1.Quantidade = int.Parse(Console.ReadLine());
                                Console.WriteLine("Produto Adicionado!");
                                Estoque.QuantidadeEstoque++;
                                Console.WriteLine("Voltar para menu? (s/n)");
                                opcao = char.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine(Produto1);
                            Console.WriteLine("Voltar para menu? (s/n)");
                            opcao = char.Parse(Console.ReadLine());
                            Console.Clear();
                            break;
                        case 2://Adicionar um Produto
                            Console.Write("Entre com o nome do produto: ");
                            Produto1.Nome = Console.ReadLine();
                            Console.Write("Entre com o preço do produto: ");
                            Produto1.Preco = double.Parse(Console.ReadLine());
                            Console.Write("Entre com a quantidade do produto: ");
                            Produto1.Quantidade = int.Parse(Console.ReadLine());
                            Console.WriteLine("Produto Adicionado!");
                            Estoque.QuantidadeEstoque++;
                            Console.WriteLine("Voltar para menu? (s/n)");
                            opcao = char.Parse(Console.ReadLine());
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Você vendeu quantas unidades do " + Produto1.Nome + "? ");
                            int menosum = Produto1.RemoverProdutos();
                            Console.WriteLine("Voltar para menu? (s/n)");
                            opcao = char.Parse(Console.ReadLine());
                            Console.Clear();//Limpa a tela
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!");
                            Console.Clear();
                            break;
                    }
                }
            }
            Console.WriteLine("Estoque Cheio!");
        }
    }
}

