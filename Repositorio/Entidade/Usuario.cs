using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string  CidadaoCpf { get; set; }
        [ForeignKey("CidadaoCpf")]
        public Cidadao Cidadao { get; set; }

        [StringLength(500, MinimumLength = 8)]
        public string Senha { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Email { get; set; }
    }
}
