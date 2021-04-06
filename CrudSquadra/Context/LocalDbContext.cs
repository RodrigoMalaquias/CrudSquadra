using CrudSquadra.Entities;
using Microsoft.EntityFrameworkCore;


namespace CrudSquadra.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt)
        {

        }

        public DbSet<Carro> carro { get; set; }

    }
}
