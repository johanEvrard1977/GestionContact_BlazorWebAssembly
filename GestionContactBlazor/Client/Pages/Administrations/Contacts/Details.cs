using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace GestionContact.Client.Pages.Administrations.Contacts
{
    public partial class Details
    {
        [Parameter] public int Id { get; set; }
        //[Parameter] public int UserId { get; set; }
        private ContactShared entity = new();
        [Inject]
        IContactService<ContactShared> RepoContact { get; set; }
        [Inject]
        LocalStorage Storage { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await RepoContact.GetOne(Id, int.Parse(Storage.GetItem("id")));
        }
    }
}
