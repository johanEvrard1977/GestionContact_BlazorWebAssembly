#pragma checksum "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e53a7737e8722e9e7ddef589a2f909fded1fb16"
// <auto-generated/>
#pragma warning disable 1591
namespace GestionContact.Client.Shared
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
#line 5 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-zkk5cchzq0");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-zkk5cchzq0");
            __builder.OpenComponent<GestionContact.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-zkk5cchzq0");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-zkk5cchzq0");
#nullable restore
#line 14 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
             if (storage["token"] != null && storage["email"] != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "dropdown");
            __builder.AddAttribute(16, "b-zkk5cchzq0");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary dropdown-toggle");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                                                                                        ()=>expandSubNav = !expandSubNav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "b-zkk5cchzq0");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                     tinfo.ToTitleCase(storage["email"])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                 if (expandSubNav)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                                                     Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\n                    Sign out\n                ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                          }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<a href=\"/Login\" b-zkk5cchzq0>\n                Sign in\n            </a>\n            ");
            __builder.AddMarkupContent(29, "<a href=\"/Administrations/Users/create\" b-zkk5cchzq0>\n                Register\n            </a>");
#nullable restore
#line 35 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "content px-4");
            __builder.AddAttribute(33, "b-zkk5cchzq0");
            __builder.AddContent(34, 
#nullable restore
#line 38 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Sources\Blazor\GestionContactBlazor\Client\Shared\MainLayout.razor"
        private bool expandSubNav;
    private static TextInfo tinfo = CultureInfo.CurrentCulture.TextInfo;
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    async Task Logout()
    {
        storage.RemoveItem("email");
        storage.RemoveItem("token");
        uriHelper.NavigateTo("/.");
        await JS.InvokeAsync<bool>("Refresh");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage storage { get; set; }
    }
}
#pragma warning restore 1591