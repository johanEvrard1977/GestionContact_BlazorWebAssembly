using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace GestionContact.Client.Services.Http.Repositories
{

    static class Constants
    {
        public const string URL_BASE = @"http://localhost:32205/api/";
    }
    public class ContactService : IContactService<ContactShared>
    {

        private readonly HttpClient _client;
        private readonly LocalStorage _storage;
        public ContactService(HttpClient client, LocalStorage storage)
        {
            _client = client;
            _storage = storage;
        }

        public async Task<HttpResponseMessage> Delete(int id)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Bearer ", _storage["token"]));

            HttpResponseMessage responseMessage = await Task.Run(() => _client.DeleteAsync($"{Constants.URL_BASE}Contact/" + id));
            return responseMessage;
        }

        public async Task<IEnumerable<ContactShared>> Get(int userId)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Bearer ", _storage["token"]));
            return await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<ContactShared>>(
                 await _client.GetStreamAsync($"Contact/{userId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ContactShared> GetOne(int id, int userId)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Bearer ", _storage["token"]));
            return await System.Text.Json.JsonSerializer.DeserializeAsync<ContactShared>(
                await _client.GetStreamAsync($"Contact/{id}/{userId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> Post(ContactShared entity)
        {
            _client.DefaultRequestHeaders.Clear(); 
            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Bearer ", _storage["token"]));
            string json = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            return await Task.Run(() => _client.PostAsync($"{Constants.URL_BASE}Contact", content));

        }

        public async Task<HttpResponseMessage> Put(int id, ContactShared entity)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Authorization", string.Concat("Bearer ", _storage["token"]));
            string json = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            return await Task.Run(() => _client.PutAsync($"{Constants.URL_BASE}Contact/" + id, content));

        }
    }
}