namespace Pokemon_Battle_Simulator.Classes;

public class Trainer
{
    private string Name;
    private List<Pokeball> Belt;
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
            return pokemon;
        }
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

    public string getName()
    {
        return Name;
    }

    public List<Pokeball> getBelt()
    {
        return Belt;
    }
}