using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class Cidadao
    {
        [Key]
        [StringLength(11, MinimumLength = 11)]
        public string Cpf { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string  NomeMae { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
