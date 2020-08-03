using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD
        // CREATE
        public void AddContentToDirectory(StreamingContent banana)
        {
            _contentDirectory.Add(banana);
        }

        // READ
        public List<StreamingContent> GetDirectory()
        {
            return _contentDirectory;
        }

        // UPDATE


        // DELETE


    }
}
