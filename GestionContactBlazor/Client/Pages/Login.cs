using GestionContact.Client.Dto;
using GestionContact.Client.Models;
using GestionContact.Client.Services.Http.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Extensions;
using System.Net;

namespace GestionContact.Client.Pages
{
    public partial class Login
    {
        private readonly LoginDtoShared user = new();
        private string InvalidCredentialText = "";
        [Inject]
        IUserService<UserShared> RepoUser { get; set; }
        [Inject]
        NavigationManager UriHelper { get; set; }


        private async void HandleValidSubmit()
        {

            var response = await RepoUser.Login(user);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    UriHelper.NavigateTo("/.");
                    break;
                case HttpStatusCode.Unauthorized:
                    InvalidCredentialText = "email or password is not valid";
                    break;
            }
        }
    }
}