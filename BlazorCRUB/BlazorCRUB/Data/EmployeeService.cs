using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUB.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        public string Create(EmployeeInfo objEMployee)
        {
            _db.Employees.Add(objEMployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }

        public string UpdateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public string DeleteEmpInfo(EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
