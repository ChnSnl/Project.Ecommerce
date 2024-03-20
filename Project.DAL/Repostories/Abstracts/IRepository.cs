using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repostories.Abstracts
{
    public interface IRepository<T> where T : IEntity
    {

        //List Commands

        List<T> GetAll();
        List<T> GetActives();
        Task<List<T>> GetActiveAsync();
        List<T> GetPassive();
        List<T> GetModifieds();

        //Modify Commands

        void Add();
        Task AddAsync();
        Task AddRangeAsync();
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        Task UpdateAsync(T item);
        Task UpdateRangeAsync(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Commands

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp); //Anonymus Type mapping e destek vermek için kullanabileceğim bir select metodudur.
        IQueryable<T> Select<X>(Expression<Func<T, X>> exp); // Generic tipe göre işlem yapmasını istediğimiz select metodu.

        //Find Commands

        Task<T> FindAsync(int id);
        List<T> GetLastDatas(int count);
        List<T> GetFirstDatas(int count);

    }
}
