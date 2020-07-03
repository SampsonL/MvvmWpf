using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MaterialDB materialDB = new MaterialDB();
            var list = materialDB.GetAll<Material>();
            foreach (var item in list)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
