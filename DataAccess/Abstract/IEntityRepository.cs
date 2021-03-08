using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint yapacam where ile
    //IEntity veya IEntity implemente eden bir nesne olabilir(Category,Customer ve Product nesneleri)
    //new() : new lenebilir olmali, yani interface olmaz(IEntity olmaz),onun implemente ettikleri olabilir
    //bu haliyle database verileriyle calisan bir interfaceimiz oldu
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
