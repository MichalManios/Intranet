#pragma checksum "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62812a82f95f1aab20bf972e6927da8eec51861b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<div class=\"row col-12\"> <br> </div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row col-12");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"col-5\">\r\n        <h1 id=\"HeaderStart\">Areszt Śledczy w Łodzi</h1>\r\n    </div>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-1");
                __builder2.AddAttribute(10, "id", "admin");
                __builder2.AddMarkupContent(11, "\r\n\r\n                ");
                __builder2.OpenElement(12, "button");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                  ShowDown

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "type", "submit");
                __builder2.AddAttribute(15, "class", "MyButton");
                __builder2.AddContent(16, "\\/");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-3");
                __builder2.AddAttribute(21, "id", "admin");
                __builder2.AddMarkupContent(22, "\r\n\r\n                ");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                  GoToChangePassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "type", "submit");
                __builder2.AddAttribute(26, "class", "MyButton");
                __builder2.AddMarkupContent(27, "Zmień hasło");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.AddMarkupContent(30, "<div class=\"col-3\" id=\"admin\">\r\n                <form method=\"post\" action=\"Identity/Account/Logout\">\r\n                    <button type=\"submit\" class=\"MyButton\">Wyloguj</button>\r\n                </form>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
             if (bShow)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                ");
                __builder2.AddMarkupContent(32, "<div class=\"row col-12\"> <br> </div>\r\n                ");
                __builder2.AddMarkupContent(33, "<div class=\"row col-12\"> <br> </div>\r\n                ");
                __builder2.AddMarkupContent(34, "<div class=\"row col-5\"> <br> </div>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "box row col-7");
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.AddMarkupContent(38, "<div class=\"row col-1\"> <br> </div>\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-3");
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.AddMarkupContent(42, "<label class=\"Labels\">Nazwa pliku:</label>\r\n                        ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "class", "col-12 Inputs");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "placeholder", "Nazwa pliku");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                                                        fileName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fileName = __value, fileName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-3");
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.AddMarkupContent(54, "<div class=\"col-12\"><br></div>\r\n                        ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "type", "checkbox");
                __builder2.AddAttribute(57, "id", "instruction");
                __builder2.AddAttribute(58, "name", "instruction");
                __builder2.AddAttribute(59, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                                                                          bActual

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => bActual = __value, bActual));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n");
#nullable restore
#line 57 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                         if (bActual)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "                            ");
                __builder2.AddMarkupContent(63, "<label class=\"Labels\" for=\"instruction\">Aktualne</label>\r\n");
#nullable restore
#line 60 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "                            ");
                __builder2.AddMarkupContent(65, "<label class=\"Labels\" for=\"instruction\">Nieaktualne</label>\r\n");
#nullable restore
#line 64 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(66, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-3");
                __builder2.AddAttribute(70, "id", "admin");
                __builder2.AddMarkupContent(71, "\r\n\r\n                        ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                            ()=>loadOldZarzadzenia.Load(fileName, bActual)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "type", "submit");
                __builder2.AddAttribute(75, "class", "MyButton");
                __builder2.AddMarkupContent(76, "Załaduj stare zarządznia");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n");
#nullable restore
#line 69 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                         if (loadOldZarzadzenia.bEndSave)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(78, "                            ");
                __builder2.AddMarkupContent(79, "<p>Zakończono zapis do bazy.</p>\r\n");
#nullable restore
#line 72 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-1");
                __builder2.AddAttribute(84, "id", "admin");
                __builder2.AddMarkupContent(85, "\r\n\r\n                        ");
                __builder2.OpenElement(86, "button");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                          ShowUp

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "type", "submit");
                __builder2.AddAttribute(89, "class", "MyButton");
                __builder2.AddContent(90, "/\\");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                   \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n");
#nullable restore
#line 81 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(94, "        ");
            }
            ));
            __builder.AddAttribute(95, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-6");
                __builder2.AddAttribute(99, "id", "admin");
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Index.razor"
                                  GoToLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "class", "MyButton");
                __builder2.AddContent(104, "Admin");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n");
            __builder.AddMarkupContent(109, "<div class=\"row col-12\"> <br> </div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(110, "<div class=\"row col-12 lines\">\r\n    <hr id=\"line1\">\r\n</div>\r\n");
            __builder.AddMarkupContent(111, "<div class=\"row col-12 lines\">\r\n    <hr id=\"line2\">\r\n</div>\r\n");
            __builder.AddMarkupContent(112, "<div class=\"row col-12 lines\">\r\n    <hr id=\"line3\">\r\n</div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(113, "<div class=\"row col-12\"> <br> </div>\r\n\r\n");
            __builder.AddMarkupContent(114, "<div class=\"row col-12\">\r\n    <img class=\"img\" src=\"/Photos/ASLodz.jpg\" asp-append-version=\"true\">\r\n</div>");
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
