using DevExpress.Mvvm.DataAnnotations;
using HTAccounting.Localization;
using HTAccounting.Model;

namespace HTAccounting.HTAccountingContextDataModel {

    public class HTAccountingContextMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Course> builder) {
			builder.DisplayName(HTAccountingContextResources.Course);
						builder.Property(x => x.CourseID).DisplayName(HTAccountingContextResources.Course_CourseID);
						builder.Property(x => x.Title).DisplayName(HTAccountingContextResources.Course_Title);
						builder.Property(x => x.Department).DisplayName(HTAccountingContextResources.Course_Department);
			        }
		        public static void BuildMetadata(MetadataBuilder<Department> builder) {
			builder.DisplayName(HTAccountingContextResources.Department);
						builder.Property(x => x.DepartmentID).DisplayName(HTAccountingContextResources.Department_DepartmentID);
						builder.Property(x => x.Name).DisplayName(HTAccountingContextResources.Department_Name);
			        }
		        public static void BuildMetadata(MetadataBuilder<Employee> builder) {
			builder.DisplayName(HTAccountingContextResources.Employee);
						builder.Property(x => x.EmployeeID).DisplayName(HTAccountingContextResources.Employee_EmployeeID);
						builder.Property(x => x.Name).DisplayName(HTAccountingContextResources.Employee_Name);
						builder.Property(x => x.Department).DisplayName(HTAccountingContextResources.Employee_Department);
			        }
		    }
}