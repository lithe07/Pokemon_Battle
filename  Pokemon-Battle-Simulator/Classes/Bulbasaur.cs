namespace Pokemon_Battle_Simulator.Classes;

public class Bulbasaur: Pokemon
{
    public Bulbasaur():  base("Bulbasaur", "Grass" , "Fire") {}
    
    public override string BattleCry()
    {
        return "Bulbasaur.! Bulbasaur.!";
    }
}