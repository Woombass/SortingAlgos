using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgo.Sortings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Sortings.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange 
            var rnd = new Random();
            var collection = new List<int>();
            var coctail = new CoctailSort<int>();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(rnd.Next(0, 100));
            }
            coctail.Items.AddRange(collection);
            collection.Sort();

            //act
            coctail.Sort();

            //arrange

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(collection[i],coctail.Items[i]);
            }

        }
    }
}