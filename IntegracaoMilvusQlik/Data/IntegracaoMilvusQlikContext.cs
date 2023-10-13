using IntegracaoMilvusQlik.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegracaoMilvusQlik.Data
{
    public class IntegracaoMilvusQlikContext : DbContext
    {
        public IntegracaoMilvusQlikContext(DbContextOptions<IntegracaoMilvusQlikContext> options) : base(options){}

        public DbSet<IntegracaoMilvusQlik.Models.Lista> Listas { get; set; }


    }

    
}