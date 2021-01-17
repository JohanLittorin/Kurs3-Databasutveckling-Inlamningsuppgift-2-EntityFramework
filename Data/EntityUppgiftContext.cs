using EntityUppgift.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data
{
    public class EntityUppgiftContext : DbContext
    {
        public EntityUppgiftContext() : base("name=EntityUppgiftConnectionString")
        {

        }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Product> Product { get; set; }

    }
}
