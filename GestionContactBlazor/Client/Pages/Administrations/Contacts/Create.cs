using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace GestionContact.Client.Pages.Administrations.Contacts
{
    public partial class Create
    {
        [Parameter] public int Id { get; set; }
        private readonly ContactShared entity = new();
        [Inject]
        private IContactService<ContactShared> RepoContact { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }
        [Inject]
        LocalStorage Storage { get; set; }

        public async Task HandelValidSubmit()
        {
            entity.UserId = int.Parse(Storage.GetItem("id"));
            await RepoContact.Post(entity);
            await JsRuntime.InvokeAsync<bool>("Refresh");
        }
    }
}