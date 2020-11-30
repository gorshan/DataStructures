using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DataStructures.LinkedList;

namespace DataStructuresTests
{
    public class LinkedListTests
    {
        [TestCase(new int[] { 1, 2, 3 }, 1, 4, new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 0, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, 4, new int[] { 4, 1 })]
        public void AddByIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void AddToTheEnd(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddToTheEnd(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void DeleteFromTheEnd(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteFromTheEnd();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 2, 3, 4 })]
        public void DeleteByIndex(int[] array, int index, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 8, -1)]
        [TestCase(new int[] { 1, 2, 3, 3, 5 }, 3, 2)]
        public void GetIndexByValue(int[] array, int value, int expected)
        {
            LinkedList arrActual = new LinkedList(array);

            int actual = arrActual.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1 }, 1)]
        //[TestCase(new int[] { }, 5)]
        public void FindMaxElement(int[] array, int expected)
        {
            LinkedList arrActual = new LinkedList(array);

            int actual = arrActual.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        //[TestCase(new int[] { }, 5)]
        public void FindMinElement(int[] array, int expected)
        {
            LinkedList arrActual = new LinkedList(array);

            int actual = arrActual.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1 }, 0)]
        //[TestCase(new int[] { }, 0)]
        public void FindIndexOfMax(int[] array, int expected)
        {
            LinkedList arrActual = new LinkedList(array);

            int actual = arrActual.FindIndexOfMax();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 5, 4, 3, 2 }, 3)]
        [TestCase(new int[] { 2, 4, 3, 2 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        //[TestCase(new int[] { }, 0)]
        public void FindIndexOfMin(int[] array, int expected)
        {
            LinkedList arrActual = new LinkedList(array);

            int actual = arrActual.FindIndexOfMin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 2, 4 }, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        public void DeleteByFirstValue(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteByFirstValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 2, 4 }, 2, new int[] { 1, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 4, 5, 2, 2, 8, 21 }, 2, new int[] { 1, 3, 4, 4, 5, 8, 21 })]
        public void DeleteByValue(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteByValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Reverse(int[] array, int[] expArray)
        {

            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 0, 2, 3 }, new int[] { 1, 2, 3, 2, 0, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8 }, new int[] { 1, 2, 3, 2, 8 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { }, new int[] { 1, 2, 3, 2 })]
        public void AddArrayToTheEnd(int[] array, int[] addArray, int[] ExpArray)
        {
            LinkedList expected = new LinkedList(ExpArray);
            LinkedList actual = new LinkedList(array);

            actual.AddArrayToTheEnd(addArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9 }, 1, new int[] { 1, 8, 9, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9 }, 0, new int[] { 8, 9, 1, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8 }, 1, new int[] { 1, 8, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8 }, 0, new int[] { 8, 1, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9, 7 }, 1, new int[] { 1, 8, 9, 7, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9, 7 }, 0, new int[] { 8, 9, 7, 1, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { }, 3, new int[] { 1, 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9 }, 4, new int[] { 1, 2, 3, 2, 8, 9 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { }, 0, new int[] { 1, 2, 3, 2 })]
        public void AddArrayByIndex(int[] array, int[] addArray, int index, int[] ExpArray)
        {
            LinkedList expected = new LinkedList(ExpArray);
            LinkedList actual = new LinkedList(array);

            actual.AddArrayByIndex(addArray, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, 1, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2 }, 2, new int[] { })]
       // [TestCase(new int[] { 1, 2 }, 3, new int[] { })]
        public void DeleteNElementsFromTheEnd(int[] array, int n, int[] ExpArray)
        {
            LinkedList expected = new LinkedList(ExpArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteNElementsFromTheEnd(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, 1, new int[] { 2, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, 2, new int[] { 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, 0, new int[] { 1, 2, 3, 2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        public void DeleteNElementsFromTheBeginning(int[] array, int n, int[] ExpArray)
        {
            LinkedList expected = new LinkedList(ExpArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteNElementsFromTheBeginning(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 2, new int[] { 1, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 3, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 2, new int[] { 1, 2, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 2, new int[] { 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 4, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 3, new int[] { 4 })]
        public void DeleteNElementsByIndex(int[] array, int index, int n, int[] ExpArray)
        {
            LinkedList expected = new LinkedList(ExpArray);
            LinkedList actual = new LinkedList(array);

            actual.DeleteNElementsByIndex(index, n);

            Assert.AreEqual(expected, actual);
        }
    }
}
