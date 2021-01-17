using System;
using System.Collections.Generic;
using System.Linq;
using EntityUppgift.Data;
using EntityUppgift.Data.Models;
using System.Text;
using System.Threading.Tasks;

namespace EntityUppgift.Managers
{
    public class DepartmentManager
    {
        public Department GetDepartmentById(int id)
        {
            using (var db = new EntityUppgiftContext())
            {
                var department = db.Department.Find(id);
                return department;
            }
        }
        public void CreateDepartment(Department department)
        {
            using (var db = new EntityUppgiftContext())
            {
                db.Department.Add(department);
                db.SaveChanges();
            }
        }
    }
}
