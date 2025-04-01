namespace Pokemon_Battle_Simulator.Classes;

public class Arena
{
    public static int countRounds = 0;
    public static int countBattle = 0;

    public bool aadRounds()
    {
        Arena.countRounds++;
        return true;
    }

    public bool aadBattle()
    {
        Arena.countBattle++;
        return true;
    }

    public void setUpArena(Trainer trainer1, Trainer trainer2)
    {
        Battle fight = new Battle(trainer1, trainer2);
        fight.startBattle();

    }

}