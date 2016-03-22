using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityExample
{
    interface IEmployeeRepository:IDisposable
    {
        IQueryable<Employee> All { get; }
        IQueryable<Employee> AllIncluding(params Expression<Func<Employee, object>>[] includeProperties);
        Employee Find(int id);
        void InsertOrUpdates(Employee employee);
        void Delete(int id);
        void Save();
    }
}
