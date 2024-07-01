using System.Diagnostics;

namespace ApplicaitonCore.Contracts.Repositories;


public interface IRepository<T> where T:class
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    T Add(T entity);
    T Update(T entity);
    T Delete(T entity);
}