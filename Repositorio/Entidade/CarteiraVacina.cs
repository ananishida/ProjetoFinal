using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidade
{
    public class CarteiraVacina
    {
        public int Id { get; set; }
        public string Dose { get; set; }
        public int vacinaid { get; set; }
        [ForeignKey("vacinaid")]
        public Vacina vacina { get; set; }
        public string cidadaocpf { get; set; }
        [ForeignKey("cidadaocpf")]
        public Cidadao cidadao { get; set; }
        public DateTime dtVacina { get; set; }
        public string Fabricante { get; set; }
        public string Laboratório { get; set; }
        public int Lote { get; set; }
       
    }
}
