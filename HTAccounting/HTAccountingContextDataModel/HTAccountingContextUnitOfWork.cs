using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using HTAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HTAccounting.HTAccountingContextDataModel {

    /// <summary>
    /// A HTAccountingContextUnitOfWork instance that represents the run-time implementation of the IHTAccountingContextUnitOfWork interface.
    /// </summary>
    public class HTAccountingContextUnitOfWork : DbUnitOfWork<HTAccountingContext>, IHTAccountingContextUnitOfWork {

        public HTAccountingContextUnitOfWork(Func<HTAccountingContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Course, int> IHTAccountingContextUnitOfWork.Courses {
            get { return GetRepository(x => x.Set<Course>(), (Course x) => x.CourseID); }
        }

        IRepository<Department, int> IHTAccountingContextUnitOfWork.Departments {
            get { return GetRepository(x => x.Set<Department>(), (Department x) => x.DepartmentID); }
        }

        IRepository<Employee, int> IHTAccountingContextUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.EmployeeID); }
        }
    }
}
