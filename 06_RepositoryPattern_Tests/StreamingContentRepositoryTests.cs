using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent orange = new StreamingContent();

            repo.AddContentToDirectory(orange);

            List<StreamingContent> directory = repo.GetDirectory();

            bool directoryHasOrange = directory.Contains(orange);

            Assert.IsTrue(directoryHasOrange);
        }
    }
}
