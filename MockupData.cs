using System;
using System.Collections.Generic;

namespace DesktopPAS
{
    public class MockupData
    {
        public List<AnimeData> GetAnimeBySeason()
        {
            List<AnimeData> animeDataList = new List<AnimeData>
            {
                new AnimeData { Id = 1, Title = "Vinland Saga Season 2", Genre = "Action, Adventure, Drama", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\VinlandSaga2.png", Season = "Winter" },
                new AnimeData { Id = 2, Title = "Tomo-chan wa Onnanoko!", Genre = "Comedy, Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Tomo-chanWaOnnanoko!.png", Season = "Winter" },
                new AnimeData { Id = 3, Title = "Tokyo Revengers: Seiya Kessen-hen", Genre = "Action, Drama, Supernatural", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\TokyoRevengers SeiyaKessen-hen.png", Season = "Winter" },
                new AnimeData { Id = 4, Title = "Maou Gakuin no Futekigousha: Shijou Saikyou no Maou no Shiso, Tensei shite Shison-tachi no Gakkou e Kayou II", Genre = "Action, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\MaouGakuinnoFutekigoushaShijouSaikyounoMaounoShiso,TenseishiteShison-tachinoGakkoueKayouII.png", Season = "Winter" },
                new AnimeData { Id = 5, Title = "Otonari no Tenshi-sama ni Itsunomanika Dame Ningen ni Sareteita Ken", Genre = "Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\OtonarinoTenshi-samaniItsunomanika DameNingenni SareteitaKen.png", Season = "Winter" },
                new AnimeData { Id = 6, Title = "Ijiranaide, Nagatoro-san 2nd Attack", Genre = "Comedy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Ijiranaide, Nagatoro-san 2nd Attack.png", Season = "Winter" },
                new AnimeData { Id = 7, Title = "Bungou Stray Dogs 4th Season", Genre = "Action, Mystery, Supernatural", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Bungou Stray Dogs 4th Season.png", Season = "Winter" },
                new AnimeData { Id = 8, Title = "NieR:Automata Ver1.1a", Genre = "Action, Fantasy, Sci-Fi", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\NieRAutomata Ver1.1a.png", Season = "Winter" },
                new AnimeData { Id = 9, Title = "Kimetsu no Yaiba: Katanakaji no Sato-hen", Genre = "Action, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Kimetsu no Yaiba Katanakaji no Sato-hen.png" , Season = "Spring"},
                new AnimeData { Id = 10, Title = "\"Oshi no Ko\"", Genre = "Drama, Supernatural", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Oshi no Ko.png" , Season = "Spring"},
                new AnimeData { Id = 11, Title = "Jigokuraku", Genre = "Action, Adventure, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\igokuraku.png" , Season = "Spring"},
                new AnimeData { Id = 12, Title = "Dr. Stone: New World", Genre = "Adventure, Comedy, Sci-Fi", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Dr. Stone New World.png", Season = "Spring" },
                new AnimeData { Id = 13, Title = "Tengoku Daimakyou", Genre = "Adventure, Mystery, Sci-Fi", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\MaouGakuinnoFutekigoushaShijouSaikyounoMaounoShiso,TenseishiteShison-tachinoGakkoueKayouII.png", Season = "Spring" },
                new AnimeData { Id = 14, Title = "Mashle", Genre = "Action, Comedy, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Mashle.png", Season = "Spring" },
                new AnimeData { Id = 15, Title = "Yamada-kun to Lv999 no Koi wo Suru", Genre = "Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Yamada-kun to Lv999 no Koi wo Suru.png", Season = "Spring" },
                new AnimeData { Id = 16, Title = "Jujutsu Kaisen 2nd Season", Genre = "Action, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Jujutsu Kaisen 2nd Season.png" },
                new AnimeData { Id = 17, Title = "Mushoku Tensei II: Isekai Ittara Honki Dasu", Genre = "Adventure, Drama, Fantasy, Ecchi", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Mushoku Tensei II Isekai Ittara Honki Dasu.png", Season = "Summer" },
                new AnimeData { Id = 18, Title = "Zom 100: Zombie ni Naru made ni Shitai 100 no Koto", Genre = "Action, Comedy, Horror, Supernatural, Suspense", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Zom 100 Zombie ni Naru made ni Shitai 100 no Koto.png", Season = "Summer" },
                new AnimeData { Id = 19, Title = "Horimiya: Piece", Genre = "Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Dr. Stone New World.png", Season = "Summer" },
                new AnimeData { Id = 20, Title = "Bleach: Sennen Kessen-hen - Ketsubetsu-tan", Genre = "Action, Adventure, Fantasy", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Horimiya Piece.png", Season = "Summer" },
                new AnimeData { Id = 21, Title = "Watashi no Shiawase na Kekkon", Genre = "Drama, Fantasy, Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Watashi no Shiawase na Kekkon.png", Season = "Summer" },
                new AnimeData { Id = 22, Title = "Bungou Stray Dogs 5th Season", Genre = "Comedy, Romance", Image = "C:\\Users\\LENOVO\\Pictures\\assets\\Desktop\\Bungou Stray Dogs 5th Season.png", Season = "Summer" }
            };

            return animeDataList;
        }

        public class AnimeData
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public string Image { get; set; }
            public string Season { get; set; }
        }
    }
}
