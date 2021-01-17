using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public long PersonNr { get; set; }
        public long PhoneNr { get; set; }
        public long HomeNr { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
