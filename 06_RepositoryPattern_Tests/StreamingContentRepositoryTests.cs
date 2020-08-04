using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);

            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange --> Setting up the playing field
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent orange = new StreamingContent();
            repo.AddContentToDirectory(orange);

            // Act --> Get or run the code we want to test
            List<StreamingContent> directory = repo.GetDirectory();

            bool directoryHasOrange = directory.Contains(orange);

            // Assert --> Using the Assert class to verify the expected outcome
            Assert.IsTrue(directoryHasOrange);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // This will be replaced with our [TestInitialize] method
            //Arrange();

            // Act
            bool removeResult = _repo.DeleteExistingContent(_content);

            // Assert
            Assert.IsTrue(removeResult);
        }
    }
}
