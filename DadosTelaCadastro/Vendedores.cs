using CadastroVendedores.Model;

namespace CadastroVendedores.DadosTelaCadastro
{
    public class Vendedores
    {
        public static List<VendedorDto> ObterVendedores()
        {
            return [ new VendedorDto { Handle = 1, NomeVendedor = "João da Silva" },
                     new VendedorDto { Handle = 2, NomeVendedor = "Maria Oliveira" },
                     new VendedorDto { Handle = 3, NomeVendedor = "Carlos Eduardo" },
                     new VendedorDto { Handle = 4, NomeVendedor = "Fernanda Souza" },
                     new VendedorDto { Handle = 5, NomeVendedor = "Lucas Pereira" }];
        }
    }
}
