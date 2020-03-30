using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace CustomListClassTests
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]
        public void AddOne_CheckCountOne()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            numbers.Add(11);
            actual = numbers.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOne_CheckIndexZero()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 17;
            int actual;


            // act
            numbers.Add(17);
            actual = numbers[0];


            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOne_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            words.Add("hello");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }                                       

        [TestMethod]
        public void AddFive_CheckIndexFour()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);

            actual = numbers[4];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFive_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            words.Add("hello");
            words.Add("how");
            words.Add("are");
            words.Add("you");
            words.Add("today");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }


    }
}



//// arrange
//Comparing comparing = new Comparing();
//bool expected = true;
//bool actual = false;


//// act
//comparing.result = true;
//comparing.CompareInts();
//if (comparing.firstValue == 1 && comparing.secondValue == 1)
//{
//    actual = true;
//}

// assert