using AbstractHotelModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AbstracHotelService
{
    [Table("AbstractDatabase")]
    public class AbstractDbContext : DbContext
    {
        public AbstractDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Posetitel> Posetitels { get; set; }

        public virtual DbSet<Ispolnitel> Ispolnitels { get; set; }

        public virtual DbSet<Zakaz> Zakazs { get; set; }

        public virtual DbSet<Usluga> Uslugs { get; set; }
    }
}
