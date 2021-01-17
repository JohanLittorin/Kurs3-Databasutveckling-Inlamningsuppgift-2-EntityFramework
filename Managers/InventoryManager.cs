using EntityUppgift.Data;
using EntityUppgift.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Managers
{
    public class InventoryManager
    {
        public Inventory GetInventoryById(int id)
        {
            using (var db = new EntityUppgiftContext())
            {
                var inventory = db.Inventory.Find(id);
                return inventory;
            }
        }
        public void CreateInventory(Inventory inventory)
        {
            using (var db = new EntityUppgiftContext())
            {
                db.Inventory.Add(inventory);
                db.SaveChanges();
            }
        }
    }
}
