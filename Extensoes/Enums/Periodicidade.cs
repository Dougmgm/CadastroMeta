using System.ComponentModel;

namespace CadastroVendedores.Extensoes.Enums
{
    public static class Periodicidade
    {
        public static string DescricaoEnum(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attr = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attr?.Description ?? value.ToString();
        }
    }
}
