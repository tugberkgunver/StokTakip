using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.Abstract
{
   public interface IRepository<T>
    {
        //Burada interface ile soyutlaştırma gerçekleştirdik. Örneğin Mysql,Oracle değişikliğimiz oldu.Bu sayede kullanabileceğiz.
        List<T> List();

        IQueryable<T> ListQueryable();


        int Save();


        int Insert(T obj);

        int Update(T obj);


        int Delete(T obj);


        List<T> List(Expression<Func<T, bool>> where);


        T Find(Expression<Func<T, bool>> where);

    }
}
