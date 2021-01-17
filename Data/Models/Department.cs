using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data.Models
{
    public class Department
    {
        [Key] // [Key] anger Primary Key för raden efter, dvs int ID.
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual Person Person { get; set; }

    }
}
