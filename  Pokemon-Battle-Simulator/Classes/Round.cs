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
        if (pokemon1.getStrength() == pokemon2.getStrength())
            return Results.Draw;

        if ((pokemon1.getStrength() == "Fire" && pokemon2.getStrength() == "Grass") ||
            (pokemon1.getStrength() == "Grass" && pokemon2.getStrength() == "Water") ||
            (pokemon1.getStrength() == "Water" && pokemon2.getStrength() == "Fire"))
        {
            return Results.Win;
        }
        else
        {
            return Results.Lose;
        }
    }
}