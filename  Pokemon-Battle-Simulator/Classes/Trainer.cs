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

    public string ThrowPokeball(int index)
    {
        if (index < Belt.Count)
        {
            Pokemon pokemon = Belt[index].Open();
            return $"{Name} heeft {pokemon.Nickname} vrijgelaten {pokemon.BattleCry()}";
        }
        return $"Pokemon is out";
    }

    public string ReturnPokemon(int index)
    {
        if (index < 0 || index >= Belt.Count)
        {
            return $"Pokemon at is out of range.";
        }
        Belt[index].Close();
        return $"Pokemon {index + 1 } at position has been returned.";
    }
}