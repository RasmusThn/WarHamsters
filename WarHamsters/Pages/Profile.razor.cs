using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages
{
    public partial class Profile : ComponentBase
    {
       
        [Parameter]
        public string hamsterId { get; set; }
        [Parameter]
        public string oldpage { get; set; }
        private Hamster hamster;
        private bool _showMatches = false;
        private string _ShowHide = "Show";
        private bool Isprofile { get; set; } = true;
        protected async override void OnInitialized()
        {
            int id = int.Parse(hamsterId);
            hamster = await hamsterService.GetHamsterById(id);

        }
        public void Delete(int id)
        {

            hamsterService.DeleteHamster(hamster);
            navigation.NavigateTo("/gallery");

        }
        public void GoBack()
        {
            if (oldpage == "top5")
            {
                navigation.NavigateTo("/top5");
            }
            else if (oldpage == "low5")
            {
                navigation.NavigateTo("/low5");
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
    }
}
