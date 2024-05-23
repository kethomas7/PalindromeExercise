using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("house",false)]
        [InlineData("wow",true)]
        public void PalindromeTest(string word, bool expected)
        {

            //Arrange
            var wordSmithObject = new WordSmith();

            //Act
            var actual = wordSmithObject.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
