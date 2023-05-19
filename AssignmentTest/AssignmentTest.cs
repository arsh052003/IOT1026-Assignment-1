using Assignment;

// Write tests ONLY for the ReplicateArray method. This method should not need any Console.ReadLine/Console.WriteLine statements.
// You should have at least three test cases
// 1. Empty Array (Done for you)
// 2. Array with a single element
// 3. Array with multiple elements
// Ensure the copied array has the same elements as the original array (CollectionAssert.AreEqual)
// Ensure that the new array is deep copied (Assert.AreNotSame)

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void ReplicateArray_EmptyArray_ReturnsEmptyArray()
        {

            int[] original = Array.Empty<int>();
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);

        }
        [TestMethod]
        public void ReplicateArray_ArrayWithElements()
        {
            int[] original = new int[] { 1, 2, 3 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        [TestMethod]
        public void ReplicateArray_ArrayWithNegativeElements()
        {
            int[] original = new int[] { -1, 2, -3, 0, -999, 100120 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        /* Great idea -> But since we take in int[] and not int[]? 
        * it is the user's responsiblity to make sure the array is not null
        public void ReplicateArray_NullArray_ThrowsException()
        {
            int[] original = null;
            int[] result = Array.Empty
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }
        */

    }

}
