#pragma checksum "C:\Sources\Blazor\GestionContactBlazor\Client\Pages\Administrations\Contacts\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd60a1d9529640235679ecc34b504567d83a6489"
// <auto-generated/>
#pragma warning disable 1591
namespace GestionContact.Client.Pages.Administrations.Contacts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Services.Http.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Services.Http.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using GestionContact.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Sources\Blazor\GestionContactBlazor\Client\_Imports.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Administrations/Contacts/Create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create</h3>\n\n");
            __builder.OpenComponent<GestionContact.Client.Pages.Administrations.Contacts.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Contact");
            __builder.AddAttribute(3, "entity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GestionContact.Client.Models.ContactShared>(
#nullable restore
#line 5 "C:\Sources\Blazor\GestionContactBlazor\Client\Pages\Administrations\Contacts\Create.razor"
                                           entity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Sources\Blazor\GestionContactBlazor\Client\Pages\Administrations\Contacts\Create.razor"
                      HandelValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
