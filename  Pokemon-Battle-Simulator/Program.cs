// === Program.cs ===
using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator.Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Trainer[] trainers = new Trainer[2];

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Voer de naam van Trainer {i + 1} in:");
                    string trainerName = Console.ReadLine();
                    trainers[i] = new Trainer(trainerName);

                    List<Pokemon> pokemons = new List<Pokemon>();
                    for (int x = 0; x < 2; x++)
                    {
                        pokemons.Add(new Charmander());
                        pokemons.Add(new Squirtle());
                        pokemons.Add(new Bulbasaur());
                    }

                    Random rnd = new Random();
                    pokemons.Sort((a, b) => rnd.Next(-1, 2));

                    foreach (var poke in pokemons)
                    {
                        trainers[i].Belt.Add(new Pokeball(poke));
                    }
                }

                Console.WriteLine($"Welkom {trainers[0].Name} en {trainers[1].Name}! Laat het gevecht beginnen!");
                Console.ReadKey();

                Battle battle = new Battle(trainers[0], trainers[1]);

                for (int i = 0; i < 6; i++)
                {
                    Pokemon p1 = trainers[0].ThrowPokeball(i);
                    Pokemon p2 = trainers[1].ThrowPokeball(i);

                    Console.WriteLine($"\nRonde {i + 1} is begonnen!");
                    Console.WriteLine($"{trainers[0].Name} roept zijn Pokémon: {p1.BattleCry()}");
                    Console.WriteLine($"{trainers[1].Name} roept haar Pokémon: {p2.BattleCry()}");

                    Round round = new Round(p1, p2);
                    Results result = round.startRound();

                    if (result == Results.Win)
                    {
                        Console.WriteLine($"{trainers[0].Name} wint de ronde!");
                        battle.trainer1Win++;
                    }
                    else if (result == Results.Lose)
                    {
                        Console.WriteLine($"{trainers[1].Name} wint de ronde!");
                        battle.trainer2Win++;
                    }
                    else
                    {
                        Console.WriteLine("Het is een gelijkspel in deze ronde!");
                    }

                    Console.WriteLine($"{trainers[0].Name} en {trainers[1].Name} keren hun Pokémon terug.");
                    Console.ReadKey();
                }

                Console.WriteLine(battle.GetBattleResult());
                Console.ReadKey();

                Console.WriteLine("Wil je opnieuw spelen? (ja/nee):");
                string antwoord = Console.ReadLine().Trim().ToLower();
                playAgain = (antwoord == "ja");
            }

            Console.WriteLine("Bedankt voor het spelen! Tot de volgende keer!");
        }
    }
}
