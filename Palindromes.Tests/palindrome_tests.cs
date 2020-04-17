using System;
using Xunit;

namespace Palindromes.Tests
{
    public class palindrome_tests
    {
        [Fact]
        public void stars_backward()
        {
            // Arrange - set up context for what will come in our test
            var word = "Stars";
            var expectedResult = false;
            var backwardsTests = new Backwards();

            // Act
            bool actualResult = backwardsTests.BackwardsTests(word);

            // Assert - typically use an assertion library. x-unit comes built in with one
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void second_backward_test()
        {
            // Arrange - set up context for what will come in our test
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var backwardsTests = new Backwards();

            // Act
            bool actualResult = backwardsTests.BackwardsTests(word);

            // Assert - typically use an assertion library. x-unit comes built in with one
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void some_men_backward_test()
        {
            // Arrange - set up context for what will come in our test
            var word = "Some men interpret nine memos";
            var expectedResult = true;
            var backwardsTests = new Backwards();

            // Act
            bool actualResult = backwardsTests.BackwardsTests(word);

            // Assert - typically use an assertion library. x-unit comes built in with one
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
