
using DataLibrary.Models;
using DataLibrary.Services;
using Microsoft.AspNetCore.Components;

namespace WarHamsters.Components;

public partial class HamsterComponent : ComponentBase
{
  
    private Hamster hamster1;
    private Hamster hamster2;
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task AddWin(Hamster hamsterWin, Hamster hamsterLoss)    // Bör ändras till Task<Class> etc
    {
        await hamsterService.AddWin(hamsterWin, hamsterLoss);
        //ShouldRender();

    }

    public int ShuffleNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 6);//ändra till Hamster.count()
        return randomNumber;
    }
    public async Task<Hamster> GetHamsterById(int hamsterId)
    {
        return await hamsterService.GetHamsterById(hamsterId);
    }
    public async void GetTwoRandomHamsters()
    {
        Hamsters = await hamsterService.GetTwoRandomHamsters();
    }


    //Nått med detta...


    //protected override bool ShouldRender()
    //{

    //    return shouldRender;
    //}
    protected override async void OnInitialized()
    {
        GetTwoRandomHamsters();
        hamster1 = Hamsters[0];
        hamster2 = Hamsters[1];

        //int ham1 = ShuffleNumber();
        //int ham2 = ShuffleNumber();

        //while (ham1 == ham2)
        //{
        //    ham1 = ShuffleNumber();
        //    ham2 = ShuffleNumber();
        //}

     
        //hamster1 = await GetHamsterById(ham1);
        //hamster2 = await GetHamsterById(ham2);

    }

}
