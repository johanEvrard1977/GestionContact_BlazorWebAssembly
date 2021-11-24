using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using GestionContact.Client.Services.Http.Interfaces;
using GestionContact.Client.Models;

namespace GestionContactClient.Pages.Administrations.Users
{
    public partial class Create
    {
        [Parameter] public int Id { get; set; }
        readonly UserShared entity = new UserShared();
        [Inject]
        IUserService<UserShared> _repoUser { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }


        public async Task HandelValidSubmit()
        {
            await _repoUser.Post(entity);
            await JsRuntime.InvokeAsync<bool>("Refresh");
        }
    }
}