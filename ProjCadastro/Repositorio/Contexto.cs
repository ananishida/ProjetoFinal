

using Microsoft.EntityFrameworkCore;
using Repositorio.Entidade;


namespace Repositorio
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<CarteiraVacina> CarteiraVacina { get; set; }
        public DbSet<Cidadao> Cidadao { get; set; }
        public DbSet<UnidadeAtendimento> UnidadeAtendimento { get; set; }
        public DbSet<Vacina> Vacina { get; set; }
        public Contexto()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=ProjCadastro; User ID=usuario; password=senha; language= Portuguese;Trusted_Connection=True");
        }
    }
}
