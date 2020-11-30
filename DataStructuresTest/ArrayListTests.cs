using NUnit.Framework;

namespace DataStructures.Test
{
    public class ArrayListTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 , 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void ReverseTest(int[] array, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 4, 2, 1, 5}, new int[] { 1, 2, 4, 5, 8 })]
        public void RangeArrayToBig(int[] array, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.RangeArrayToBig();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 4, 2, 1, 5 }, new int[] { 8, 5, 4, 2, 1  })]
        public void RangeArraSmall(int[] array, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.RangeArrayToSmall();

            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(new int[] { 1, 2, 3 }, 4, 1, new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 4, 0, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 4, 3, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, 0, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 4, 0, new int[] { 4, 1 })]
        public void Add1ToIndex(int[] array, int value, int index, int[] expArray)
        {
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.Add1ToIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        public void AddToTheEnd(int[] array, int value, int[] expArray)
        {
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.Add1ToTheEnd(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void DeleteFromTheEnd(int[] array, int[] expArray)
        {
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.Delete1FromTheEnd();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 2, 3, 4 })]
        public void DeleteByIndex(int[] array, int index, int[] expArray)
        {
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.Delete1ByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 8, -1)]
        [TestCase(new int[] { 1, 2, 3, 3, 5 }, 3, 2)]
        public void GetIndexByValue(int[] array, int value, int expected)
        {
            ArrayList arrActual = new ArrayList(array);

            int actual = arrActual.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1 }, 1)]
        //[TestCase(new int[] { }, 5)]
        public void FindMaxElement(int[] array, int expected)
        {
            ArrayList arrActual = new ArrayList(array);

            int actual = arrActual.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        //[TestCase(new int[] { }, 5)]
        public void FindMinElement(int[] array, int expected)
        {
            ArrayList arrActual = new ArrayList(array);

            int actual = arrActual.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1 }, 0)]
        //[TestCase(new int[] { }, 0)]
        public void FindIndexOfMax(int[] array, int expected)
        {
            ArrayList arrActual = new ArrayList(array);

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
            ArrayList arrActual = new ArrayList(array);

            int actual = arrActual.FindIndexOfMin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 2, 4 }, 2, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3, 4 })]
        public void DeleteByFirstValue(int[] array, int value, int[] expArray)
        {
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

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
            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.DeleteByValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Reverse(int[] array, int[] expArray)
        {

            ArrayList expected = new ArrayList(expArray);
            ArrayList actual = new ArrayList(array);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 0, 2, 3 }, new int[] { 1, 2, 3, 2, 0, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8 }, new int[] { 1, 2, 3, 2, 8 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { }, new int[] { 1, 2, 3, 2 })]
        public void AddArrayToTheEnd(int[] array, int[] addArray, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

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
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.AddArrayByIndex(addArray, index);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3, 2 }, 1, new int[] { 1, 2, 3 })]
        //[TestCase(new int[] { 1, 2, 3, 2 }, 2, new int[] { 1, 2 })]
        //[TestCase(new int[] { 1 }, 1, new int[] { })]
        //[TestCase(new int[] { 1, 2 }, 2, new int[] { })]
        //// [TestCase(new int[] { 1, 2 }, 3, new int[] { })]
        //public void DeleteNElementsFromTheEnd(int[] array, int n, int[] ExpArray)
        //{
        //    ArrayList expected = new ArrayList(ExpArray);
        //    ArrayList actual = new ArrayList(array);

        //    actual.DeleteNElementsFromTheEnd(n);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 1, 2, 3, 2 }, 1, new int[] { 2, 3, 2 })]
        //[TestCase(new int[] { 1, 2, 3, 2 }, 2, new int[] { 3, 2 })]
        //[TestCase(new int[] { 1, 2, 3, 2 }, 0, new int[] { 1, 2, 3, 2 })]
        //[TestCase(new int[] { 1 }, 1, new int[] { })]
        //public void DeleteNElementsFromTheBeginning(int[] array, int n, int[] ExpArray)
        //{
        //    ArrayList expected = new ArrayList(ExpArray);
        //    ArrayList actual = new ArrayList(array);

        //    actual.DeleteNElementsFromTheBeginning(n);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 1, 2, 3, 4 }, 1, 2, new int[] { 1, 4 })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 1, 3, new int[] { 1 })]
        //[TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 2, new int[] { 1, 2, 5, 6 })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 0, 2, new int[] { 3, 4 })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 0, 4, new int[] { })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 0, 3, new int[] { 4 })]
        //public void DeleteNElementsByIndex(int[] array, int index, int n, int[] ExpArray)
        //{
        //    ArrayList expected = new ArrayList(ExpArray);
        //    ArrayList actual = new ArrayList(array);

        //    actual.DeleteNElementsByIndex(index, n);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}