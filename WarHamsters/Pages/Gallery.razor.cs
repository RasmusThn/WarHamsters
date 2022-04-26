using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages
{
    public partial class Gallery : ComponentBase
    {
        private string SearchTerm { get; set; } = string.Empty;
        private List<Hamster> hamsters = new List<Hamster>();
        private readonly string url = "gallery";

        protected override void OnInitialized()
        {
            if (!hamsterService.CheckDatabaseForHamsters())
            {
                return;
            }
            else
            {
                hamsters = hamsterService.GetAllActiveHamsters();
            }
        }

        public void GethamsterbySearch()
        {

            hamsters = hamsterService.GetHamsterBySearch(SearchTerm);

        }
        
    }
}
