#pragma checksum "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Ogloszenia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "289855d09e2e8a45d3cd619bf3bbe5efb6f8b272"
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
    using System.Linq;
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
#line 3 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Ogloszenia.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Ogloszenia.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Ogloszenia.razor"
using Areszt_Śledczy_w_Łodzi.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ogloszenia")]
    public partial class Ogloszenia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 230 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Ogloszenia.razor"
       
    string sContentOgloszenie { get; set; }
    string sContentLink { get; set; }
    string scolor { get; set; }
    string sfont { get; set; }
    string scaseFontColor { get; set; }
    string sURL { get; set; }
    string sURLToFile { get; set; }
    bool bLinkAdd { get; set; }
    bool bURLlink { get; set; }
    bool bURLfile { get; set; }
    bool bBlockSaving { get; set; }
    int IdEditingOgloszenie { get; set; }
    List<Areszt_Śledczy_w_Łodzi.Models.OgloszenieViewModel> ogloszenieViewModels;
    Areszt_Śledczy_w_Łodzi.Models.OgloszenieViewModel ogloszenieViewModel;
    List<ASdatabase.Color> colors;
    string Message2 { get; set; }
    bool bCheckSave { get; set; }

    string Message = "Nie wybrałeś żadnego pliku";
    IFileListEntry selectedFiles;

    async Task ChoiceFileToUpload(IFileListEntry[] files)
    {
        bBlockSaving = true;
        selectedFiles = files.FirstOrDefault();
        if (selectedFiles != null)
        {
            await fileUpload.UploadAsync(selectedFiles, "Ogloszenia");

            Message = $"Plik oczekuje na upload: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
        }
        this.StateHasChanged();
    }

    void UploadFile()
    {
        if (selectedFiles != null)
        {
            Message = $"Trwa wrzucanie pliku...";
            fileUpload.SendToServer();
            Message = $"Zakończono ładowanie pliku: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
            sURLToFile = @"http://localhost:5000/Ogloszenia/" + selectedFiles.Name;
            this.StateHasChanged();

        }
        else
        {
            Message = $"Nie ma wybranego pliku do umieszczenia go na serwerze!!!";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        scolor = "niebieski";
        sfont = "20px";
        scaseFontColor = sfont + scolor;
        IdEditingOgloszenie = -1;
        sContentOgloszenie = "";
        sContentLink = "";
        Message2 = "Nie wszystkie pola wymagane zostały wypełnione!!!";
        sURL = "";
        sURLToFile = "";
        bLinkAdd = false;
        bURLlink = false;
        bURLfile = false;
        bBlockSaving = false;
        bCheckSave = true;

        ogloszenieViewModels = new List<Models.OgloszenieViewModel>();
        ogloszenieViewModel = new Models.OgloszenieViewModel();
        colors = new List<ASdatabase.Color>();
        await Task.Run(() =>
        {
            colors = colorServices.GetAllColors();

            ogloszenieViewModels = ogloszenieServices.GetAllOgloszenia();
        });
    }

    void ColorSelection(ChangeEventArgs args)
    {
        scolor = args.Value.ToString();
        scaseFontColor = sfont + scolor;
    }

    void FontSelection(ChangeEventArgs args)
    {
        sfont = args.Value.ToString() + "px";
        scaseFontColor = sfont + scolor;
    }

    void EditOgloszenie(int OgloszenieId)
    {
        var OgloszenieEntity = ogloszenieServices.FindOgloszenieById(OgloszenieId);
        sContentOgloszenie = OgloszenieEntity.Advertisement;
        var colorEntity = colorServices.FindColorById(OgloszenieEntity.ColorId);
        scolor = colorEntity.ColorName.ToLower();
        var fontEntity = fontServices.FindFontSizeById(OgloszenieEntity.SizeFontId);
        sfont = fontEntity.FontSize.ToString() + "px";
        IdEditingOgloszenie = OgloszenieEntity.Id;
        scaseFontColor = sfont + scolor;

        sContentLink = OgloszenieEntity.AdvertisementURL;
        sURL = OgloszenieEntity.URL;
        navigationManager.NavigateTo("/ogloszenia", false);
    }

    void SaveOgloszenie()
    {
        var colorId = colorServices.FindColorByName(scolor);
        var fontId = fontServices.FindFontSizeBySize(sfont);
        var ogloszenieEntity = ogloszenieServices.FindOgloszenieById(IdEditingOgloszenie);
        ogloszenieViewModel = asMapper.Map(ogloszenieEntity);
        if (bURLfile) sURL = sURLToFile;

        bCheckSave = CheckCanSafe();
        if (bCheckSave)
        {
            if (ogloszenieViewModel == null)
            {
                ogloszenieViewModel = new Models.OgloszenieViewModel()
                {
                    Advertisement = sContentOgloszenie,
                    ColorId = colorId.Id,
                    SizeFontId = fontId.Id,
                    AdvertisementURL = sContentLink,
                    URL = sURL

                };
                ogloszenieServices.SaveUpdateOgloszenie(IdEditingOgloszenie, ogloszenieViewModel);

                bLinkAdd = false;
                bURLlink = false;
                bURLfile = false;

                navigationManager.NavigateTo("/ogloszenia", true);
            }
            else
            {
                ogloszenieViewModel.Advertisement = sContentOgloszenie;
                ogloszenieViewModel.ColorId = colorId.Id;
                ogloszenieViewModel.SizeFontId = fontId.Id;
                ogloszenieViewModel.AdvertisementURL = sContentLink;
                ogloszenieViewModel.URL = sURL;

                ogloszenieServices.SaveUpdateOgloszenie(IdEditingOgloszenie, ogloszenieViewModel);
                bLinkAdd = false;
                bURLlink = false;
                bURLfile = false;
                navigationManager.NavigateTo("/ogloszenia", true);
            }
        }

    }

    void DeleteOgloszenie(int IdOgloszenie)
    {
        ogloszenieServices.DeleteOgloszenie(IdOgloszenie);
        navigationManager.NavigateTo("/ogloszenia", true);
    }

    string Color(int ColorId)
    {
        var color = colors.Where(x => x.Id == ColorId).FirstOrDefault();//colorServices.FindColorById(ColorId);
        return color.ColorValue;
    }

    string Font(int FontId)
    {
        var font = fontServices.FindFontSizeById(FontId);
        return font.FontSize.ToString() + "px";
    }

    void AddLinkFunction()
    {
        bLinkAdd = true;
    }

    void ViewLink()
    {
        bURLlink = true;
        bURLfile = false;
    }

    void AddFile()
    {
        bURLfile = true;
        bURLlink = false;
    }

    bool CheckCanSafe()
    {
        if (bLinkAdd == false)
        {
            if (string.IsNullOrEmpty(sContentOgloszenie)) return false;
            else return true;
        }
        if (bLinkAdd == true && bURLlink == true)
        {
            if (string.IsNullOrEmpty(sContentOgloszenie) || string.IsNullOrEmpty(sContentLink) || string.IsNullOrEmpty(sURL)) return false;
            else return true;
        }
        if (bLinkAdd == true && bURLfile == true)
        {
            if (string.IsNullOrEmpty(sContentOgloszenie) || string.IsNullOrEmpty(sContentLink) || string.IsNullOrEmpty(sURLToFile)) return false;
            else return true;
        }
        return false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASMapper asMapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColorServices colorServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FontSizeServices fontServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OgloszenieServices ogloszenieServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
