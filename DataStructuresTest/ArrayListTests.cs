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

        [TestCase(new int[] { 1, 2, 3, 2, 5, 4}, 2, new int[] { 1, 3, 2, 5, 4})]
        public void DeleteByFirstValue(int[] array, int value, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.DeleteByFirstValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 0, 2, 3}, new int[] { 1, 2, 3, 2, 0, 2, 3})]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8}, new int[] { 1, 2, 3, 2, 8 })]
        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { }, new int[] { 1, 2, 3, 2 })]
        public void AddArrayToTheEnd(int[] array, int[] addArray, int[] ExpArray)
        {
            ArrayList expected = new ArrayList(ExpArray);
            ArrayList actual = new ArrayList(array);

            actual.AddArrayToTheEnd(addArray);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 2 }, new int[] { 8, 9 }, 1, new int[] { 1, 8, 9, 2, 3, 2})]
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
    }
}