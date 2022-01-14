using Repositorio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjCadastro.Models
{
    public class AgendamentoModel
    {
        public List<Vacina> ListaVacinas;
        public List<UnidadeAtendimento> ListaunidadeAtendimentos;

        public Vacina vacina { get; set; }
        public UnidadeAtendimento unidade { get; set; }
        public Cidadao cidadao { get; set; }
        public Agenda agenda { get; set; }

    }
}
