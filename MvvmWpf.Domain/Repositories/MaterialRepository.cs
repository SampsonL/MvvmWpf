using MvvmWpf.Domain.Entity;
using NHibernate;
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
    }
}
