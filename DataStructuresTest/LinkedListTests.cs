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
        [TestCase(new int[] { 1},  new int[] { })]
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

    }
}
