using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace MEnglish.Services
{
    public class NewsService
    {
        HttpClient client;
        public NewsService()
        {
            client = new HttpClient();
        }

        public async Task<News> GetNewsAsync(string url)
        {
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var news = JsonSerializer.Deserialize<News>(json);
            return news;
        }
    }
}
