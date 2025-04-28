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
                Category = "Action Games",
                Images = new() 
                {
                    "https://assets-prd.ignimgs.com/2023/08/05/astarion-1-1691263947280.png",
                    "https://media.wired.com/photos/64f242efb73daff5cefdeba5/master/w_2560%2Cc_limit/Baldur%25E2%2580%2599s-Gate-3-Rewards-You-for-Your-Unexpected-Choices-Games.jpg",
                    "https://sm.ign.com/t/ign_ap/feature/b/baldurs-ga/baldurs-gate-3-review-in-progress_xmcd.1280.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/baldurs-gate-3/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Hogwarts Legacy",
                Subtitle = "Embrace Your Wizarding Destiny",
                HeroImage = "hogwarts_legacy.png",
                Description = "In Hogwarts Legacy, experience life as a young wizard or witch in the 1800s...",
                AccentColorStart = Color.FromArgb("#7F3F30"),
                AccentColorEnd = Color.FromArgb("#D08B59"),
                Category = "Action Games",
                Images = new() 
                {
                    "https://cdn.potterish.com/wp-content/2020/09/harry-potter-hogwarts-legacy-erumpente_1_2.png",
                    "https://cdn.potterish.com/wp-content/2020/09/harry-potter-hogwarts-legacy-trasgo_1.png",
                    "https://cdn.potterish.com/wp-content/2020/09/harry-potter-hogwarts-legacy-hogwarts-noite-carruagem.png"
                },
                ReviewsUrl = "https://www.metacritic.com/game/hogwarts-legacy/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },

            new()
            {
                Name = "Starfield",
                Subtitle = "Explore the Infinite Unknown",
                HeroImage = "starfield1.png",
                Description = "Starfield offers an immersive space exploration experience...",
                AccentColorStart = Color.FromArgb("#0A3555"),
                AccentColorEnd = Color.FromArgb("#1F5A80"),
                Category = "RPG Games",
                Images = new() 
                {
                    "https://assets-prd.ignimgs.com/2022/06/12/starfield-blogroll-01-1655058857695.jpg",
                    "https://i.gadgets360cdn.com/large/starfield_gameplay_reveal_bethesda_microsoft_1655098758730.jpg",
                    "https://images.ctfassets.net/rporu91m20dc/mRbSMyERZlqi8uy0NPx9x/e416581ee1733a37eb61a3a2c57c11d0/Starfield_Combat.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/starfield/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Resident Evil 4",
                Subtitle = "Survival Horror Redefined",
                HeroImage = "resident_evil_4.png",
                Description = "Resident Evil 4 returns with stunning graphics...",
                AccentColorStart = Color.FromArgb("#6F2121"),
                AccentColorEnd = Color.FromArgb("#D63A3A"),
                Category = "Horror Games",
                Images = new() 
                {
                    "https://i.guim.co.uk/img/media/dded51b62fca770d82d7103f4b279551dd812626/120_0_3600_2160/master/3600.jpg?width=1200&height=900&quality=85&auto=format&fit=crop&s=38190285417f268bb1e387a39acae567",
                    "https://images.immediate.co.uk/production/volatile/sites/3/2023/03/Resi-4-Remake-Ashley-41b2a79.jpg?quality=90&resize=980,654",
                    "https://images.squarespace-cdn.com/content/v1/59a2574903596e3462d0bd19/1681931443149-NYOW24QLI424VIKIBIN9/Resident+Evil+4+%285%29.jpg"

                },
                ReviewsUrl = "https://www.metacritic.com/game/resident-evil-4/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Sons Of The Forest",
                Subtitle = "Survive the Terrifying Wilderness",
                HeroImage = "sons_of_the_forest.png",
                Description = "Sons of the Forest is a survival horror game...",
                AccentColorStart = Color.FromArgb("#B47A3B"),
                AccentColorEnd = Color.FromArgb("#F0A900"),
                Category = "Horror Games",
                Images = new() 
                {
                    "https://mirage.com.pl/_next/image?url=https%3A%2F%2Fmirage.com.pl%2Fstorage%2Fmedia%2F91c79b27-e056-4886-b6e4-abcf2dcd17a0%2Fthumbnail%2FKN2yqyuOzbMZSu8qEX5H8znZQcj1qS%2F0bd2f3aee5df95064e68518822a86910.webp&w=1920&q=75",
                    "https://static1.colliderimages.com/wordpress/wp-content/uploads/2021/05/sons-of-the-forest-monster-screenshot-1.jpg",
                    "https://thenerdstash.com/wp-content/uploads/2023/03/sons-of-the-forest-build-on-water.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/sons-of-the-forest/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "THE FINALS",
                Subtitle = "Master the Ultimate Combat Arena",
                HeroImage = "the_finals.png",
                Description = "THE FINALS is a fast-paced, team-based shooter...",
                AccentColorStart = Color.FromArgb("#8B5A2B"),
                AccentColorEnd = Color.FromArgb("#D28B31"),
                Category = "FPS Games",
                Images = new() 
                {
                    "https://shared.cloudflare.steamstatic.com/store_item_assets/steam/apps/2073850/ss_d37be3e97f1dcddbd4db38ffe6eebd0fc724eec4.1920x1080.jpg?t=1743523996",
                    "https://assetsio.gnwcdn.com/1_8JbdhsJ.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp",
                    "https://i.ytimg.com/vi/Pe_xO_CZa8o/maxresdefault.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/the-finals/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""

            },
            new()
            {
                Name = "FC 24",
                Subtitle = "The Ultimate Football Experience",
                HeroImage = "fc_24.png",
                Description = "FC 24 brings realistic and immersive football gameplay to life...",
                AccentColorStart = Color.FromArgb("#6D3420"),
                AccentColorEnd = Color.FromArgb("#C39256"),
                Category = "Sports Games",
                Images = new() 
                {
                    "https://images.immediate.co.uk/production/volatile/sites/3/2024/08/ea-fc-24-carryover-rewards-f8ac441.jpg?quality=90&resize=980,654",
                    "https://shared.cloudflare.steamstatic.com/store_item_assets/steam/apps/2195250/ss_33527a88323cbb39a7c09d7d74955015343efd3f.1920x1080.jpg?t=1743020121",
                    "https://derivates.kicker.de/image/upload/c_crop%2Cx_393%2Cy_120%2Cw_3213%2Ch_1807/w_1200%2Cq_auto/v1/2024/06/13/711d16f4-528c-4f1d-a396-328ccebb5b74.jpeg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/ea-sports-fc-24/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Lethal Company",
                Subtitle = "Escape the Nightmare",
                HeroImage = "lethal_company.png",
                Description = "Lethal Company is a cooperative survival horror game...",
                AccentColorStart = Color.FromArgb("#082F49"),
                AccentColorEnd = Color.FromArgb("#309ACF"),
                Category = "Horror Games",
                Images = new() 
                {
                    "https://platform.polygon.com/wp-content/uploads/sites/2/chorus/uploads/chorus_asset/file/25116125/lethal_company_clayton.png?quality=90&strip=all&crop=7.8125,0,84.375,100",
                    "https://shared.fastly.steamstatic.com/store_item_assets/steam/apps/1966720/ss_27eb66c9d0e327f90915cef23b1377e9b10bc27b.1920x1080.jpg?t=1742986399",
                    "https://static0.gamerantimages.com/wordpress/wp-content/uploads/2023/11/suits-lethal-company.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/lethal-company/",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Overwatch 2",
                Subtitle = "The Next Evolution of Team-Based Combat",
                HeroImage = "overwatch2.png",
                Description = "Overwatch 2 continues the legacy of the original...",
                AccentColorStart = Color.FromArgb("#2F1F0A"),
                AccentColorEnd = Color.FromArgb("#C19A5A"),
                Category = "FPS Games",
                Images = new() 
                {
                    "https://64.media.tumblr.com/92d4049dafd260ff4f408ab1ffaa52de/13d453f4ca1d0a56-97/s2048x3072/f5571b8dd8f61a9e00c935dec74a7c6bbff2dcab.jpg",
                    "https://i.ytimg.com/vi/SSYzUI4Lo1E/maxresdefault.jpg",
                    "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEjmZdf_VCCCKbzV0CHDVg5I1yGF6L53_w5oa8YpSAKqCQ30Hb0czaSxjISK9s9etZIIbr3RnKlygqrYftBy8BmQo7vIOZ5uq8_MtIVePwUNWhJV1Oj_JHw_P5DAptcA1WL0a4Y1QhM1Khll87-e_ezMFi4ytGn7DeDbL3Tf3fVM1TmSqxSa8E9cOGKV/s3840/Overwatch2_9.JPG"
                },
                ReviewsUrl = "https://www.metacritic.com/game/overwatch-2/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "STAR WARS Jedi: Survivor",
                Subtitle = "The Force Awaits",
                HeroImage = "star_wars_jedi_survivor.png",
                Description = "Star Wars Jedi: Survivor follows Cal Kestis on his journey...",
                AccentColorStart = Color.FromArgb("#595959"),
                AccentColorEnd = Color.FromArgb("#A9A9A9"),
                Category = "Action Games",
                Images = new() 
                {
                    "https://oyster.ignimgs.com/mediawiki/apis.ign.com/star-wars-jedi-survivor/7/7c/STAR_WARS_Jedi_Survivor%E2%84%A2_20230422153756.png",
                    "https://www.starwarsnewsnet.com/wp-content/uploads/2023/05/STAR-WARS-Jedi_-Survivor%E2%84%A2-2023_05_01-01_06_57-e1683014312286.png",
                    "https://cdn.wccftech.com/wp-content/uploads/2022/05/WCCFstarwarsjedisurvivor1.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/star-wars-jedi-survivor/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "League Of Legends",
                Subtitle = "Master the Rift",
                HeroImage = "league_of_legends.png",
                Description = "League of Legends is a competitive multiplayer online battle arena (MOBA)...",
                AccentColorStart = Color.FromArgb("#7F4E40"),
                AccentColorEnd = Color.FromArgb("#C29F66"),
                Category = "MOBA Games",
                Images = new() 
                {
                    "https://i.imgur.com/OUBFn0l.png",
                    "https://cdn.sanity.io/images/ccckgjf9/production/38b998e84de5ae4c4cd2121a437f4dd8fc376d5c-919x570.png?max-h=1080&max-w=1920&q=50&fit=scale&auto=format",
                    "https://images.steamusercontent.com/ugc/596931496814107809/647654186D80910A72A11C7FE3A474622D080C82/?imw=1024&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false"
                },
                ReviewsUrl = "https://www.metacritic.com/game/league-of-legends/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Dota 2",
                Subtitle = "The Battle for the Ancients",
                HeroImage = "dota_2.png",
                Description = "Dota 2 is a strategy-heavy multiplayer online battle arena game...",
                AccentColorStart = Color.FromArgb("#7F3E1C"),
                AccentColorEnd = Color.FromArgb("#D9A67B"),
                Category = "MOBA Games",
                Images = new() 
                {
                    "https://shared.fastly.steamstatic.com/store_item_assets/steam/apps/570/ss_d0f973ce376ca5b6c08e081cb035e86ced105fa9.1920x1080.jpg?t=1739210483",
                    "https://shared.fastly.steamstatic.com/store_item_assets/steam/apps/570/ss_b33a65678dc71cc98df4890e22a89601ee56a918.1920x1080.jpg?t=1739210483",
                    "https://miro.medium.com/v2/resize:fit:1400/1*bjX2HdOx9RyFecPCbmOl4w.jpeg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/dota-2/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            },
            new()
            {
                Name = "Counter Strike 2",
                Subtitle = "The Ultimate Tactical Shooter",
                HeroImage = "counter_strike_2.png",
                Description = "Counter-Strike 2 brings the iconic, team-based tactical shooter...",
                AccentColorStart = Color.FromArgb("#505050"),
                AccentColorEnd = Color.FromArgb("#A6A6A6"),
                Category = "FPS Games",
                Images = new() 
                {
                    "https://i.pcmag.com/imagery/articles/049zi8OCKMGMf1zQYUoDBII-4..v1679505245.jpg",
                    "https://cdn.mos.cms.futurecdn.net/sYbjCGR3cgtuKLn6x2Uhgd.jpg",
                    "https://assets.gamearena.gg/wp-content/uploads/2023/06/29234014/Mirage-CS2-1024x577.jpg"
                },
                ReviewsUrl = "https://www.metacritic.com/game/counter-strike-2/user-reviews/?platform=pc",
                Steam = "",
                EpicGames = "",
                Ubisoft = "",
                Xbox = "",
                RockstarGames = "",
                GOG = ""
            }
        };

        public static List<Games> GetFeaturedGames()
        {
            var random = new Random();
            var randomizeGames = games
                .OrderBy(item => random.Next());

            return randomizeGames
                .Take(2)
                .ToList();
        }

        public static List<Games> GetAllGames()
            => games;

    }
}
