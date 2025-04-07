using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Models;

namespace Services
{
    public class GameLibService
    {
        private static List<Games> games = new()
        {
            new()
            {
                Name = "Baldur's Gate 3",
                Subtitle = "A Journey Through the Realms",
                HeroImage = "baldurs_gate_3.png",
                Description = "Baldur's Gate 3 immerses players in a rich, story-driven RPG set in the Forgotten Realms...",
                AccentColorStart = Color.FromArgb("#2F4F4F"),
                AccentColorEnd = Color.FromArgb("#8B7D7B"),
                Category = "Action",
                Images = new() { }
            },
            new()
            {
                Name = "Hogwarts Legacy",
                Subtitle = "Embrace Your Wizarding Destiny",
                HeroImage = "hogwarts_legacy.png",
                Description = "In Hogwarts Legacy, experience life as a young wizard or witch in the 1800s...",
                AccentColorStart = Color.FromArgb("#7F3F30"),
                AccentColorEnd = Color.FromArgb("#D08B59"),
                Category = "Action",
                Images = new() { }
            },
            new()
            {
                Name = "Starfield",
                Subtitle = "Explore the Infinite Unknown",
                HeroImage = "starfield1.png",
                Description = "Starfield offers an immersive space exploration experience...",
                AccentColorStart = Color.FromArgb("#0A3555"),
                AccentColorEnd = Color.FromArgb("#1F5A80"),
                Category = "Sci-Fi",
                Images = new() { }
            },
            new()
            {
                Name = "Resident Evil 4",
                Subtitle = "Survival Horror Redefined",
                HeroImage = "resident_evil_4.png",
                Description = "Resident Evil 4 returns with stunning graphics...",
                AccentColorStart = Color.FromArgb("#6F2121"),
                AccentColorEnd = Color.FromArgb("#D63A3A"),
                Category = "Horror",
                Images = new() { }
            },
            new()
            {
                Name = "Sons Of The Forest",
                Subtitle = "Survive the Terrifying Wilderness",
                HeroImage = "sons_of_the_forest.png",
                Description = "Sons of the Forest is a survival horror game...",
                AccentColorStart = Color.FromArgb("#B47A3B"),
                AccentColorEnd = Color.FromArgb("#F0A900"),
                Category = "Horror",
                Images = new() { }
            },
            new()
            {
                Name = "THE FINALS",
                Subtitle = "Master the Ultimate Combat Arena",
                HeroImage = "the_finals.png",
                Description = "THE FINALS is a fast-paced, team-based shooter...",
                AccentColorStart = Color.FromArgb("#8B5A2B"),
                AccentColorEnd = Color.FromArgb("#D28B31"),
                Category = "Shooter",
                Images = new() { }
            },
            new()
            {
                Name = "FC 24",
                Subtitle = "The Ultimate Football Experience",
                HeroImage = "fc_24.jpg",
                Description = "FC 24 brings realistic and immersive football gameplay to life...",
                AccentColorStart = Color.FromArgb("#6D3420"),
                AccentColorEnd = Color.FromArgb("#C39256"),
                Category = "Sports",
                Images = new() { }
            },
            new()
            {
                Name = "Lethal Company",
                Subtitle = "Escape the Nightmare",
                HeroImage = "lethal_company.png",
                Description = "Lethal Company is a cooperative survival horror game...",
                AccentColorStart = Color.FromArgb("#082F49"),
                AccentColorEnd = Color.FromArgb("#309ACF"),
                Category = "Horror",
                Images = new() { }
            },
            new()
            {
                Name = "Overwatch 2",
                Subtitle = "The Next Evolution of Team-Based Combat",
                HeroImage = "overwatch_2.jpg",
                Description = "Overwatch 2 continues the legacy of the original...",
                AccentColorStart = Color.FromArgb("#2F1F0A"),
                AccentColorEnd = Color.FromArgb("#C19A5A"),
                Category = "Shooter",
                Images = new() { }
            },
            new()
            {
                Name = "STAR WARS Jedi: Survivor",
                Subtitle = "The Force Awaits",
                HeroImage = "star_wars_jedi_survivor.png",
                Description = "Star Wars Jedi: Survivor follows Cal Kestis on his journey...",
                AccentColorStart = Color.FromArgb("#595959"),
                AccentColorEnd = Color.FromArgb("#A9A9A9"),
                Category = "Action",
                Images = new() { }
            },
            new()
            {
                Name = "League Of Legends",
                Subtitle = "Master the Rift",
                HeroImage = "league_of_legends.png",
                Description = "League of Legends is a competitive multiplayer online battle arena (MOBA)...",
                AccentColorStart = Color.FromArgb("#7F4E40"),
                AccentColorEnd = Color.FromArgb("#C29F66"),
                Category = "MOBA",
                Images = new() { }
            },
            new()
            {
                Name = "Dota 2",
                Subtitle = "The Battle for the Ancients",
                HeroImage = "dota_2.png",
                Description = "Dota 2 is a strategy-heavy multiplayer online battle arena game...",
                AccentColorStart = Color.FromArgb("#7F3E1C"),
                AccentColorEnd = Color.FromArgb("#D9A67B"),
                Category = "MOBA",
                Images = new() { }
            },
            new()
            {
                Name = "Counter Strike 2",
                Subtitle = "The Ultimate Tactical Shooter",
                HeroImage = "counter_strike_2.png",
                Description = "Counter-Strike 2 brings the iconic, team-based tactical shooter...",
                AccentColorStart = Color.FromArgb("#505050"),
                AccentColorEnd = Color.FromArgb("#A6A6A6"),
                Category = "Shooter",
                Images = new() { }
            }
        };

        public static List<Games> GetFeaturedGames()
        {
            var random = new Random();
            var randomizePlanets = games
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Games> GetAllGames()
            => games;
    }
}
