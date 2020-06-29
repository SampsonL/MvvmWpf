using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Domain.Repositories;
using MvvmWpf.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //UserInfoRepository dataUserDB = new UserInfoRepository();
        DataUserDB dataUser = new DataUserDB();
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    int userInfoId = 3;
        //    UserInfo userInfo = dataUserDB.GetById(userInfoId);
        //    Console.WriteLine(userInfo);
        //}
        [TestMethod]
        public void TestMethod2()
        {

            ICollection<UserInfo> userInfo = dataUser.GetAll();
            foreach (var item in userInfo)
            {
                var list = item.ToString();
                Console.WriteLine(list);
            }
        }
    }
}
