namespace Pokemon_Battle_Simulator.Classes;

public class Round
{
    public Pokemon pokemon1;
    public Pokemon pokemon2;


    public Round(Pokemon pokemon1, Pokemon pokemon2)
    {
        this.pokemon1 = pokemon1;
        this.pokemon2 = pokemon2;
    }

    public Results startRound()
    {
        if (pokemon1.Strength == pokemon2.Strength)
            return Results.Draw;

        if ((pokemon1.Strength == "Fire" && pokemon2.Strength == "Grass") ||
            (pokemon1.Strength == "Grass" && pokemon2.Strength == "Water") ||
            (pokemon1.Strength == "Water" && pokemon2.Strength == "Fire"))
        {
            return Results.Win;
        }
        else
        {
            return Results.Lose;
        }
    }
}