using MvvmWpf.Domain.Entity;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        public void Add(UserInfo userInfo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction trans = session.BeginTransaction())
                {
                    session.Save(userInfo);
                    trans.Commit();
                }
            }
        }

        public void AddMany(ICollection<UserInfo> userInfo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction trans = session.BeginTransaction())
                {
                    foreach (var user in userInfo)
                    {
                        session.Save(user);
                    }
                    trans.Commit();
                }
            }
        }

        public ICollection<UserInfo> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                try
                {
                    return session.CreateCriteria(typeof(UserInfo)).List<UserInfo>();
                  //  ICollection<UserInfo> users = session.CreateCriteria(typeof(UserInfo)).List<UserInfo>();
                //    return users;
                }
                catch (ADOException exception)
                {
                    throw exception;
                }

            }
        }

        public UserInfo GetById(int userInfoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<UserInfo>(userInfoId);
            }
        }

        public void Remove(UserInfo userInfo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction trans = session.BeginTransaction())
                {
                    session.Delete(userInfo);
                    trans.Commit();
                }
            }
        }

        public long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<UserInfo>().RowCountInt64();
            }
        }

        public void Update(UserInfo userInfo)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction trans = session.BeginTransaction())
                {
                    session.Update(userInfo);
                    trans.Commit();
                }
            }
        }
    }
}
