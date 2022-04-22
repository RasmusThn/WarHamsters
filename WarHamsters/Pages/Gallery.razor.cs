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
                hamsters = await hamsterService.GetAllHamsters();
            }
        }
        //public async void Delete(int id)
        //{
        //    Hamster hamster = await hamsterService.GetHamsterById(id);
        //    if (hamster != null)
        //    {
        //        hamsterService.DeleteHamster(hamster);
        //        ShouldRender();
        //    }
        //}
        public void GethamsterbySearch()
        {

            hamsters = hamsterService.GetHamsterBySearch(searchTerm);

        }
        
    }
}
