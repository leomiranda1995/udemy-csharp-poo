using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSharpPooSegundoProblema
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: R$ {Preco}, Unidades: {Quantidade}, Total R$ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
