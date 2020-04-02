using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExProdutos.Entidades
{
    class ProdutoUsado  : Produto

    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base (nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " (Usado) $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de fabricação: " + DataFabricacao.ToString("dd/MM/yyyy")+")";
        }
    }
}
