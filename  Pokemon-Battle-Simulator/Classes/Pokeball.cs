namespace Pokemon_Battle_Simulator.Classes;

public class Pokeball
{
    public Pokemon Pokemon;
    public bool HasCharmanderInside;
        
    public Pokeball(Pokemon pokemon)
    {
        this.Pokemon = pokemon;
        this.HasCharmanderInside = true;
    }
        
    public Pokemon Open()
    {
        if (HasCharmanderInside)
        {
            HasCharmanderInside = false;
            Pokemon.BattleCry();
            return Pokemon;
            
        }
        return null;
    }
        
    public void Close()
    {
        HasCharmanderInside = true;
    }
}