
using Entities;
using Interfaces;

namespace Data;

public class UnitOfWork : IUnitOfWork
{
    private MyAppDbContext _context;

    public UnitOfWork(MyAppDbContext context)
    {
        _context = context;
        Students = new Repository<Student>(_context);
        Departments = new Repository<Department>(_context);
        StudentExtends = new Repository<StudentExtend>(_context);
        Genders = new Repository<Gender>(_context);
        Nationlities = new Repository<Nationlity>(_context);


    }
    public IRepository<Student> Students { get; }
    public IRepository<Department> Departments { get; }
    public IRepository<StudentExtend> StudentExtends { get; }
    public IRepository<Gender> Genders { get; }
    public IRepository<Nationlity> Nationlities { get; }
    public void Dispose()
    {
        _context.Dispose();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}
