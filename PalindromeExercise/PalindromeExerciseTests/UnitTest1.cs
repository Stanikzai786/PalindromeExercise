using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecAr", true)]
        [InlineData("kaYak", true)]
        [InlineData("Mom", true)]
        [InlineData("Hello", false)]
        [InlineData("banana", false)]
        [InlineData("level", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();

            //Act
            var actual = instance.IsAPalindrome(word);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
