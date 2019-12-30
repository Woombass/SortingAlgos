
using System;
using System.Collections.Generic;

namespace SortAlgo.Sortings
{
     public class BaseAlgorithm<T> where T : IComparable
    {
        /// <summary>
        /// Коллекция элементов для сортировки.
        /// </summary>
        public List<T> Items { get; set; } = new List<T>();



        /// <summary>
        /// Метод перестановки.
        /// </summary>
        /// <param name="positionA"> Позиция элемента n</param>
        /// <param name="positionB"> Позиция элемента n+1</param>
        public void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }



        public virtual void Sort()
        {
            Items.Sort();
        }

    } 
}
