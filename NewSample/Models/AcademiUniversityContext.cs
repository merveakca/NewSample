using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSample.Models;
public class AcademiUniversityContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-D84DF12\\SQLEXPRESS02; Database=NewSampleAkademiDb; trusted_connection=true; TrustServerCertificate=true");
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<University> Universities { get; set; }
}
