using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;
public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Company Name Is Required Field")]
    public string? Name { get; set; } = "";

    [Required(ErrorMessage = "Address Is A Required Field")]
    public string? Address { get; set; } = "";

    public string? Country { get; set; } = "";

    public IList<Employee>? Employees { get; set; } = new List<Employee>();
}
