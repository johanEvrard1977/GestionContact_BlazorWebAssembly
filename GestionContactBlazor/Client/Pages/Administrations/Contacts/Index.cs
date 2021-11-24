using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using Blazored.Modal;
using Blazored.Modal.Services;
using System.Threading.Tasks;
using System.Linq;
using GestionContact.Client.Services.Http.Interfaces;
using GestionContact.Client.Models;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

namespace GestionContact.Client.Pages.Administrations.Contacts
{
    public partial class Index
    {
        IEnumerable<ContactShared> contacts;
        [Inject]
        IContactService<ContactShared> RepoContact { get; set; }
        [Inject]
        [CascadingParameter] public IModalService Modal { get; set; }
        [Inject]
        public IJSRuntime Js { get; set; }
        
        [Inject] 
        LocalStorage Storage { get; set; }

        public void ShowEditEntity(int contactId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(Edit.Id), contactId);

            Modal.Show<Edit>("Edit Contact", parameters);
        }
        //public void ShowAddEntity(int contactId)
        //{
        //    var parameters = new ModalParameters();
        //    parameters.Add(nameof(Create.Id), contactId);

        //    Modal.Show<Create>("Add Contact", parameters);
        //}
        protected override async Task OnInitializedAsync()
        {
             await GetContacts();
        }

        private async Task GetContacts()
        {
            contacts = await RepoContact.Get(int.Parse(Storage.GetItem("id")));
        }
        async Task Delete(int Id)
        {
            ContactShared entity = contacts.First(x => x.Id == Id);
            if (await Js.InvokeAsync<bool>("confirm", $"Do you want to delete ({entity.Id}) Record?"))
            {
                var response = await RepoContact.Delete(Id);
                await OnInitializedAsync();
            }
        }
    }
}
