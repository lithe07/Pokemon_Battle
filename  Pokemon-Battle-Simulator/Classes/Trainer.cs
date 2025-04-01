namespace Pokemon_Battle_Simulator.Classes;

public class Trainer
{
    public string Name;
    public List<Pokeball> Belt;
    public Trainer(string name)
    {
        this.Name = name;
        this.Belt = new List<Pokeball>();
    }

    public Pokemon ThrowPokeball(int index)
    {
        if (index < Belt.Count)
        {
            Pokemon pokemon = Belt[index].Open();
            // return $"{Name} heeft {pokemon.Nickname} vrijgelaten {pokemon.BattleCry()}";
            return pokemon;
        }
        // return $"Pokemon is out";
        return Belt[0].Open();
    }

    public string ReturnPokemon(int index)
    {
        try
        {
            Belt[index].Close();
            return $"Pokemon {index + 1 } at position has been returned.";
        }
        catch (ArgumentOutOfRangeException)
        {
            return "Error: Index was out of range.";
        }
    }
}