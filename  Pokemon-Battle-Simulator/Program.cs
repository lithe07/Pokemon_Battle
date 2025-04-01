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

                // Vraag de namen van de trainers en vul de riem met Pokéballs
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Voer de naam van Trainer {i + 1} in:");
                    string trainerName = Console.ReadLine();
                    trainers[i] = new Trainer(trainerName);
                    
                    for (int j = 0; j < 6; j++)
                    {
                        trainers[i].Belt.Add(new Pokeball(new Charmander()));
                        trainers[i].Belt.Add(new Pokeball(new Squirtle()));
                        trainers[i].Belt.Add(new Pokeball(new Bulbasaur()));
                    }
                    
                    
                }

                Console.WriteLine($"Welkom {trainers[0].Name} en {trainers[1].Name}! Laat het gevecht beginnen!\n");
                Console.ReadKey();

                

                // Het gevecht (6 rondes)
                for (int round = 0; round < 6; round++)
                {
                    Console.WriteLine($"\nRonde {round + 1} is begonnen");

                    // Gebruik ThrowPokeball() om Pokémon vrij te laten en hun BattleCry te laten horen
                    Console.WriteLine(trainers[0].ThrowPokeball(round));
                    Console.WriteLine(trainers[1].ThrowPokeball(round));    

                    // Pokémon terugkeren
                    Console.WriteLine(trainers[0].ReturnPokemon(round));
                    Console.WriteLine(trainers[1].ReturnPokemon(round));
                    Console.WriteLine($"{trainers[0].Name} en {trainers[1].Name} keren hun pokéballen terug.");
                    Console.ReadKey();
                }

                Console.WriteLine("Het gevecht is voorbij! Bedankt voor het spelen!");
                Console.ReadKey();

                // Vraag of de speler opnieuw wil spelen
                Console.WriteLine("Wil je opnieuw spelen? (ja/nee):");
                string antwoord = Console.ReadLine().Trim().ToLower();
                playAgain = (antwoord == "ja");
            }

            Console.WriteLine("Bedankt voor het spelen! Tot de volgende keer!");
        }
    }
};