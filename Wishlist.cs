using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPAS
{
    public class Wishlist
    {
        private static Wishlist instance;
        private List<MockupData.AnimeData> selectedAnimeData;

        private Wishlist()
        {
            selectedAnimeData = new List<MockupData.AnimeData>();
        }

        public static Wishlist Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Wishlist();
                }
                return instance;
            }
        }

        public List<MockupData.AnimeData> SelectedAnimeData
        {
            get { return selectedAnimeData; }
        }

        public void AddSelectedAnime(MockupData.AnimeData animeData)
        {
            selectedAnimeData.Add(animeData);
        }
    }

}
