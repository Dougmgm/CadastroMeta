using CadastroVendedores.Model;
using static CadastroVendedores.Model.ProdutoDto;

namespace CadastroVendedores.DadosTelaCadastro
{
    public class Produtos
    {
        public static List<ProdutoDto> ObterProdutos()
        {
            return [ new ProdutoDto { Handle = 1, NomeProduto = "Barris", Categoria = CategoriaProduto.Liquido  },
                     new ProdutoDto { Handle = 2, NomeProduto = "Garrafas e Latas", Categoria = CategoriaProduto.Liquido  },
                     new ProdutoDto { Handle = 3, NomeProduto = "Acessórios e Produtos", Categoria = CategoriaProduto.Diversos  }];
        }        
    }
}
