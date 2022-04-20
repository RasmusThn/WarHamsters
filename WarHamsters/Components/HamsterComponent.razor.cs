
using DataLibrary.Models;
using DataLibrary.Services;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Components;

public partial class HamsterComponent : ComponentBase
{
    
    public Hamster OldHamster1 { get; set; }
    public Hamster OldHamster2 { get; set; }
    private Hamster hamster1;
    private Hamster hamster2;
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)  
    {
        await hamsterService.AddWin(hamsterWin, hamsterLoss);
        
        OldHamster1 = Hamsters[0];
        OldHamster2 = Hamsters[1];
        GetTwoRandomHamsters();
        StateHasChanged(); //Här laddas det om
    }
  
    public async void GetTwoRandomHamsters()
    {
        Hamsters = await hamsterService.GetTwoRandomHamsters();
        hamster1 = Hamsters[0];
        hamster2 = Hamsters[1];
    }
    protected override void OnInitialized()
    {
        GetTwoRandomHamsters();
    }

}
