using EntityUppgift.Data;
using EntityUppgift.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Managers
{
    public class ProductManager
    {
        public Product GetProductById(int id)
        {
            using (var db = new EntityUppgiftContext())
            {
                var product = db.Product.Find(id);
                return product;
            }
        }
        public void CreatePerson(Product product)
        {
            using (var db = new EntityUppgiftContext())
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
        }
    }
}
