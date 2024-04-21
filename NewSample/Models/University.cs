using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSample.Models;
public class University : BaseModel
{
    public string Name { get; set; }

    public int CityId { get; set; }
    [ForeignKey("CityId")]
    public City City { get; set; }
}
