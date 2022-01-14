using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class Agenda
    {
        public int Id { get; set; }
        public Usuario usuario { get; set; }
        public UnidadeAtendimento unidadeAtendimento { get; set; }
        public Vacina vacina { get; set; }
        public DateTime dataagendamento { get; set; }
    }
}
