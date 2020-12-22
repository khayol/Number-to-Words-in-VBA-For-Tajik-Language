using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Woorj.Data;
using Woorj.Data.IndOrg;

namespace Woorj.CtrServerSide.IndOrg
{
    public class EmployeeController
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Get all Employee
        public List<Employee> GetEmployee()
        {
            var list_Employee = _db.Employee.ToList();
            return list_Employee;
        }

        // Get Employee by ID
        public Employee GetEmployeeById(int id)
        {
            Employee Employee = _db.Employee.FirstOrDefault(s => s.Id == id);
            return Employee;
        }

        // Insert Employee
        public string Create(Employee obj_Employee)
        {
            _db.Employee.Add(obj_Employee);
            _db.SaveChanges();
            return "Save Successfully";

        }

        // Edit Employee
        public string UpdateEmployee(Employee obj_Employee)
        {
            _db.Employee.Update(obj_Employee);
            _db.SaveChanges();
            return "Edited Successfully";

        }

        // Delete Employee
        public string DeleteEmployee(Employee obj_Employee)
        {
            _db.Remove(obj_Employee); // _db.Employee.Remove(obj_Employee); 
            _db.SaveChanges();
            return "Delete Successfully";

        }

    }
}
