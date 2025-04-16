namespace Pokemon_Battle_Simulator.Classes;

public class Pokeball
{
    private readonly Pokemon Pokemon;
    private bool HasCharmanderInside;
        
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

    public Pokemon getPokemon()
    {
        return Pokemon;
    }

    public bool getHasCharmanderInside()
    {
        return HasCharmanderInside;
    }
}