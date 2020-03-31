﻿using System;
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
            numbers.Add(1);
            actual = numbers.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwo_CheckCountTwo()
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
        public void AddThree_CheckCountThree()
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
        public void AddFour_CheckCountFour()
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
        public void AddFive_CheckCountFive()
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
        public void AddOne_CheckIndexZero()
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
        public void AddTwo_CheckIndexOne()
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
        public void AddThree_CheckIndexTwo()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 3;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            actual = numbers[2];

            Assert.AreEqual.(expected, actual);
        }

        [TestMethod]
        public void AddFour_CheckIndexThree()
        {
            CustomList<int> numbers = new CustomList<int>();
            int expected = 4;
            int actual;

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            actual = numbers[3];

            Assert.AreEqual.(expected, actual);
        }

        [TestMethod]
        public void AddFive_CheckIndexFour()
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
        public void AddOne_CheckCapacity()
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
        public void AddTwo_CheckCapacity()
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
        public void AddThree_CheckCapacity()
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
        public void AddFour_CheckCapacity()
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
        public void AddFive_CheckCapacity()
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