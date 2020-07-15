using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MaterialDB materialDB = new MaterialDB();
            string id = "3";
            Material material = materialDB.GetById<Material>(id);
            Console.WriteLine(material);
        }
    }
}
