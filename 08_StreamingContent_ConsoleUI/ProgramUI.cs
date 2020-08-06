﻿using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    class ProgramUI
    {
        private bool _isRunning = true;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        // Entry point to our UI, it starts our user interface
        public void Start()
        {
            SeedContentList();
            RunMenu();
        }

        // This method has the task of running the menu
        private void RunMenu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }
        }

        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine(
                            "Welcome to the Streaming Content Management System!\n" +
                            "Select Menu Item:\n" +
                            "1. Show All Streaming Content\n" +
                            "2. Find Streaming Content By Title\n" +
                            "3. Add New Streaming Content\n" +
                            "4. Update Existing Streaming Content\n" +
                            "5. Remove Streaming Content\n" +
                            "6. Exit");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    // Show All Content
                    DisplayAllContent();
                    break;
                case "2":
                    // Find Content By Title
                    DisplayContentByTitle();
                    break;
                case "3":
                    // Add New Content
                    CreateNewContent();
                    break;
                case "4":
                    // Update Content
                    break;
                case "5":
                    // Remove Content
                    break;
                case "6":
                    // Exit
                    _isRunning = false;
                    return;
                default:
                    // Invalid selection
                    //Console.WriteLine("Invalid input.");
                    return;
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

        // Show All Content
        private void DisplayAllContent()
        {
            // Get content
            // Go to the repository and get the directory
            List<StreamingContent> listOfContent = _streamingRepo.GetDirectory();

            // Display content
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
        }

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Release Year: {content.ReleaseYear}\n" +
                $"Genre: {content.Genre}\n" +
                $"Stars: {content.StarRating}\n" +
                $"Maturity Rating: {content.MaturityRating}\n" +
                $"Family Friendly: {(content.IsFamilyFriendly ? "Yes it is!" : "No it's not.")}\n");
        }

        // Find Content By Title
        private void DisplayContentByTitle()
        {
            // Prompt the user to give us a title
            Console.Write("Enter a title: ");

            // Get and store the user's input
            string title = Console.ReadLine();

            // Find the matching content in the repository
            StreamingContent searchResult = _streamingRepo.GetContentByTitle(title);

            // Display the content to the console if found
            if (searchResult != null)
            {
                DisplayContent(searchResult);
            }
            // If there's no content found, go ahead and say so
            else
            {
                Console.WriteLine("Invalid title. Could not find any results.");
            }
        }

        // Add New Content
        private void CreateNewContent()
        {
            // Gather values for all properties for the StreamingContent object
            // Title
            Console.Write("Enter a title: ");
            string title = Console.ReadLine();

            // Description
            Console.Write("Enter a description: ");
            string description = Console.ReadLine();

            // MaturityRating
            //G, PG, TV_Y, PG13, R, NC17, TV_PG, TV_14, TV_MA
            MaturityRating maturityRating = GetMaturityRating();

            // StarRating
            Console.Write("Enter the star rating (1-5): ");
            // Maybe refactor later so it won't break when not given a number
            double starRating = double.Parse(Console.ReadLine());

            // ReleaseYear
            Console.Write("Enter the release year: ");
            int releaseYear = int.Parse(Console.ReadLine());

            // GenreType
            GenreType genre = GetGenreType();

            // Construct a StreamingContent object given the above values
            StreamingContent newContent = new StreamingContent(title, description, maturityRating, starRating, releaseYear, genre);

            // Add the StreamingContent object to the repository ("Save" the content)
            _streamingRepo.AddContentToDirectory(newContent);
        }

        private MaturityRating GetMaturityRating()
        {
            Console.WriteLine("Select a Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. TV Y\n" +
                "4. PG13\n" +
                "5. R\n" +
                "6. NC17\n" +
                "7. TV PG\n" +
                "8. TV 14\n" +
                "9. TV MA");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return MaturityRating.G;
                    case "2":
                        return MaturityRating.PG;
                    case "3":
                        return MaturityRating.TV_Y;
                    case "4":
                        return MaturityRating.PG13;
                    case "5":
                        return MaturityRating.R;
                    case "6":
                        return MaturityRating.NC17;
                    case "7":
                        return MaturityRating.TV_PG;
                    case "8":
                        return MaturityRating.TV_14;
                    case "9":
                        return MaturityRating.TV_MA;
                }

                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        private GenreType GetGenreType()
        {
            Console.WriteLine("Select a Genre:\n" +
                "1. Action/Adventure\n" +
                "2. Action\n" +
                "3. Thriller\n" +
                "4. Horror\n" +
                "5. Comedy\n" +
                "6. Bromance\n" +
                "7. Mystery\n" +
                "8. SciFi");

            while (true)
            {
                //string genreString = Console.ReadLine();
                //int genreId = int.Parse(genreString);
                //GenreType genre = (GenreType)genreId - 1;
                //return genre;

                string genreString = Console.ReadLine();
                bool parseResult = int.TryParse(genreString, out int parsedNumber);
                if (parseResult && parsedNumber >= 1 && parsedNumber < 9)
                {
                    GenreType genre = (GenreType)parsedNumber - 1;
                    return genre;
                }

                //if (int.TryParse(Console.ReadLine(), out int genreId))
                //{
                //    return (GenreType)genreId - 1;
                //}

                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        // Update Content

        // Remove Content


        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tyre comes to life and kills people.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);
            StreamingContent toyStory = new StreamingContent("Toy Story", "Wonderful childhood memory.", MaturityRating.G, 10, 1995, GenreType.Bromance);
            StreamingContent helloKitty = new StreamingContent("Hello Kitty Island Adventure", "Insert description here.", MaturityRating.R, 8.9, 1932, GenreType.Horror);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(helloKitty);
        }
    }
}
