using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(string url)
        {
            // Send Get Request
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Check to see if the response is OK
            if (response.IsSuccessStatusCode)
            {
                // Convert the response to a Person object
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            // If it's not okay, or not a success, return null
            return null;
        }

        public async Task<Starship> GetStarshipAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<Starship>();

            return null;
        }

        public async Task<T> GetAsync<T>(string url) where T : class
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<T>();

            return null;
        }
    }
}
