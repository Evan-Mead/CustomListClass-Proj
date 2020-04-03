using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace CustomListClassTests
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]
        public void Add_One_CheckCountOne()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            numbers.Add(1);
            actual = numbers.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_CheckCountTwo()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 2;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Three_CheckCountThree()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Four_CheckCountFour()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 4;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Five_CheckCountFive()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_CheckIndexZero()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            numbers.Add(1);
            actual = numbers[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_CheckIndexOne()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 2;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            actual = numbers[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Three_CheckIndexTwo()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            actual = numbers[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Four_CheckIndexThree()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 4;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            actual = numbers[3];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Five_CheckIndexFour()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            actual = numbers[4];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_One_CheckCapacity()
        {
            // arrange
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            // act
            words.Add("hello");
            actual = words.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            words.Add("hello");
            words.Add("how");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Three_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            words.Add("hello");
            words.Add("how");
            words.Add("are");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Four_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 4;
            int actual;

            words.Add("hello");
            words.Add("how");
            words.Add("are");
            words.Add("you");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Five_CheckCapacity()
        {
            CustomList<string> words = new CustomList<string>();
            int expected = 8;
            int actual;

            words.Add("hello");
            words.Add("how");
            words.Add("are");
            words.Add("you");
            words.Add("today");
            actual = words.Capacity;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_One_CheckCountFour()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
  
            numbers.Remove(5);

            actual = numbers.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Two_CheckCountThree()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(5);
            numbers.Remove(4);

            actual = numbers.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Three_CheckCountTwo()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 2;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(5);
            numbers.Remove(4);
            numbers.Remove(3);

            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Four_CheckCountOne()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(5);
            numbers.Remove(4);
            numbers.Remove(3);
            numbers.Remove(2);

            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Five_CheckCountZero()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 0;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(5);
            numbers.Remove(4);
            numbers.Remove(3);
            numbers.Remove(2);
            numbers.Remove(1);

            actual = numbers.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_One_CheckIndexThree()
        {
            // arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(1);

            actual = numbers[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Two_CheckIndexTwo()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(1);
            numbers.Remove(2);

            actual = numbers[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Three_CheckIndexOne()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(1);
            numbers.Remove(2);
            numbers.Remove(3);

            actual = numbers[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Four_CheckIndexZero()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(1);
            numbers.Remove(2);
            numbers.Remove(3);
            numbers.Remove(4);

            actual = numbers[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_Five_CheckIndex()
        {
            CustomList<int> numbers = new CustomList<int>();
            string expected = null;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Remove(5);
            numbers.Remove(4);
            numbers.Remove(3);
            numbers.Remove(2);
            numbers.Remove(1);

            actual = numbers[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_FirstDuplicate_CheckIndex()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 22;
            int actual;

            numbers.Add(22);
            numbers.Add(2);
            numbers.Add(9);
            numbers.Add(22);
            numbers.Add(8);

            numbers.Remove(22);

            actual = numbers[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_OneNumber_ToString()
        {
            CustomList<int> numbers = new CustomList<int>();
            string expected = "1";
            string actual;

            numbers.Add(1);

            actual = numbers.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoNumbers_ToString()
        {
            CustomList<int> numbers = new CustomList<int>();
            string expected = "2";
            string actual;

            numbers.Add(1);
            numbers.Add(2);

            actual = numbers.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_OneWord_ToString()
        {
            CustomList<string> words = new CustomList<string>();
            string expected = "hello";
            string actual;

            words.Add("hello");

            actual = words.ToString();

            Assert.AreEqual(expected, actual);
        }

        public void Add_TwoWords_ToString()
        {
            CustomList<string> words = new CustomList<string>();
            string expected = "hello there!";
            string actual;

            words.Add("hello ");
            words.Add("there!");

            actual = words.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_Test()
        {
            // arrange
            CustomList<string> words = new CustomList<string>();
            CustomList<int> listOne = { 1, 2, 3 };
            CustomList<int> listTwo = { 4, 5, 6 };
            CustomList<int> customList = { 1, 2, 3, 4, 5, 6 };
            string expected = "1, 2, 3, 4, 5, 6";
            string actual;

            // act
            actual = customList.Add;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}