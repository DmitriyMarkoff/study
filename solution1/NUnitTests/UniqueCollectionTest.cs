using System;
using NUnit.Framework;
using UniqueCollection;

namespace Tests
{
    public class Tests
    {
        public class TestUniqueCollection
        {
            //[SetUp]
            //public void Setup()
            //{
                
            //}

            [Test]
            public void AddNonexistingElementToIntCollection()
            {
                int count = 10;
                UniqueCollectionClass<int> IntCollection = new UniqueCollectionClass<int>();
                for (int i = 0; i < count; i++)
                {
                    IntCollection.Add(i);
                }

                Assert.DoesNotThrow(() => IntCollection.Add(count + 1));
            }
            [Test]
            public void AddExistingElementToIntCollection()
            {
                int count = 10;
                UniqueCollectionClass<int> IntCollection = new UniqueCollectionClass<int>();
                for (int i = 0; i < count; i++)
                {
                    IntCollection.Add(i);
                }

                Assert.Throws<ArgumentException>(() => IntCollection.Add(count - 1));
            }
            
        }
    }
}