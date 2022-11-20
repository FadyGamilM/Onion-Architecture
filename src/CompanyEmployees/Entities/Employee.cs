using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;
public class Employee
{
    [Column("EmployeeId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Employee Name Is A Required Field")]
    [MaxLength(20, ErrorMessage = "Employee Name Can't Exceed 20 chars")]
    public string? Name { get; set; } = "";

    [Required(ErrorMessage ="Age Is A Required Field")]
    public int Age { get; set; }

    [Required(ErrorMessage ="Employee Position Is A Required Field")]
    [MaxLength (20, ErrorMessage ="Max Length of employee position is 20 chars")]
    public string? Position { get; set; } = "";

    [ForeignKey(nameof(Company))]
    public Guid CompanyId { get; set; }
     public Company Company { get; set; }
    
}

