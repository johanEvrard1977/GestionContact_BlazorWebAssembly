using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace GestionContact.Client.Pages.Administrations.Contacts
{
    public partial class Edit
    {
        [Parameter] public int Id { get; set; }

        private ContactShared entity = new();

        [Inject]
        IContactService<ContactShared> RepoContact { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        [Inject]
        LocalStorage Storage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            entity = await RepoContact.GetOne(Id, int.Parse(Storage.GetItem("id")));
        }

        async Task EditEntity()
        {
            await RepoContact.Put(Id, entity);
            await JsRuntime.InvokeAsync<bool>("Refresh");

        }

    }
}