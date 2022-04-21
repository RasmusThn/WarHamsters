
using DataLibrary.Models;
using DataLibrary.Services;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Components;

public partial class HamsterComponent : ComponentBase
{
    [Parameter]
    public Hamster OldHamster1 { get; set; }
    [Parameter]
    public Hamster OldHamster2 { get; set; }
    [Parameter]
    public Hamster hamster1 { get; set;}
    [Parameter]
    public Hamster hamster2 { get; set; }
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)
    {
        await hamsterService.AddWin(hamsterWin, hamsterLoss);
        RunAgain();
        
    }
    public async void RunAgain()
    {
        OldHamster1 = Hamsters[0];
        OldHamster2 = Hamsters[1];
        await hamsterService.GetTwoRandomHamsters();
        StateHasChanged(); //Här laddas det om
    }


}
