using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bring in an HttpClient so we can use Http Methods
            HttpClient httpClient = new HttpClient();

            // Send my first request
            Task<HttpResponseMessage> getTask = httpClient.GetAsync("https://swapi.dev/api/people/1/");
            // Execute the task and get the result
            HttpResponseMessage response = getTask.Result;

            // Create and execute the async task
            HttpResponseMessage getResponse = httpClient.GetAsync("https://swapi.dev/api/people/1/").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Person personResponse = response.Content.ReadAsAsync<Person>().Result;
                Console.WriteLine(personResponse.BirthYear);

                foreach (string starshipUrl in personResponse.Starships)
                {
                    // Get Request
                    HttpResponseMessage starshipResponse = httpClient.GetAsync(starshipUrl).Result;
                    // Convert response to C# class
                    Starship starship = starshipResponse.Content.ReadAsAsync<Starship>().Result;
                    // Utilizing that class and its properties
                    Console.WriteLine(starship.Name);
                }
            }

            SWAPIService service = new SWAPIService();
            Person personTwo = service.GetPersonAsync("https://swapi.dev/api/people/10/").Result;
            if (personTwo != null)
            {
                Console.WriteLine(personTwo.Name);
                Console.WriteLine(personTwo.Starships.Count);

                foreach (var starshipUrl in personTwo.Starships)
                {
                    var starship = service.GetStarshipAsync(starshipUrl).Result;
                    Console.WriteLine(starship.Name);
                }
            }

            Person genericPerson = service.GetAsync<Person>("https://swapi.dev/api/people/6/").Result;
            if (genericPerson != null)
            {
                Console.WriteLine(genericPerson.Name);
            }
            else
            {
                Console.WriteLine("Target object doesn't exist.");
            }
        }
    }
}
