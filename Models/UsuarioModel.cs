using System.Numerics;

namespace CRD.Models
{
    public class UsuarioModel
    {
        public BigInteger CPF { get; set; }
        public String Nome { get; set; }
        public String Sexo { get; set; }

        public static implicit operator UsuarioModel(List<UsuarioModel> v)
        {
            throw new NotImplementedException();
        }
    }
}
