using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using LinearDataStructures;

namespace UnitTests
{
    [TestClass]
    public class LongestSequenceUnitTests
    {
        [TestMethod]
        public void CreatingEmptyAndRun()
        {
            List<int> ints = new List<int>();
            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);
            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatingWith1AndRun()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);
            Assert.AreEqual(1, ints.Count);

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);
            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatingWith10And2SameAndRun()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);
            ints.Add(1);
            
            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);
            Assert.AreEqual(2, ints.Count);

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);
            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatingWith10NegativeAndRun()
        {
            List<int> ints = new List<int>();
            ints.Add(-1);
            ints.Add(-2);
            ints.Add(-3);
            ints.Add(-4);
            ints.Add(-5);
            ints.Add(-6);
            ints.Add(-7);
            ints.Add(-8);
            ints.Add(-9);
            ints.Add(-1);

            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);
            Assert.AreEqual(2, ints.Count);

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);
            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatingWith10SameAndRun()
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ints.Add(1);
            }

            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);
            Assert.AreEqual(10, ints.Count);

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);

            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreatingWith20AllTypesAndRun()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(3);
            ints.Add(2);
            ints.Add(1);
            ints.Add(1);
            ints.Add(13);
            ints.Add(-5);
            ints.Add(-1);
            ints.Add(3);
            ints.Add(6);
            ints.Add(7);
            ints.Add(111);
            ints.Add(-5);
            ints.Add(-1);
            ints.Add(0);

            ints = LongestSequenceOfEqualElements04.GetMostCommonElementList(ints);
            Assert.AreEqual(3, ints.Count); // 3 1-s

            string actual = LongestSequenceOfEqualElements04.GetLongestSequence(ints);
            string expected = ExpectedOutputs(ints);
            Assert.AreEqual(expected, actual);
        }

        private string ExpectedOutputs(List<int> intsList)
        {   
            if (intsList.Count > 0)
            {
                StringBuilder output = new StringBuilder();

                output.AppendFormat("The most times found number is: {0}", intsList[0]);
                output.Append("{ ");

                int intsCount = intsList.Count;
                for (int i = 0; i < intsCount; i++)
                {
                    output.Append(intsList[i].ToString() + " ");
                }

                output.AppendLine("}");
                return output.ToString();
            }
            return "No Numbers In The List";
        }
    }
}
