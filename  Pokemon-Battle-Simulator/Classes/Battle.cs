namespace Pokemon_Battle_Simulator.Classes;

public class Battle
{
    public Trainer trainer1;
    public Trainer trainer2;
    
    public int trainer1Win = 0;
    public int trainer2Win = 0;

    public Battle(Trainer trainer1, Trainer trainer2)
    {
        this.trainer1 = trainer1;
        this.trainer2 = trainer2;
        
    }

    public void startBattle()
    {
        for (int z = 0; z < 6; z++)
        {
            Pokemon pokemon1  = trainer1.ThrowPokeball(z);
            Pokemon pokemon2  = trainer2.ThrowPokeball(z);
        
            Round round = new Round(pokemon1, pokemon2);
            //gebruik result om de winnende trainer te bepalen na 6 rondes
            Results result = round.startRound();
            if (result == Results.Win)
                trainer1Win++;
            else if (result == Results.Lose)
                trainer2Win++;

            // update roundsplayed
            Arena.countRounds++;

        }
        //update battleplayed
        Arena.countBattle++;
        
    }
    
    public string GetBattleResult()
    {
        if (trainer1Win > trainer2Win)
            return $"{trainer1.Name} wint de battle met {trainer1Win} tegen {trainer2Win}!";
        else if (trainer2Win > trainer1Win)
            return $"{trainer2.Name} wint de battle met {trainer2Win} tegen {trainer1Win}!";
        else
            return "De battle eindigt in een gelijkspel!";
    }
}