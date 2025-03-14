namespace Pokemon_Battle_Simulator.Classes;

public abstract class Pokemon
{
    public string Nickname;
    public string Strength;
    public string Weakness;

    public Pokemon(string nickname, string strength, string weakness)
    {
        Nickname = nickname;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract string BattleCry();

}