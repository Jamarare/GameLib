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
                HeroImage = "Baldur's Gate 3.png",
                Description = "Baldur's Gate 3 immerses players in a rich, story-driven RPG set in the Forgotten Realms, where players make choices that impact the fate of their characters and the world around them.",
                AccentColorStart = Color.FromArgb("#2F4F4F"),
                AccentColorEnd = Color.FromArgb("#8B7D7B"),
                Category = "Action", 
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Hogwarts Legacy",
                Subtitle = "Embrace Your Wizarding Destiny",
                HeroImage = "Hogwarts Legacy.png",
                Description = "In Hogwarts Legacy, experience life as a young wizard or witch in the 1800s before the events of Harry Potter. Explore a vast open world and make decisions that shape your magical journey.",
                AccentColorStart = Color.FromArgb("#7F3F30"),
                AccentColorEnd = Color.FromArgb("#D08B59"),
                Category = "Action",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Starfield",
                Subtitle = "Explore the Infinite Unknown",
                HeroImage = "Starfield.png",
                Description = "Starfield offers an immersive space exploration experience where players embark on a journey across the stars. Customize spacecraft and explore the mysteries of the universe.",
                AccentColorStart = Color.FromArgb("#0A3555"),
                AccentColorEnd = Color.FromArgb("#1F5A80"),
                Category = "Sci-Fi",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Resident Evil 4",
                Subtitle = "Survival Horror Redefined",
                HeroImage = "Resident Evil 4.png",
                Description = "Resident Evil 4 returns with stunning graphics, offering players a terrifying journey to rescue the U.S. president’s daughter from a rural Spanish village infested with deadly creatures.",
                AccentColorStart = Color.FromArgb("#6F2121"),
                AccentColorEnd = Color.FromArgb("#D63A3A"),
                Category = "Horror",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Sons Of The Forest",
                Subtitle = "Survive the Terrifying Wilderness",
                HeroImage = "Sons Of The Forest.png",
                Description = "Sons of the Forest is a survival horror game where players must navigate a dangerous, mysterious forest inhabited by terrifying creatures.",
                AccentColorStart = Color.FromArgb("#B47A3B"),
                AccentColorEnd = Color.FromArgb("#F0A900"),
                Category = "Horror",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "THE FINALS",
                Subtitle = "Master the Ultimate Combat Arena",
                HeroImage = "THE FINALS.png",
                Description = "THE FINALS is a fast-paced, team-based shooter that blends intense gunplay with unique environmental destruction.",
                AccentColorStart = Color.FromArgb("#8B5A2B"),
                AccentColorEnd = Color.FromArgb("#D28B31"),
                Category = "Shooter",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "FC 24",
                Subtitle = "The Ultimate Football Experience",
                HeroImage = "FC 24.jpg",
                Description = "FC 24 brings realistic and immersive football gameplay to life, with lifelike graphics, player movements, and team strategies.",
                AccentColorStart = Color.FromArgb("#6D3420"),
                AccentColorEnd = Color.FromArgb("#C39256"),
                Category = "Sports",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Lethal Company",
                Subtitle = "Escape the Nightmare",
                HeroImage = "Lethal Company.png",
                Description = "Lethal Company is a cooperative survival horror game where you and your friends must escape a terrifying building.",
                AccentColorStart = Color.FromArgb("#082F49"),
                AccentColorEnd = Color.FromArgb("#309ACF"),
                Category = "Horror",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Overwatch 2",
                Subtitle = "The Next Evolution of Team-Based Combat",
                HeroImage = "Overwatch 2.jpg",
                Description = "Overwatch 2 continues the legacy of the original with a focus on team-based combat, strategic gameplay, and new heroes and maps.",
                AccentColorStart = Color.FromArgb("#2F1F0A"),
                AccentColorEnd = Color.FromArgb("#C19A5A"),
                Category = "Shooter",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "STAR WARS Jedi: Survivor",
                Subtitle = "The Force Awaits",
                HeroImage = "STAR WARS Jedi Survivor.png",
                Description = "Star Wars Jedi: Survivor follows Cal Kestis on his journey to survive against the growing forces of the Empire. Harness the power of the Force, engage in lightsaber combat, and uncover the mysteries of the galaxy.",
                AccentColorStart = Color.FromArgb("#595959"),
                AccentColorEnd = Color.FromArgb("#A9A9A9"),
                Category = "Action",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "League Of Legends",
                Subtitle = "Master the Rift",
                HeroImage = "League Of Legends.png",
                Description = "League of Legends is a competitive multiplayer online battle arena (MOBA) where players select champions and work together to destroy the enemy's Nexus.",
                AccentColorStart = Color.FromArgb("#7F4E40"),
                AccentColorEnd = Color.FromArgb("#C29F66"),
                Category = "MOBA",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Dota 2",
                Subtitle = "The Battle for the Ancients",
                HeroImage = "Dota 2.png",
                Description = "Dota 2 is a strategy-heavy multiplayer online battle arena game where players select heroes and work together in teams to destroy the enemy's Ancient.",
                AccentColorStart = Color.FromArgb("#7F3E1C"),
                AccentColorEnd = Color.FromArgb("#D9A67B"),
                Category = "MOBA",
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Counter Strike 2",
                Subtitle = "The Ultimate Tactical Shooter",
                HeroImage = "Counter Strike 2.png",
                Description = "Counter-Strike 2 brings the iconic, team-based tactical shooter into a new era with updated visuals, mechanics, and gameplay.",
                AccentColorStart = Color.FromArgb("#505050"),
                AccentColorEnd = Color.FromArgb("#A6A6A6"),
                Category = "Shooter",
                Images = new()
                {

                }
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