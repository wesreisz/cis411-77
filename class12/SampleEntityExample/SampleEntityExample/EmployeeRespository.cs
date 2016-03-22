using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SampleEntityExample
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private HRContext context = new HRContext();
        public IQueryable<Employee> All
        {
            get
            {
                return context.Employees;
            }
        }

        public IQueryable<Employee> AllIncluding(params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> query = context.Employees;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public void Delete(int id)
        {
            var employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Employee Find(int id)
        {
            return context.Employees.Find(id);
        }


        public void InsertOrUpdates(Employee employee)
        {
            if (employee.Id == default(int))
            {
                context.Employees.Add(employee);
            }
            else {
                context.Entry(employee).State = EntityState.Modified;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
