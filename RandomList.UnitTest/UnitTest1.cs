using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace RandomList_UnitTests
{
    [TestClass]
    public class RandomListTests
    {
        [TestMethod]
        public void Shuffle_NotRandom_ShouldThrowException()
        {
            //Arrange
            List<int> list1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> list2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act
            RandomizeListNS.RandomList.Shuffle(list1);
            RandomizeListNS.RandomList.Shuffle(list2);

            //Assert
            CollectionAssert.AreNotEqual(list1, list2);

        }

        [TestMethod]
        public void MakeRandomList_ItemsOutOfLimit_ShouldThrowException()
        {
            List<int> list = RandomizeListNS.RandomList.MakeRandomList(8);

            CollectionAssert.DoesNotContain(list, 8);

        }

        [TestMethod]
        public void MakeRandomList_ItemsNotUnique_ShouldThrowException()
        {
            List<int> list = RandomizeListNS.RandomList.MakeRandomList(12);

            CollectionAssert.AllItemsAreUnique(list);

        }
    }
}
