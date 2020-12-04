using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.UseCases
{
    public class ManageOperations<T> : IOperations<T> where T : BaseEntidad
    {   
        private readonly IRepository<T> Repository;
        public ManageOperations(IRepository<T> Repository)
        {
            this.Repository = Repository;
        }   
        public T Create(T Data)
        {
            return Repository.Create(Data);
        }
        public T Read(T Data)
        {
            return Repository.Get(Data.NumProveedor);
        }
        public T Find(Expression<Func<T, bool>> matchitem)
        {
            return Repository.Find(matchitem);
        }
        public IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> matchitem)
        {
            return Repository.FindAllWhere(matchitem);
        }
        public IEnumerable<T> FindAllWhereTake(Expression<Func<T, bool>> matchitem, int count)
        {
            return Repository.FindAllWhereTake(matchitem, count);
        }

        public Task<IEnumerable<T>> FindAll()
        {
            return Repository.ReadAsync();
        }
        public IEnumerable<T> FindAllTake(int count)
        {
            return Repository.FindAllTake(count);
        }
        public T Update(T Data)
        {
            return Repository.Update(Data);
        }
        public T Delete(T Data)
        {
            return Repository.Delete(Data);
        }
        public int Count()
        {
            return Repository.Count();
        }
        public bool Exists(Expression<Func<T, bool>> matchitem)
        {
            return Repository.Exist(matchitem);
        }
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem)
        {
            return await Repository.ExistAsync(matchitem);
        }
    }
}
