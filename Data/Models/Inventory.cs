using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data.Models
{
    public class Inventory
    {

        [Key]
        public int InventoryID { get; set; }
        public long InventoryDate { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
