using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class UnidadeAtendimento
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }

    }
}
