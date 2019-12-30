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
            BubbleSort<int> sort = new BubbleSort<int>();
            
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sort.Items.Add(rnd.Next(0,1000));
            }

            sort.Sort();




        }
    }
}