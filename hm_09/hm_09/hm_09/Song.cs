using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_09
{
    public enum GenreSong
    {
        notType = 0,
        classical = 1,
        heavy = 2,
        rap = 3,
        rock = 4
    }

    class Song
    {
        public string Title { get; set; }
        public int Minutes { get; set; }
        public string  AutorSong { get; set; }
        public int AlbumYear { get; set; }
        public GenreSong GenreSong;

        public Song(string aTitle, int aMinutes, int aAlbumYear, GenreSong aGenreSong)
        {
            Title = aTitle;
            Minutes = aMinutes;
            AlbumYear = aAlbumYear;
            GenreSong = aGenreSong;
        }

        public Song(string aTitle, int aMinutes, string aAutorSong, int aAlbumYear)
        {
            Title = aTitle;
            Minutes = aMinutes;
            AutorSong = aAutorSong;
            AlbumYear = aAlbumYear;
        }

        public object  GetSongData (Song song)
        {
            //Я так понял что возможно 2 варианта: object и dynamic. Оба варианта оказались рабочими. GenreSong genreSong

            //dynamic GetTypeSong = new   
            object GetTypeSong = new
            {
                song.Title,
                song.Minutes,
                song.AlbumYear,
                song.GenreSong
            };
            return GetTypeSong;
        }
    } 
}
