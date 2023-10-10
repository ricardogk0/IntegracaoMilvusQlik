using IntegracaoMilvusQlik.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegracaoMilvusQlik.Data
{
    public class IntegracaoMilvusQlikContext : DbContext
    {
        public IntegracaoMilvusQlikContext(DbContextOptions<IntegracaoMilvusQlikContext> options) : base(options){}

        public DbSet<IntegracaoMilvusQlik.Models.Lista> Listas { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.Meta> Metas { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.Paginate> Paginates { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.Resposta> Respostas { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.Sla> Slas { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.Solucao> Solucoes { get; set; }
        public DbSet<IntegracaoMilvusQlik.Models.UltimaLog> UltimaLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lista>().HasKey(l => l.Id);
            modelBuilder.Entity<Meta>().HasNoKey();
        }
    }

    
}