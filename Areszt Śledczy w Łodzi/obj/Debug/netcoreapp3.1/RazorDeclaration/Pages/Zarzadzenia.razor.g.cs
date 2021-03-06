#pragma checksum "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Zarzadzenia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc166edf560326416c40df79eac51da6177688b"
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
#line 2 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Zarzadzenia.razor"
using Areszt_Śledczy_w_Łodzi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Zarzadzenia.razor"
using Areszt_Śledczy_w_Łodzi.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zarzadzenia")]
    public partial class Zarzadzenia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 446 "C:\PROJEKTY\Areszt Śledczy w Łodzi NA TYM PRACUJEMY\Areszt Śledczy w Łodzi\Pages\Zarzadzenia.razor"
       

    private bool bShowActual = true;
    ZarzadzenieViewModel zarzadzenieViewModel;
    ActualizationViewModel actualizationView;
    IFileListEntry selectedFiles;
    string Message { get; set; }
    string Message2 { get; set; }
    bool bCheckSave { get; set; }
    string sURLToFile { get; set; }
    int IdZarzadzenie { get; set; }
    List<ZarzadzenieViewModel> zarzadzenieViewModels;
    List<ActualizationViewModel> actualizationViewModels;
    bool bActualization { get; set; }
    bool bSearch { get; set; }
    string sYear { get; set; }
    string MessageActualization { get; set; }
    string sFindingString { get; set; }

    protected override async Task OnInitializedAsync()
    {
        zarzadzenieViewModel = new ZarzadzenieViewModel();
        actualizationView = new ActualizationViewModel();
        Message = "Nie wybrałeś żadnego pliku";
        Message2 = "Nie wszystkie wymagane pola zostały wypełnione!!!";
        MessageActualization = "Nie wszystkie wymagane pola zostały wypełnione!!!";
        bCheckSave = true;
        bSearch = false;
        sURLToFile = "";
        sFindingString = "";
        sYear = "0";
        bActualization = false;
        zarzadzenieViewModels = new List<ZarzadzenieViewModel>();
        actualizationViewModels = new List<ActualizationViewModel>();
        IdZarzadzenie = -1;
        await Task.Run(() =>
        {
            if (bShowActual) zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == true).ToList();
            else zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == false).ToList();
            actualizationViewModels = actualizationServices.GetAll();
        });
    }

    async Task ChoiceFileToUpload(IFileListEntry[] files)
    {
        selectedFiles = files.FirstOrDefault();
        if (selectedFiles.Name == "zarz_" + zarzadzenieViewModel.Number + "_" + zarzadzenieViewModel.Year + ".pdf" || selectedFiles.Name == "zarz_" + zarzadzenieViewModel.Number + "_" + zarzadzenieViewModel.Year + ".html")
        {
            if (selectedFiles != null)
            {
                await fileUpload.UploadAsync(selectedFiles, "Zarzadzenia");

                Message = $"Plik oczekuje na upload: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
            }
            this.StateHasChanged();
        }
        else
        {
            selectedFiles = null;
            Message = "Nazwa pliku nie jest zgodna z szablonem. (NR_ROK)";
        }
    }

    void UploadFile()
    {
        if (selectedFiles != null)
        {
            var dotName = selectedFiles.Name.ToString();
            int x = dotName.IndexOf('.');
            dotName = dotName.Remove(0, x + 1);
            if (dotName == "pdf") zarzadzenieViewModel.HTML = false;
            else zarzadzenieViewModel.HTML = true;


            Message = $"Trwa wrzucanie pliku...";
            fileUpload.SendToServer();
            Message = $"Zakończono ładowanie pliku: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
            sURLToFile = @"http://localhost:5000/Zarzadzenia/" + selectedFiles.Name;
            this.StateHasChanged();

        }
        else
        {
            Message = $"Nie ma wybranego pliku do umieszczenia go na serwerze!!!";
        }
    }

    void SaveZarzadzenie()
    {
        bCheckSave = CheckCanSafe();
        if (bCheckSave)
        {
            if (bShowActual) zarzadzenieViewModel.Actual = true;
            else zarzadzenieViewModel.Actual = false;
            zarzadzenieServices.SaveUpdateZarzadzenie(IdZarzadzenie, zarzadzenieViewModel);
            navigationManager.NavigateTo("/zarzadzenia", true);

        }
    }

    void ChangeActualToRepealed()
    {
        bShowActual = false;
        zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == false).ToList();
    }

    void ChangeRepealedToActual()
    {
        bShowActual = true;
        zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == true).ToList();
    }

    void Search()
    {
        bSearch = true;
    }

    void EditZarzadzenie(int IdZarzadzenie)
    {
        sURLToFile = "true";
        this.IdZarzadzenie = IdZarzadzenie;
        var zarzadzenieVM = zarzadzenieServices.GetZarzadzenieById(IdZarzadzenie);
        zarzadzenieViewModel = zarzadzenieVM;

        var actualizationVM = actualizationServices.GetActualizationContentByZarzadzenieId(this.IdZarzadzenie);
        actualizationView = actualizationVM;

        bActualization = false;
        navigationManager.NavigateTo("/zarzadzenia", false);
    }
    void DeleteZarzadzenie(int IdZarzadzenie)
    {
        zarzadzenieServices.DeleteZarzadzenie(IdZarzadzenie);
        navigationManager.NavigateTo("/zarzadzenia", true);
    }

    bool CheckCanSafe()
    {
        if (!bActualization)
        {
            if (zarzadzenieViewModel.ContentOfDirective == "" || zarzadzenieViewModel.Number == 0 || zarzadzenieViewModel.Year == 0 || sURLToFile == "") return false;
        }
        else
        {
            if (actualizationView.Number == 0 || actualizationView.Year == 0) return false;
        }
        return true;
    }

    void MoveZarzadzenie(int IdZarzadzenie)
    {
        this.IdZarzadzenie = IdZarzadzenie;
        var zarzadzenieVM = zarzadzenieServices.GetZarzadzenieById(this.IdZarzadzenie);
        if (bShowActual) zarzadzenieVM.Actual = false;
        else zarzadzenieVM.Actual = true;
        zarzadzenieServices.SaveUpdateZarzadzenie(this.IdZarzadzenie, zarzadzenieVM);

        navigationManager.NavigateTo("/zarzadzenia", true);
    }

    void SaveActualization()
    {
        bCheckSave = CheckCanSafe();
        if (bCheckSave)
        {
            actualizationView.Content = "AKTUALIZACJA: Zarządzenie " + actualizationView.Number + "/" + actualizationView.Year;
            actualizationView.ZarzadzenieId = IdZarzadzenie;
            actualizationServices.SaveUpdateActualizationContent(IdZarzadzenie, actualizationView);
            bActualization = false;
            navigationManager.NavigateTo("/zarzadzenia", true);
        }
    }

    void ActualizationZarzadzenie(int IdZarzadzenie)
    {
        this.IdZarzadzenie = IdZarzadzenie;
        var zarzadzenieVM = zarzadzenieServices.GetZarzadzenieById(this.IdZarzadzenie);
        zarzadzenieViewModel = zarzadzenieVM;


        this.IdZarzadzenie = IdZarzadzenie;
        var actualizationVM = actualizationServices.GetActualizationContentByZarzadzenieId(this.IdZarzadzenie);
        if (actualizationVM == null)
        {
            actualizationView = new ActualizationViewModel()
            {
                Content = "",
                Number = 0,
                Year = 0,
                ZarzadzenieId = this.IdZarzadzenie
            };
        }
        else actualizationView = actualizationVM;

        bActualization = true;
        navigationManager.NavigateTo("/zarzadzenia", false);
    }

    void HideSearch()
    {
        bSearch = false;
    }

    void DeleteActualization(int IdZarzadzenie)
    {
        actualizationServices.DeleteActualization(IdZarzadzenie);
        navigationManager.NavigateTo("/zarzadzenia", true);
    }

    void FindZarzadzenie()
    {
        if (bShowActual) zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().Where(x => x.ContentOfDirective.Contains(sFindingString)).OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == true).ToList();
        else zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().Where(x => x.ContentOfDirective.Contains(sFindingString)).OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == false).ToList();
        sFindingString = "";
    }

    void ShowAll()
    {
        sYear = "0";
        sFindingString = "";
        if (bShowActual) zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == true).ToList();
        else zarzadzenieViewModels = zarzadzenieServices.GetAllZarzadzenia().OrderBy(x => x.Year).ThenBy(x => x.Number).Where(x => x.Actual == false).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ActualizationContentServices actualizationServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ZarzadzenieServices zarzadzenieServices { get; set; }
    }
}
#pragma warning restore 1591
