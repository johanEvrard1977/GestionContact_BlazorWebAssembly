using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using GestionContact.Client.Services.Http.Interfaces;
using System.Net;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using System.Text;
using GestionContact.Client.Models;
using GestionContact.Client.Dto;

namespace GestionContact.Client.Services.Http.Repositories
{
    public class UserService : IUserService<UserShared>
    {
        private readonly HttpClient _client;
        private readonly LocalStorage _storage;
        public UserService(HttpClient client, LocalStorage storage)
        {
            _client = client;
            _storage = storage;
        }

        public async Task<HttpResponseMessage> Delete(int id, UserShared entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return await _client.PutAsync($"{Constants.URL_BASE}User/Delete/" + id, content);
        }

        public async Task<IEnumerable<UserShared>> Get(int userId)
        {
            return await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<UserShared>>(
                 await _client.GetStreamAsync($"User/{userId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<UserShared> GetOne(int id)
        {
            return await System.Text.Json.JsonSerializer.DeserializeAsync<UserShared>(
                await _client.GetStreamAsync($"User/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> Post(UserShared entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return await _client.PostAsync($"{Constants.URL_BASE}User", content);
        }

        public async Task<HttpResponseMessage> Put(int id, UserShared entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return await _client.PutAsync($"{Constants.URL_BASE}User/" + id, content);
        }

        public async Task<HttpResponseMessage> Login(LoginDtoShared entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            using HttpRequestMessage req = new(HttpMethod.Post, $"{Constants.URL_BASE}User/login");
            req.Content = new StringContent(json, Encoding.Default, "application/json");
            var response = await _client.SendAsync(req);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string contents = await response.Content.ReadAsStringAsync();
                LoginSuccessDtoShared userSucces = JsonConvert.DeserializeObject<LoginSuccessDtoShared>(contents);
                _storage["token"] = userSucces.Token;
                _storage["email"] = userSucces.Email;
                _storage["id"] = userSucces.Id.ToString();
                //_storage["role"] = userSucces.Roles.FirstOrDefault().ToString();
                _storage["expirationDate"] = userSucces.ExpirationDate.ToString();
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                await response.Content.ReadAsStringAsync();
            }

            return response;
        }
    }
}