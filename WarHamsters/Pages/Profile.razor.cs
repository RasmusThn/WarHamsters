using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages
{
    public partial class Profile : ComponentBase
    {
       
        [Parameter]
        public string HamsterId { get; set; }
        [Parameter]
        public string? Oldpage { get; set; }
        private Hamster _hamster;
        private bool _showMatches = false;
        private string _ShowHide = "Show";
        private bool Isprofile { get; set; } = true;
        public bool DeleteDialogOpen { get; set; }
        protected override void OnInitialized()
        {
            int id = int.Parse(HamsterId);
            _hamster = hamsterService.GetHamsterById(id);

        }
        public void Delete(Hamster hamster)
        {

            hamsterService.DeleteHamster(hamster);
            navigation.NavigateTo("/gallery");

        }
        public void GoBack()
        {
            if (Oldpage == "top5")
            {
                navigation.NavigateTo("/top5");
            }
            else if (Oldpage == "low5")
            {
                navigation.NavigateTo("/low5");
            }
            else if (Oldpage == "battle")
            {
                navigation.NavigateTo("/battle");
            }
            else
            {
                navigation.NavigateTo("/gallery");
            }
        }
        public void ShowMatches()
        {
            if (_showMatches)
            {
                _showMatches = false;
                _ShowHide = "Show";
            }
            else
            {
                _showMatches = true;
                _ShowHide = "Hide";
            }
        }
        private void OnDeleteDialogClose(bool accepted)
        {
            DeleteDialogOpen = false;
            if (accepted)
            {
                Delete(_hamster);
            }
            StateHasChanged();
        }
        private void OpenDeleteDialog()
        {
            DeleteDialogOpen = true;
            StateHasChanged();
        }
    }
}
