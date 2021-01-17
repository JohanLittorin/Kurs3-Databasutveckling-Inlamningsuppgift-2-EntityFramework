using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Balance { get; set; }
        public int Price { get; set; }
        public long ExpirationDate { get; set; }
        public string TableofContent { get; set; }
        public virtual ICollection<Campaign> Campaign { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
