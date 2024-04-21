using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSample.Models;
public class Student :BaseModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public DateTime BhirtDate { get; set; }
    public string? PhoneNumber { get; set; }

    public int UniversityId {  get; set; }
    [ForeignKey("UniversityId")]
    public University University { get; set; }
}
