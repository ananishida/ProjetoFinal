using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public Cidadao Cidadao { get; set; }

        [StringLength(32, MinimumLength = 8)]
        public string Senha { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Email { get; set; }
    }
}
