using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using HTAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HTAccounting.HTAccountingContextDataModel {

    /// <summary>
    /// A HTAccountingContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IHTAccountingContextUnitOfWork interface.
    /// </summary>
    public class HTAccountingContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IHTAccountingContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the HTAccountingContextDesignTimeUnitOfWork class.
        /// </summary>
        public HTAccountingContextDesignTimeUnitOfWork() {
        }

        IRepository<Course, int> IHTAccountingContextUnitOfWork.Courses {
            get { return GetRepository((Course x) => x.CourseID); }
        }

        IRepository<Department, int> IHTAccountingContextUnitOfWork.Departments {
            get { return GetRepository((Department x) => x.DepartmentID); }
        }

        IRepository<Employee, int> IHTAccountingContextUnitOfWork.Employees {
            get { return GetRepository((Employee x) => x.EmployeeID); }
        }
    }
}
