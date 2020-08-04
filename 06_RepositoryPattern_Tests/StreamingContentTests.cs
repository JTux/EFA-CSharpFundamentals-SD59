using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriend(MaturityRating rating, bool expectedFamilyFriendly)
        {
            // Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.MaturityRating = rating;

            // Assert
            Assert.AreEqual(expectedFamilyFriendly, content.IsFamilyFriendly);
        }
    }
}
