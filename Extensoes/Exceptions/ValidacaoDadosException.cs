using System;
using System.Runtime.Serialization;

namespace CadastroVendedores.Extensoes.Exceptions
{
    [Serializable]
    public class ValidacaoDadosException : Exception
    {
        public ValidacaoDadosException() { }

        public ValidacaoDadosException(string mensagem) : base(mensagem) { }
    }
}
