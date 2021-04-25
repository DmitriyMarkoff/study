using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem3;

namespace TestFillList
{
    [TestClass]
    public class TestFillListDictionary
    {
        [TestMethod]
        public void FillListInternalGetHashCode100()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(100, true); 
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void FillListWithConstHashCode100()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(100, false);
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void FillListInternalGetHashCode10000()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(10000, true);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillListWithConstHashCode10000()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(10000, false);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillListInternalGetHashCode100000()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(100000, true);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillListWithConstHashCode100000()
        {
            long m;
            var FillListInstance = new FillList();
            m = FillListInstance.FillListInternalGetHashCode(100000, false);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryInternalGetHashCode100()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(100, true);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryWithConstHashCode100()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(100, false);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryInternalGetHashCode10000()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(10000, true);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryWithConstHashCode10000()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(10000, false);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryInternalGetHashCode100000()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(100000, true);
            Assert.IsNotNull(m);
        }
        [TestMethod]
        public void FillDictionaryWithConstHashCode100000()
        {
            long m;
            var FillDictionaryInstance = new FillDictionary();
            m = FillDictionaryInstance.FillDictionaryInternalGetHashCode(100000, false);
            Assert.IsNotNull(m);
        }
    }
}
