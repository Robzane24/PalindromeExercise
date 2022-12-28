using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("work", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var instance = new WordSmith();

            var actual = instance.IsAPalindrome(word);

            Assert.Equal(expected, actual);

            
        }
    }
}
