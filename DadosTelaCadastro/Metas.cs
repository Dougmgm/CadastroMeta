using CadastroVendedores.Model;
using System.ComponentModel;

namespace CadastroVendedores.DadosTelaCadastro
{
    public class Metas
    {
        public static BindingList<MetaVendedorDto> ObterMetasVendedores()
        {
            return
            [
                new MetaVendedorDto
                {
                    NomeVendedor = "João da Silva",
                    Periodicidade = Periodicidade.Mensal,
                    Produto = "Barris",
                    ValorMeta = 1500,
                    TipoMeta = "Unidades"
                }
            ];
        }
    }
}
