using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone  { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
