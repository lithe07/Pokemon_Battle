namespace Pokemon_Battle_Simulator.Classes;

public abstract class Pokemon
{
    private readonly string Nickname;
    private readonly string Strength;
    private readonly string Weakness;

    public Pokemon(string nickname, string strength, string weakness)
    {
        Nickname = nickname;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract string BattleCry();

    public string getNickname()
    {
        return Nickname;
    }

    public string getStrength()
    {
        return Strength;
    }

    public string getWeakness()
    {
        return Weakness;
    }
}