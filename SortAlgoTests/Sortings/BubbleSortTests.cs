using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgo.Sortings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Sortings.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            BubbleSort<int> sort = new BubbleSort<int>();

            int itemsCount = 100;
            var rnd = new Random();
            var collection = new List<int>();
            for (int i = 0; i < itemsCount; i++)
            {
               collection.Add(rnd.Next(0,1000));
            }

            sort.Items.AddRange(collection);
            collection.Sort();

            //act
            sort.Sort();
            


            // Assert
            for (int i = 0; i < itemsCount; i++)
            {
                Assert.AreEqual(collection[i], sort.Items[i]);
            }



        }
    }
}