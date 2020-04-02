using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExProdutos.Entidades
{
    class ProdutoImportado : Produto
    {
        public double ImpostoAlf { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double impostoAlf) : base (nome, preco)
        {
            ImpostoAlf = impostoAlf;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " $"+PrecoTotal().ToString("F2",CultureInfo.InvariantCulture)+ " (Taxa Alfandega: $"+ImpostoAlf.ToString("F2",CultureInfo.InvariantCulture)+ " )"; 
        }

        public double PrecoTotal()
        {
            return Preco + ImpostoAlf;
        }
    }
}
