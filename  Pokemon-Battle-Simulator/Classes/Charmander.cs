namespace Pokemon_Battle_Simulator.Classes;

public class Charmander : Pokemon
{
    public Charmander() :  base("Charmander", "Fire" , "Water"){}
    
    public override string BattleCry()
    {
        return "Charmander.! Charmander.!";
    }

}