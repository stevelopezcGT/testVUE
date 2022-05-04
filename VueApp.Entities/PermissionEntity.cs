using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VueApp.Entities
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }

        [ForeignKey("PermissionType")]
        public int PermissionTypeId { get; set; }
        public DateTime PermissionDate { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public string PermissionTypeDescription { get { return PermissionType?.Description; } }
    }
}
