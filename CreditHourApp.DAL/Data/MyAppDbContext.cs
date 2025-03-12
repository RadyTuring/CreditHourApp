using Entities;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace  Data;
public class MyAppDbContext:DbContext
{
    public MyAppDbContext(DbContextOptions<MyAppDbContext> options):base(options)
    {
        
    }
    
   
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<StudentExtend> StudentExtends { get; set; }

    public DbSet<Gender> Genders { get; set; }
    public DbSet<Nationlity> Nationlities { get; set; }
}
