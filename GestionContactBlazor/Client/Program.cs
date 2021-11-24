using Blazored.Modal;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using GestionContact.Client.Services.Http.Repositories;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace GestionContact.Client
{
    static class Constants
    {
        public const string URL_BASE = @"http://localhost:32205/api/";
    }
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHttpClient<IContactService<ContactShared>, ContactService>(client => client.BaseAddress = new Uri(Constants.URL_BASE));
            builder.Services.AddHttpClient<IUserService<UserShared>, UserService>(client => client.BaseAddress = new Uri(Constants.URL_BASE));
            builder.Services.AddBlazoredModal();
            builder.Services.AddStorage();
            builder.Services.AddScoped<LocalStorage>();

            await builder.Build().RunAsync();
        }
    }
}
