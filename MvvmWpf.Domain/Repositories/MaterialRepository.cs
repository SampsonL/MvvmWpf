using MvvmWpf.Domain.Entity;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        public ICollection<T> GetAll<T>()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                try
                {
                    return session.CreateCriteria(typeof(T)).List<T>();   
                }
                catch (ADOException exception)
                {
                    throw exception;
                }

            }
        }

        public void Add<T>(T t)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction trans = session.BeginTransaction())
                {
                    session.Save(t);
                    trans.Commit();
                }
            }
        }

        //通过InputId查询container表
        public ICollection<T> GetById<T>(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                //  return session.Get<T>(id);
                // ICriteria criteria = session.CreateCriteria(typeof(T));  
                //criteria.Add(Restrictions.Eq("id", id));
                //  return criteria.List<T>();

                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.Add(Restrictions.Or(Restrictions.Eq("id", id), 
                    Restrictions.Or(Restrictions.Eq("position_id", id), Restrictions.Eq("name", id))));
                var result = criteria.List<T>();
                var count = result.Count();
                if (count == 0)
                {
                    return null;
                }
                else
                {
                    return result;
                }
                
                
            }
         
        }

        public ICollection<T> GetByid<T>(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                //  return session.Get<T>(id);
                 ICriteria criteria = session.CreateCriteria(typeof(T));  
                 criteria.Add(Restrictions.Eq("containerId", id));
                 return criteria.List<T>();
            }

        }

        //通过InputId查询material表
        public ICollection<T> GetByMaterialId<T>(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.Add(Restrictions.Or(Restrictions.Eq("id", id),
                    Restrictions.Or(Restrictions.Eq("product", id), 
                    Restrictions.Or(Restrictions.Eq("orderNo", id),Restrictions.Eq("containerId",id)))));
                return criteria.List<T>();
            }
        }
        public ICollection<T> GetByMaterialid<T>(string id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                //  return session.Get<T>(id);
                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.Add(Restrictions.Eq("id", id));
                return criteria.List<T>();
            }
        }

        //仓库概况
        public ICollection<T> GetAllByPositionId<T>()
        {
            using(ISession session = NHibernateHelper.OpenSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(T));
                criteria.AddOrder(Order.Asc("position_id"));
                return criteria.List<T>();
            }
        }
    }
}
