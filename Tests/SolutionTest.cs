using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NUnit.Framework;
using SoftwareEngineerDigitalStack;

namespace DataStructuresAlgorithmsDigitalStack.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void CountBits_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            int n = 5;
            int[] expected = { 0, 1, 1, 2, 1, 2 };

            // Act
            int[] result = Solution.CountBits(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzBuzz_ValidInput_PrintsFizzBuzz()
        {
            // Arrange
            int n = 15;
            string expectedOutput = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Solution.FizzBuzz(n);
                string output = sw.ToString();
                // Assert
                Assert.AreEqual(expectedOutput, output);
            }
        }

        [Test]
        public void ContainsDuplicate_ArrayWithDuplicates_ReturnsTrue()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };

            // Act
            bool result = Solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ReverseString_ValidInput_ReversesString()
        {
            // Arrange
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            char[] expected = { 'o', 'l', 'l', 'e', 'h' };

            // Act
            char[] result = Solution.ReverseString(s);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}