using DataLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Pages;

public partial class Battle : ComponentBase
{
    private Hamster oldHamster1;
    private Hamster oldHamster2;
    private Hamster hamster1;
    private Hamster hamster2;
    private double hamster1Procent;
    private double hamster2Procent;
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task Update(Hamster hamsterWin, Hamster hamsterLoss)
    {
        
        await AddWin(hamsterWin);
        await AddLoss(hamsterLoss);
        //await hamsterService.AddWin(hamsterWin, hamsterLoss);
        await hamsterService.UpdateHamster(hamsterWin);
        await hamsterService.UpdateHamster(hamsterLoss);
        await matchService.AddNewMatch(hamsterWin, hamsterLoss);
       
        RunAgain(hamsterWin, hamsterLoss);

    }
    public async Task AddWin(Hamster hamsterWin)
    {
        hamsterWin.Wins++;
        hamsterWin.Games++;
    }
    public async Task AddLoss(Hamster hamsterLoss)
    {
        hamsterLoss.Defeats++;
        hamsterLoss.Games++;
    }

    public void RunAgain(Hamster hamsterWin, Hamster hamsterLoss)
    {
        oldHamster1 = hamsterWin;
        oldHamster2 = hamsterLoss;
        hamster1Procent = CalculateProcent(hamsterWin);
        hamster2Procent = CalculateProcent(hamsterLoss);
        GetTwoRandomHamsters();
        StateHasChanged(); //Här laddas det om
    }
    public void GetTwoRandomHamsters()
    {
        Hamsters = hamsterService.GetTwoRandomHamsters();
        hamster1 = Hamsters[0];
        hamster2 = Hamsters[1];
    }
    private static double CalculateProcent(Hamster hamster)
    {
        double sum =((double)hamster.Wins / (double)hamster.Games) * 100d;
        return sum;
    }
    protected override void OnInitialized()
    {
        GetTwoRandomHamsters();
    }
}
