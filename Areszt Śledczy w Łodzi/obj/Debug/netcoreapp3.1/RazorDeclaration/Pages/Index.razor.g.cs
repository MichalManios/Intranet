#pragma checksum "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62812a82f95f1aab20bf972e6927da8eec51861b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Areszt_Śledczy_w_Łodzi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Areszt_Śledczy_w_Łodzi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using Areszt_Śledczy_w_Łodzi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
using Areszt_Śledczy_w_Łodzi.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
using ASdatabase;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
       

    private bool bShowActual = true;
    private ColorViewModel colorViewModel1, colorViewModel2, colorViewModel3;
    private Areszt_Śledczy_w_Łodzi.Models.SizeFontViewModel sizeFontViewModel1, sizeFontViewModel2, sizeFontViewModel3;
    private string fileName { get; set; }
    private bool bActual { get; set; }
    private bool bShow { get; set; }
    LoadOldZarzadzenia loadOldZarzadzenia;

    void GoToLogin()
    {
        NavigationManager.NavigateTo("/Identity/Account/Login", true);
    }

    protected override async Task OnInitializedAsync()
    {
        loadOldZarzadzenia = new LoadOldZarzadzenia(zarzadzenieRepository);
        fileName = "";
        bActual = false;
        bShow = false;
        InitializeColor();
        InitializeFont();
        await CreateAdminAccount();
    }

    public void InitializeColor()
    {
        colorViewModel1 = new ColorViewModel()
        {
            ColorName = "Niebieski",
            ColorValue = "#1d1880"
        };
        colorViewModel2 = new ColorViewModel()
        {
            ColorName = "Zielony",
            ColorValue = "#1CD10C"
        };
        colorViewModel3 = new ColorViewModel()
        {
            ColorName = "Czerwony",
            ColorValue = "#B80211"
        };
        colorServices.AddNewColor(colorViewModel1);
        colorServices.AddNewColor(colorViewModel2);
        colorServices.AddNewColor(colorViewModel3);
    }

    public void InitializeFont()
    {
        sizeFontViewModel1 = new Models.SizeFontViewModel()
        {
            FontSize = 20
        };
        sizeFontViewModel2 = new Models.SizeFontViewModel()
        {
            FontSize = 36
        };
        sizeFontViewModel3 = new Models.SizeFontViewModel()
        {
            FontSize = 44
        };
        fontServices.AddNewFontSize(sizeFontViewModel1);
        fontServices.AddNewFontSize(sizeFontViewModel2);
        fontServices.AddNewFontSize(sizeFontViewModel3);
    }


    private IList<AuthenticationScheme> ExternalLogins { get; set; }

    private async Task CreateAdminAccount()
    {
        ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList();



        //if (userManager.FindByNameAsync("Admin").IsCompletedSuccessfully == false)
        //{
        var user = new IdentityUser { UserName = "Admin" };
        var result = await userManager.CreateAsync(user, "789Ka;oz");
        if (result.Succeeded)
        {
            var RoleResult = await roleManager.FindByNameAsync("ADMIN");
            if (RoleResult == null)
            {
                // Create
                await roleManager.CreateAsync(new IdentityRole("ADMIN"));
            }
            await userManager.AddToRoleAsync(user, "ADMIN");
        }

        // }

    }

    void GoToChangePassword()
    {
        NavigationManager.NavigateTo("Identity/Account/Manage/ChangePassword", true);
    }

    void ShowDown()
    {
        bShow = true;
    }
    void ShowUp()
    {
        bShow = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Areszt_Śledczy_w_Łodzi.Services.FontSizeServices fontServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Areszt_Śledczy_w_Łodzi.Services.ColorServices colorServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IZarzadzenieRepository zarzadzenieRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> signInManager { get; set; }
    }
}
#pragma warning restore 1591
