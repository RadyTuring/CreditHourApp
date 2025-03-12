
using Entities;

namespace  Interfaces;
public interface IUnitOfWork : IDisposable
{
    IRepository<Student> Students { get; }
    IRepository<Department> Departments { get; }
    IRepository<StudentExtend> StudentExtends { get; }
    IRepository<Gender> Genders { get; }
    IRepository<Nationlity> Nationlities { get; }
    int Save();
}
