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
        public void AddContentToDirectory(StreamingContent content)
        {
            _contentDirectory.Add(content);
        }

        // READ
        // Get All StreamingContent
        public List<StreamingContent> GetDirectory()
        {
            return _contentDirectory;
        }

        // Get One StreamingContent By Title
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    return item;
                }
            }

            return null;
        }

        // UPDATE
        public bool UpdateExistingContent(StreamingContent updatedContent, string originalTitle)
        {
            StreamingContent content = GetContentByTitle(originalTitle);
            if(content != null)
            {
                int itemIndex = _contentDirectory.IndexOf(content);
                _contentDirectory[itemIndex] = updatedContent;
                return true;
            }

            return false;


            // Find the target content by originalTitle
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.Title.ToLower() == originalTitle.ToLower())
                {
                    // Update the target content with updatedContent properties/values

                    //item.Title = updatedContent.Title;
                    //item.Description = updatedContent.Description;
                    //item.Genre = updatedContent.Genre;
                    //item.MaturityRating = updatedContent.MaturityRating;
                    //item.ReleaseYear = updatedContent.ReleaseYear;
                    //item.StarRating = updatedContent.StarRating;

                    // Find the index that item is at
                    int itemIndex = _contentDirectory.IndexOf(item);
                    // Slot in updatedContent into that index on the List
                    _contentDirectory[itemIndex] = updatedContent;

                    return true;
                }
            }

            return false;
        }

        // DELETE
        public bool DeleteExistingContent(StreamingContent content)
        {
            return _contentDirectory.Remove(content);
        }

        // Delete Content By Title
        // Give a title (take in) parameter
        // Find the content by its title
        // If I find that content, delete the content
        // return a true/false whether it worked or not
        public bool DeleteContentByTitle(string title)
        {
            StreamingContent targetContent = GetContentByTitle(title);
            return DeleteExistingContent(targetContent);
        }
    }
}
