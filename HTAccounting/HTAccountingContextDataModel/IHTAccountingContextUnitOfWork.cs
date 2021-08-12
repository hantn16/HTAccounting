using DevExpress.Mvvm.DataModel;
using HTAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HTAccounting.HTAccountingContextDataModel {

    /// <summary>
    /// IHTAccountingContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IHTAccountingContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Course entities repository.
        /// </summary>
		IRepository<Course, int> Courses { get; }
        
        /// <summary>
        /// The Department entities repository.
        /// </summary>
		IRepository<Department, int> Departments { get; }
        
        /// <summary>
        /// The Employee entities repository.
        /// </summary>
		IRepository<Employee, int> Employees { get; }
    }
}
