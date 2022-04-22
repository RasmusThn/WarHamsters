using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages;

public partial class Battle : ComponentBase
{
    private Hamster OldHamster1;
    private Hamster OldHamster2;
    private Hamster hamster1;
    private Hamster hamster2;
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)
    {
        await hamsterService.AddWin(hamsterWin, hamsterLoss);
        await hamsterService.AddNewMatch(hamsterWin, hamsterLoss);
        RunAgain(hamsterWin, hamsterLoss);

    }
    public void RunAgain(Hamster hamsterWin, Hamster hamsterLoss)
    {
        OldHamster1 = hamsterWin;
        OldHamster2 = hamsterLoss;
        GetTwoRandomHamsters();
        StateHasChanged(); //Här laddas det om
    }
    public async void GetTwoRandomHamsters()
    {
        Hamsters = await hamsterService.GetTwoRandomHamsters();
        hamster1 = Hamsters[0];
        hamster2 = Hamsters[1];
        while (OldHamster1 == hamster1 || OldHamster1 == hamster2 || OldHamster2 == hamster1 || OldHamster2 == hamster2) // kolla mer på denna... säger aldrig ifrån
        {
            GetTwoRandomHamsters();
        }
    }
    protected override void OnInitialized()
    {
        GetTwoRandomHamsters();
    }
}
