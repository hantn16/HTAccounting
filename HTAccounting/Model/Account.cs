using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTAccounting.Model
{
    [Table("Account")]
    public partial class Account
    {
        public Guid AccountID { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string AccountName { get; set; }

        [StringLength(128)]
        public string AccountNameEnglish { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public Guid? ParentID { get; set; }

        [StringLength(100)]
        public string MISACodeID { get; set; }

        public int? Grade { get; set; }

        public bool IsParent { get; set; }

        public int AccountCategoryKind { get; set; }

        public bool IsPostableInForeignCurrency { get; set; }

        public bool DetailByAccountObject { get; set; }

        public int? AccountObjectType { get; set; }

        public bool DetailByBankAccount { get; set; }

        public bool DetailByJob { get; set; }

        public int? DetailByJobKind { get; set; }

        public bool DetailByProjectWork { get; set; }

        public int? DetailByProjectWorkKind { get; set; }

        public bool DetailByOrder { get; set; }

        public int? DetailByOrderKind { get; set; }

        public bool DetailByContract { get; set; }

        public int? DetailByContractKind { get; set; }

        public bool DetailByExpenseItem { get; set; }

        public int? DetailByExpenseItemKind { get; set; }

        public bool DetailByDepartment { get; set; }

        public int? DetailByDepartmentKind { get; set; }

        public bool DetailByListItem { get; set; }

        public int? DetailByListItemKind { get; set; }

        public bool Inactive { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(100)]
        public string SortMISACodeID { get; set; }

        public bool DetailByPUContract { get; set; }

        public int? DetailByPUContractKind { get; set; }
    }
}
