namespace Pokemon_Battle_Simulator.Classes;

public class Battle
{
    public Trainer trainer1;
    public Trainer trainer2;

    public Battle(Trainer trainer1, Trainer trainer2)
    {
        this.trainer1 = trainer1;
        this.trainer2 = trainer2;
    }

    public void startBattle()
    {
        //startround 
        //wat is pokemon 1
        // wat is pokemon 2
        
        int trainer1Wins = 0;
        int trainer2Wins = 0;
        
        for (int z = 0; z < 6; z++)
        {
            Pokemon pokemon1  = trainer1.ThrowPokeball(z);
            Pokemon pokemon2  = trainer2.ThrowPokeball(z);
        
            Round round = new Round(pokemon1, pokemon2);
            //gebruik result om de winnende trainer te bepalen na 6 rondes
            int result = round.startRound(); 
            
            if(result == 1) trainer1Wins++;
            else if(result == 2) trainer2Wins++;
            
            // update roundsplayed
            Arena.countRounds++;

        }
        //update battleplayed
        Arena.countRounds++;

        if (trainer1Wins > trainer2Wins)
            return $"{trainer1.Name} wint de battle met {trainer1Wins} tegen {trainer2Wins}!";
        else if (trainer2Wins > trainer1Wins)
            return $"{trainer2.Name} wint de battle met {trainer2Wins} tegen {trainer1Wins}!";
        else
            return "De battle eindigt in een gelijkspel!";
        
       
        
    }
}