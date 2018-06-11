using System;
using AbstractHotelModel;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AbstracHotelService
{
    public class AbstractDbContext : DbContext
    {
        public AbstractDbContext() : base("AbstractHotelService")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public static AbstractDbContext Create()
        {
            return new AbstractDbContext();
        }

        public override Task<int> SaveChangesAsync()
        {
            try
            {
                return base.SaveChangesAsync();
            }
            catch (Exception)
            {
                foreach (var entry in ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Deleted:
                            entry.Reload();
                            break;
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                    }
                }
                throw;
            }
        }
        public virtual DbSet<Administrator> Administrators { get; set; }

        public virtual DbSet<Posetitel> Posetitels { get; set; }

        public virtual DbSet<Oplata> Oplats { get; set; }

        public virtual DbSet<Zakaz> Zakazs { get; set; }

        public virtual DbSet<UslugaZakaz> UslugaZakazs { get; set; }

        public virtual DbSet<Usluga> Uslugs { get; set; }
    }
}

