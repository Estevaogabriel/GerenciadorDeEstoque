using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProdutosEmEstoque
{
    class Produto
    {

        //Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Função do Valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public int AdicionarProdutos()
        {
            int a = int.Parse(Console.ReadLine());
            return Quantidade += a;
        }

        public int RemoverProdutos()
        {
            int a = int.Parse(Console.ReadLine());
            return Quantidade -= a;
        }


               //Permite a impressão do produto, diretamente
        public override string ToString()
        {
            return "Produto: " + Nome +
                ". R$ " + Preco +
                "- " + Quantidade +
                " unidades. Valor em estoque: R$ " + ValorTotalEmEstoque();
        }

    }
}
