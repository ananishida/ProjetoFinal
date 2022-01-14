using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class Agenda
    {
        public int Id { get; set; }
        public int usuarioId { get; set; }
        [ForeignKey("usuarioId")]
        public Usuario usuario { get; set; }
        public int UnidadeAtendimentoId { get; set; }
        [ForeignKey("UnidadeAtendimentoId")]

        public UnidadeAtendimento unidadeAtendimento { get; set; }

        [ForeignKey("vacinaId")]
        public Vacina vacina { get; set; }
        public int vacinaId { get; set; }

        public DateTime dataagendamento { get; set; }
    }
}
