using DataFromGUS.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using PicturesOfCSO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataFromGUS.Service
{
    public class GUSdbwAreaAPIService : IGUSdbwAreaAPIService
    {
        private readonly HttpClient httpClient;
        public GUSdbwAreaAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

            this.httpClient.BaseAddress = new Uri("https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area");
        }
        public async Task<ObservableCollection<Area>> GetAreasDataAsync()
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                var response = await _httpClient.GetAsync(httpClient.BaseAddress);
                var json = await response.Content.ReadAsStringAsync();

                var areas = JsonSerializer.Deserialize<List<Area>>(json);
                return new ObservableCollection<Area>(areas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
                return new ObservableCollection<Area>();
            }
        }
    }

}
