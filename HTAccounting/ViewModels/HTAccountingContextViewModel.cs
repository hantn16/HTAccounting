using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using HTAccounting.Localization;using HTAccounting.HTAccountingContextDataModel;

namespace HTAccounting.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the HTAccountingContext data model.
    /// </summary>
    public partial class HTAccountingContextViewModel : DocumentsViewModel<HTAccountingContextModuleDescription, IHTAccountingContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of HTAccountingContextViewModel as a POCO view model.
        /// </summary>
        public static HTAccountingContextViewModel Create() {
            return ViewModelSource.Create(() => new HTAccountingContextViewModel());
        }

		        static HTAccountingContextViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<HTAccountingContextMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the HTAccountingContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the HTAccountingContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected HTAccountingContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override HTAccountingContextModuleDescription[] CreateModules() {
			return new HTAccountingContextModuleDescription[] {
                new HTAccountingContextModuleDescription(HTAccountingContextResources.CoursePlural, "CourseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Courses)),
                new HTAccountingContextModuleDescription(HTAccountingContextResources.DepartmentPlural, "DepartmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Departments)),
                new HTAccountingContextModuleDescription(HTAccountingContextResources.EmployeePlural, "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
			};
        }
                	}

    public partial class HTAccountingContextModuleDescription : ModuleDescription<HTAccountingContextModuleDescription> {
        public HTAccountingContextModuleDescription(string title, string documentType, string group, Func<HTAccountingContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}