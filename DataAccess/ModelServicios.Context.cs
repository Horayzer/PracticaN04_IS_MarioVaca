
namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class serviciosEntities : DbContext
    {
        public serviciosEntities()
            : base("name=serviciosEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
    
        public virtual ObjectResult<ObtenerClientesConCategoria_Result> ObtenerClientesConCategoria()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerClientesConCategoria_Result>("ObtenerClientesConCategoria");
        }
    }
}
