namespace Pokemon_Battle_Simulator.Classes;

public static class Arena
{
    public static int countRounds = 0;
    public static int countBattle = 0;
    
    public static bool aadRounds()
    {
        Arena.countRounds++;
        return true;
    }

    public  static bool aadBattle()
    {
        Arena.countBattle++;
        return true;
    }

    public static Battle setUpArena(Trainer trainer1, Trainer trainer2)
    {
        Battle fight = new Battle(trainer1, trainer2);
        return fight;

    }

}