using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages
{
    public partial class Gallery : ComponentBase
    {
        private string searchTerm { get; set; } = string.Empty;
        private List<Hamster> hamsters = new List<Hamster>();
        private string url = "gallery";

        protected override async Task OnInitializedAsync()
        {
            if (!hamsterService.CheckDatabaseForHamsters())
            {
                return;
            }
            else
            {
                hamsters = await hamsterService.GetAllActiveHamsters();
            }
        }
      
        public void GethamsterbySearch()
        {

            hamsters = hamsterService.GetHamsterBySearch(searchTerm);

        }
        
    }
}
